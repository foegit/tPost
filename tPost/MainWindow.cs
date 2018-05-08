using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tPost.IMessageContent;
using Telegram.Bot.Types.Enums;


namespace tPost
{
    enum FormatType
    {
        Html,
        Markdown,
        Simple
    }


    public partial class MainWindow : Form
    {



        private TelegramMessage _message;

        public event EventHandler ParseModeChange;

        public MainWindow()
        {
            InitializeComponent();
            _message = new TelegramMessage();
            ParseModeChange += ParseModeChangeHandler;
            if (!((SimpleText) _message.Content).DisablePagePrewiew)
            {
                LinkPreviewButton.Image = Image.FromFile(@"...\...\img\linkpreview.png");
            }
            else
            {
                LinkPreviewButton.Image = Image.FromFile(@"...\...\img\noview.png");
            }
            
            
        }

        public void ToSimpleTextMode()
        {
            _message.Content = new SimpleText();

            FormatingEnabled();
            currentFormat.Image = Image.FromFile(@"...\...\img\normal.png");
            currentFormat.Text = @"Текст";
            msgText.MaxLength = _message.MaxLenth;

            msgText_TextChanged(this, EventArgs.Empty);
            filePanel.Hide();
        }
        private void ParseModeChangeHandler(object sender, EventArgs args)
        {
            if (htmlText.Checked)
            {
                currentFormat.Text = @"HTML";
                currentFormat.Image = Image.FromFile(@"...\...\img\html.png");
                formatTextPanel.Visible = true;
                
                (_message.Content as SimpleText)?.ChangeParseMode(ParseMode.Html);
                if (msgText.Height == 264)
                {
                    msgText.Height -= 40;
                }



            }
            else if (markdownText.Checked)
            {
                currentFormat.Text = @"Markdown";
                currentFormat.Image = Image.FromFile(@"...\...\img\markdown.png");
                formatTextPanel.Visible = true;
                (_message.Content as SimpleText)?.ChangeParseMode(ParseMode.Markdown);
            }
            else
            {
                if (msgText.Height == 224)
                {
                    msgText.Height += 40;
                }
                formatTextPanel.Visible = false;
                currentFormat.Image = Image.FromFile(@"...\...\img\normal.png");
                currentFormat.Text = @"Simple";
                (_message.Content as SimpleText)?.ChangeParseMode(ParseMode.Default);
            }
        }

        private async void publicMsg_Click(object sender, EventArgs e)
        {
            try
            {
                publicMsg.Enabled = false;
                await _message.Send();


            }
            catch (Exception exception)
            {
                MessageBox.Show($@"Ох, лишенько! Здається ви щось не так робите, тому що {exception.Message}");
            }
            finally
            {
                msgText.Focus();
                publicMsg.Enabled = true;
                if (!(_message.Content is SimpleText))
                {
                    ToSimpleTextMode();
                    
                }

            }
        }

        private void addDocumentButton_Click(object sender, EventArgs e)
        {

            if (msgText.Text.Length > 201)
            {
                MessageBox.Show(@"Опис файлу може містити не більше 201 символ.");
                msgText.Focus();
                return;
            }

            var fDialog = new OpenFileDialog();

            void FileOk(object s, CancelEventArgs args)
            {

                _message = new DocumentMessage(fDialog.FileName);

                fileNameLabel.Text = ((Document)_message.Content).FileName;
                fileSizeLabel.Text = ((Document)_message.Content).GetFormatedFileSize();
                msgText_TextChanged(this, EventArgs.Empty);
                filePanel.Visible = true;
                FormatingDisabled();
                currentFormat.Image = Image.FromFile(@"...\...\img\cloud.png");
                currentFormat.Text = @"File";
            }

            fDialog.FileOk += FileOk;
            fDialog.ShowDialog();
        }

        private void msgText_TextChanged(object sender, EventArgs e)
        {
            symbolCount.Text = $@"{msgText.Text.Length}/{msgText.MaxLength}";
            if (msgText.Text.Length != 4096)
            {
                _message.Text = msgText.Text;
                symbolCount.BackColor = Color.PaleTurquoise;

            }
            else
            {
                symbolCount.BackColor = Color.PaleVioletRed;
            }


        }



        private void htmlText_Click(object sender, EventArgs e)
        {
            markdownText.Checked = false;
            htmlText.Checked = !htmlText.Checked;

            ParseModeChange?.Invoke(this, EventArgs.Empty);
        }

        private void markdownText_Click(object sender, EventArgs e)
        {
            htmlText.Checked = false;
            markdownText.Checked = !markdownText.Checked;
            ParseModeChange?.Invoke(this, EventArgs.Empty);

        }


        private void FormatingDisabled()
        {
            htmlText.Checked = false;
            markdownText.Checked = false;
            htmlText.Enabled = false;
            markdownText.Enabled = false;
            formatTextPanel.Visible = false;
        }

        private void FormatingEnabled()
        {
            htmlText.Enabled = true;
            markdownText.Enabled = true;
        }

        private void deleteFileButton_Click(object sender, EventArgs e)
        {
            ToSimpleTextMode();
        }

        private void TagAroundSelection(string tagName, params string[] attributs)
        {
            int selectStart = msgText.SelectionStart;
            int selectEnd = msgText.SelectionLength + selectStart;

            var startTag = new StringBuilder(tagName);

            if (attributs != null)
            {
                foreach (var attr in attributs)
                {
                    startTag.Append($" {attr}");
                }
            }

            msgText.Text = msgText.Text.Insert(selectStart, $"<{startTag}>");
            msgText.Text = msgText.Text.Insert(selectEnd + startTag.Length + 2, $"</{tagName}>");
        }
        private void MarkAroundSelection(string mark)
        {
            int selectStart = msgText.SelectionStart;
            int selectEnd = msgText.SelectionLength + selectStart;

            msgText.Text = msgText.Text.Insert(selectStart, $"{mark}");
            msgText.Text = msgText.Text.Insert(selectEnd + mark.Length, $"{mark}");
        }

        //[название URL](http://www.example.com/)

        private void UrlMarkAroundSelecction()
        {

            // TODO
            int selectStart = msgText.SelectionStart;
            int selectEnd = msgText.SelectionLength + selectStart;


        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            if (htmlText.Checked)
            {
                TagAroundSelection("b");
            }
            else if (markdownText.Checked)
            {
                MarkAroundSelection("*");
            }
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            if (htmlText.Checked)
            {
                TagAroundSelection("i");
            }
            else if (markdownText.Checked)
            {
                MarkAroundSelection("_");
            }
        }

        private void preButton_Click(object sender, EventArgs e)
        {
            if (htmlText.Checked)
            {
                TagAroundSelection("code");
            }
            else if (markdownText.Checked)
            {
                MarkAroundSelection("`");
            }
        }
        private void urlButton_Click(object sender, EventArgs e)
        {
            if (htmlText.Checked)

            {
                TagAroundSelection("a", "href=\"\"");
            }
            else if (markdownText.Checked)
            {
                MarkAroundSelection("`");
            }
        }

        private void formatTextPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void isSilentMessageButton_Click(object sender, EventArgs e)
        {
            if (_message.DisableNotification)
            {
                _message.DisableNotification = false;
                isSilentMessageButton.Image = new Bitmap(@"...\...\img\alarm-clock.png");
            }
            else
            {
                _message.DisableNotification = true;
                isSilentMessageButton.Image = new Bitmap(@"...\...\img\silent.png");
            }

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void LinkPreviewButton_Click(object sender, EventArgs e)
        {
            if (_message.Content is SimpleText)
            {
                if ((_message.Content as SimpleText).DisablePagePrewiew)
                {
                    (_message.Content as SimpleText).DisablePagePrewiew = false;
                    LinkPreviewButton.Image = new Bitmap(@"...\...\img\linkpreview.png");
                }
                else
                {
                    (_message.Content as SimpleText).DisablePagePrewiew = true;
                    LinkPreviewButton.Image = new Bitmap(@"...\...\img\noview.png");
                }
            }

            msgText.Focus();
        }
    }
}
