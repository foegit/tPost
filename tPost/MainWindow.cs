using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;


namespace tPost
{
    enum FormatType
    {
        Html,
        Markdown,
        Simple
    }
    public delegate EventHandler Formating();
    public partial class MainWindow : Form
    {
        static TelegramBotClient bot = new TelegramBotClient(Settings.Default.botToken);
        private bool _isFile;
        private bool _isSilent;
        private FileToSend _fileToSend;


        public MainWindow()
        {
            InitializeComponent();
            _isSilent = false;
            _isFile = false;

            void Form(object sender, EventArgs args)
            {

                if (htmlText.Checked)
                {
                    currentFormat.Text = @"HTML";
                    currentFormat.Image = Image.FromFile(@"E:\prog\vs2017\c#\tPost\tPost\img\html.png");
                    formatTextPanel.Visible = true;
                }
                else if (markdownText.Checked)
                {
                    formatTextPanel.Visible = true;
                    currentFormat.Image = Image.FromFile(@"E:\prog\vs2017\c#\tPost\tPost\img\markdown.png");
                    currentFormat.Text = @"Markdown";
                }
                else
                {
                    formatTextPanel.Visible = false;
                    currentFormat.Image = Image.FromFile(@"E:\prog\vs2017\c#\tPost\tPost\img\normal.png");
                    currentFormat.Text = @"Simple";
                }
            }

            FormatChanged += Form;


        }

        private void publicMsg_Click(object sender, EventArgs e)
        {

            if (!_isFile)
            {
                bot.SendTextMessageAsync(Settings.Default.canalIName, msgText.Text, htmlText.Checked ? ParseMode.Html : markdownText.Checked ? ParseMode.Markdown : ParseMode.Default, disableNotification:_isSilent);
            }
            else
            {
                bot.SendDocumentAsync(Settings.Default.canalIName, _fileToSend, msgText.Text);
            }

        }

        private void addFile_Click(object sender, EventArgs e)
        {
            if (msgText.Text.Length > 201)
            {
                MessageBox.Show(@"Опис файлу може містити не більше 201 символ.");
                return;
            }
            var fDialog = new OpenFileDialog();

            void FileOk(object s, CancelEventArgs args)
            {
                if (fDialog.OpenFile().CanRead)
                {
                    FileInfo f = new FileInfo(fDialog.FileName);
                    fileName.Text = f.Name;
                    fileSize.Text = $@"{(double)f.Length / 1024:F} kb";

                    _fileToSend = new FileToSend(fDialog.SafeFileName, (FileStream)fDialog.OpenFile());

                    _isFile = true;
                    msgText.MaxLength = 201;

                    msgText_TextChanged(this, EventArgs.Empty);
                    filePanel.Visible = true;
                    FormatingDisabled();
                    currentFormat.Image = Image.FromFile(@"E:\prog\vs2017\c#\tPost\tPost\img\cloud.png");
                    currentFormat.Text = @"File";
                    msgText.Height -= 40;


                }
            }

            fDialog.FileOk += FileOk;
            fDialog.ShowDialog();
        }

        private void msgText_TextChanged(object sender, EventArgs e)
        {
            symbolCount.Text = $@"{msgText.Text.Length}/{msgText.MaxLength}";
            if (msgText.Text.Length != 4096)
            {

                symbolCount.BackColor = Color.PaleTurquoise;

            }
            else
            {
                symbolCount.BackColor = Color.PaleVioletRed;
            }


        }

        public event EventHandler FormatChanged;

        private void htmlText_Click(object sender, EventArgs e)
        {
            markdownText.Checked = false;
            htmlText.Checked = !htmlText.Checked;

            FormatChanged?.Invoke(this, EventArgs.Empty);
        }

        private void markdownText_Click(object sender, EventArgs e)
        {
            htmlText.Checked = false;
            markdownText.Checked = !markdownText.Checked;
            FormatChanged?.Invoke(this, EventArgs.Empty);

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
            _isFile = false;

            FormatingEnabled();
            currentFormat.Image = Image.FromFile(@"E:\prog\vs2017\c#\tPost\tPost\img\normal.png");
            currentFormat.Text = @"Simple";
            msgText.MaxLength = 4096;
            msgText_TextChanged(sender, e);
            filePanel.Visible = false;
            msgText.Height += 40;
        }

        private void TagAroundSelection(string tagName, params string[] attributs)
        {
            int selectStart = msgText.SelectionStart;
            int selectEnd = msgText.SelectionLength + selectStart;

            var startTag =  new StringBuilder(tagName);
            
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
                TagAroundSelection("a","href=\"\"");
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
            if (_isSilent)
            {
                _isSilent = false;
                isSilentMessageButton.Image = new Bitmap(@"...\...\img\alarm-clock.png");
            }
            else
            {
                _isSilent = true;
                isSilentMessageButton.Image = new Bitmap(@"...\...\img\silent.png");
            }
            
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
