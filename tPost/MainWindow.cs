using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using tPost.IMessageContent;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;


namespace tPost
{



    public partial class MainWindow : Form
    {
        private readonly TelegramMessage _message;
        private DateTime _publicationTime;
        private readonly PostponedMaster _postponedMaster;
        private bool _isPostponed;

        public event EventHandler ParseModeChange;
       


        public MainWindow()
        {

            _isPostponed = false;

            _postponedMaster = new PostponedMaster();
            _publicationTime = new DateTime();

            InitializeComponent();

            _message = new TelegramMessage();
            ParseModeChange += ParseModeChangeHandler;
     

            if (!((SimpleText)_message.Content).DisablePagePrewiew)
            {
                LinkPreviewButton.Image = Image.FromFile(@"...\...\img\linkpreview.png");
            }
            else
            {
                LinkPreviewButton.Image = Image.FromFile(@"...\...\img\noview.png");
            }

            _message.UbPanels.ListChange += UBListChangeHandler;
            SyncSettings();
            SyncTimePickerValues();



        }


        private void SyncTimePickerValues()
        {
            textBoxPubHour.Text = DateTime.Now.Hour.ToString();
            textBoxPubMinute.Text = DateTime.Now.Minute.ToString();
            textBoxPubDay.Text = DateTime.Now.Day.ToString();
            textBoxPubMonth.Text = DateTime.Now.Month.ToString();
            textBoxPubYear.Text = DateTime.Now.Year.ToString();
        }
        public void ToSimpleTextMode()
        {
            _message.Content = new SimpleText();

            FormatingEnabled();
            currentFormat.Image = Image.FromFile(@"...\...\img\normal.png");
            currentFormat.Text = @"Текст";
            richTextBoxInputText.MaxLength = _message.MaxLenth;

            msgText_TextChanged(this, EventArgs.Empty);
            buttonSlideFormatingPanel.Enabled = true;
            filePanel.Hide();
        }

        private void UBListChangeHandler(object sender, EventArgs args)
        {

            DrawUbPanels();

        }
        private void ParseModeChangeHandler(object sender, EventArgs args)
        {
            if (htmlText.Checked)
            {
                currentFormat.Text = @"HTML";
                currentFormat.Image = Image.FromFile(@"...\...\img\html.png");
                panelFormating.Visible = true;

                (_message.Content as SimpleText)?.ChangeParseMode(ParseMode.Html);
                if (richTextBoxInputText.Height == 264)
                {
                    richTextBoxInputText.Height -= 40;
                }
           
            }
            else if (markdownText.Checked)
            {
                currentFormat.Text = @"Markdown";
                currentFormat.Image = Image.FromFile(@"...\...\img\markdown.png");
                panelFormating.Visible = true;
                (_message.Content as SimpleText)?.ChangeParseMode(ParseMode.Markdown);
            }
            else
            {
                if (richTextBoxInputText.Height == 224)
                {
                    richTextBoxInputText.Height += 40;
                }
                panelFormating.Visible = false;
                currentFormat.Image = Image.FromFile(@"...\...\img\normal.png");
                currentFormat.Text = @"Simple";
                (_message.Content as SimpleText)?.ChangeParseMode(ParseMode.Default);
            }
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            if (_isPostponed)
            {

                _postponedMaster.AddMessage(new PostponedTelegramMessage(_message, _publicationTime));
                MessageBox.Show($@"Повідомлення буде опубліковано о {_publicationTime:t}");
                buttonSend.Image = new Bitmap(@"...\...\img\sent.png");

                _isPostponed = false;
            }
            else
            {
                try
                {
                    buttonSend.Enabled = false;
                    MessageBox.Show(await _message.Send());
                }
                catch (Exception exception)
                {
                    MessageBox.Show($@"Сталась помилка:{Environment.NewLine}{exception.Message}");

                }
                finally
                {
                    richTextBoxInputText.Focus();
                    buttonSend.Enabled = true;
                    if (!(_message.Content is SimpleText))
                    {
                        ToSimpleTextMode();

                    }

                }
            }

        }

        private void addFileButton_Click(object sender, EventArgs e)
        {

            if (richTextBoxInputText.Text.Length > 201)
            {
                MessageBox.Show(@"Опис файлу може містити не більше 201 символ.");
                richTextBoxInputText.Focus();
                return;
            }

            var fDialog = new OpenFileDialog();

            void FileOk(object s, CancelEventArgs args)
            {

                _message.Content = new Document(fDialog.FileName);

                fileNameLabel.Text = ((Document)_message.Content).FileName;
                fileSizeLabel.Text = ((Document)_message.Content).GetFormatedFileSize();
                msgText_TextChanged(this, EventArgs.Empty);
                panelFormating.Visible = false;
                buttonSlideFormatingPanel.Enabled = false;
                filePanel.Visible = true;
                FormatingDisabled();
                currentFormat.Image = Image.FromFile(@"...\...\img\cloud.png");
                currentFormat.Text = @"File";
                richTextBoxInputText.MaxLength = 201;
            }

            fDialog.FileOk += FileOk;
            fDialog.ShowDialog();
        }

        private void msgText_TextChanged(object sender, EventArgs e)
        {

            if (richTextBoxInputText.TextLength == 0)
            {
                labelDefaultText.Show();
            }
            else
            {
                labelDefaultText.Hide();
            }

            symbolCount.Text = $"{richTextBoxInputText.Text.Length}/{_message.MaxLenth}";
            _message.Text = richTextBoxInputText.Text;
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
            panelFormating.Visible = false;
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
            int selectStart = richTextBoxInputText.SelectionStart;
            int selectEnd = richTextBoxInputText.SelectionLength + selectStart;

            var startTag = new StringBuilder(tagName);

            if (attributs != null)
            {
                foreach (var attr in attributs)
                {
                    startTag.Append($" {attr}");
                }
            }

            richTextBoxInputText.Text = richTextBoxInputText.Text.Insert(selectStart, $"<{startTag}>");
            richTextBoxInputText.Text = richTextBoxInputText.Text.Insert(selectEnd + startTag.Length + 2, $"</{tagName}>");
        }
        private void MarkAroundSelection(string mark)
        {
            int selectStart = richTextBoxInputText.SelectionStart;
            int selectEnd = richTextBoxInputText.SelectionLength + selectStart;

            richTextBoxInputText.Text = richTextBoxInputText.Text.Insert(selectStart, $"{mark}");
            richTextBoxInputText.Text = richTextBoxInputText.Text.Insert(selectEnd + mark.Length, $"{mark}");
        }

        //[название URL](http://www.example.com/)

        private void UrlMarkAroundSelecction()
        {

            // TODO add this function
   

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
                UrlMarkAroundSelecction();
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


        }



        private void ButtonAddURLButton_Click(object sender, EventArgs e)
        {
            // TODO: data validation
            _message.AddInlineUrlButton(textBoxTitleUrlButton.Text, textBoxUrlAddress.Text);


        }

        private void DrawUbPanels()
        {
            panelDisplayUrlButton.Controls.Clear();

            for (int i = 0; i < _message.UbPanels.Count; i++)
            {
                panelDisplayUrlButton.Controls.Add(_message.UbPanels[i]);

            }


        }

        private void buttonAddInlineKeyboard_Click(object sender, EventArgs e)
        {


            if (!panelAddInlineKbr.Visible)
            {
                if (Width < 750)
                {
                    Width = 750;
                }

                if (panelPostponedInfo.Visible)
                {
                    Width += 300;
                }

                //splitterLeftRightPanels.Visible = true;
                panelAddInlineKbr.Show();
            }
            else
            {
                // splitterLeftRightPanels.Visible = false;
                panelAddInlineKbr.Hide();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            //if (this.Width  < 600)
            //{
            //    panelLeft.Visible = false;
            //}

            //if (Width >= 750)
            //{
            //    panelLeft.Visible = true;
            //}
        }



   

        private void panelUrlButtonStock_Paint(object sender, PaintEventArgs e)
        {

        }


        private void labelDefaultText_Click(object sender, EventArgs e)
        {
            richTextBoxInputText.Focus();
        }

        private void buttonOpenFormatingPanel_Click(object sender, EventArgs e)
        {
            panelFormating.Visible = !panelFormating.Visible;
            htmlText.Checked = true;
        }

        private void htmlText_CheckedChanged(object sender, EventArgs e)
        {
            ParseModeChange?.Invoke(this, EventArgs.Empty);
        }

        private void buttonTimePicker_Click(object sender, EventArgs e)
        {
            //publicationTime = DateTime.Now;;
            //publicationTime = publicationTime.AddSeconds(10);
            //TestPostponed();

            //notifyIconTpost.ShowBalloonTip(1000,"Новий запис!" , $"Доданий новий відкладений запис, запис опублікується {publicationTime:t}", ToolTipIcon.Info);
            //_message = new TelegramMessage();
            if (panelPostponedInfo.Visible)
            {
                panelPostponedInfo.Hide();
            }
            else
            {
                panelPostponedInfo.Show();
            }


        }

        private void backgroundWorkerSend_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = WindowState == FormWindowState.Normal ? FormWindowState.Minimized : FormWindowState.Normal;
        }



        private void buttonHideDatePickerPanel_Click(object sender, EventArgs e)
        {
            panelPostponedInfo.Hide();
        }

        private void buttonAddNewPubDate_Click(object sender, EventArgs e)
        {

            string pubdate = $"{textBoxPubYear.Text}-{textBoxPubMonth.Text}-{textBoxPubDay.Text} {textBoxPubHour.Text}:{textBoxPubMinute.Text}";
            
            DateTime.TryParse(pubdate, out _publicationTime);
            _isPostponed = true;
            buttonSend.Image = new Bitmap(@"...\...\img\postponedSend.png");


        }



        private void textBoxTitleUrlButton_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTitleUrlButton.Text.Length == 0)
            {
                labelDefualtUrlTitle.Visible = true;
            }
            else
            {
                labelDefualtUrlTitle.Visible = false;
            }


        }

        private void textBoxUrlAddress_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUrlAddress.Text.Length == 0)
            {
                labelDefaultUrlAddress.Visible = true;
            }
            else
            {
                labelDefaultUrlAddress.Visible = false;
            }

        }

        private void buttonHideInlineKbrPanel_Click(object sender, EventArgs e)
        {

            panelAddInlineKbr.Hide();
        }


        private void subPanel_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void panelEditor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxPubHour_TextChanged(object sender, EventArgs e)
        {
            //string s = textBoxPubHour.Text;
            //int hh;
            //if (int.TryParse(s, out hh))
            //{
            //    if (hh < 23)
            //    {
            //        textBoxPubHour.Text = $@"{hh:00}";
            //    }
            //    else
            //    {
            //        textBoxPubHour.Text = $@"{hh:00}";
            //    }
            //}
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BotToken = textBoxSettingsBotToken.Text;
            Properties.Settings.Default.CanalID = textBoxSettingsCanal.Text;
            Properties.Settings.Default.DisableNotification = checkBoxSettingsDisableNotification.Checked;
            Properties.Settings.Default.DisablePagePrewiew = checkBoxSettingsDisablePagePreview.Checked;
            Properties.Settings.Default.Save();
            SyncSettings();
            panelSettings.Hide();
        }

        private void SyncSettings()
        {

            if (Properties.Settings.Default.DisableNotification)
            {
                _message.DisableNotification = true;
                checkBoxSettingsDisableNotification.Checked = true;
                isSilentMessageButton.Image = new Bitmap(@"...\...\img\silent.png");


            }
            else
            {
                _message.DisableNotification = false;
                checkBoxSettingsDisableNotification.Checked = false;
                isSilentMessageButton.Image = new Bitmap(@"...\...\img\alarm-clock.png");

            }
            if (Properties.Settings.Default.DisablePagePrewiew)
            {

                ((SimpleText) _message.Content).DisablePagePrewiew = true;
                checkBoxSettingsDisablePagePreview.Checked = true;
                LinkPreviewButton.Image = new Bitmap(@"...\...\img\noview.png");


            }
            else
            {
                ((SimpleText) _message.Content).DisablePagePrewiew = false;
                checkBoxSettingsDisablePagePreview.Checked = false;
                LinkPreviewButton.Image = new Bitmap(@"...\...\img\linkpreview.png");
            }

            textBoxSettingsBotToken.Text = Properties.Settings.Default.BotToken;
            textBoxSettingsCanal.Text = Properties.Settings.Default.CanalID;
            _message.CanalName = Properties.Settings.Default.CanalID;
            _message.Bot = new TelegramBotClient(Properties.Settings.Default.BotToken);



        }

        private void buttonHideSettingsPanel_Click(object sender, EventArgs e)
        {
            SyncSettings();
            panelSettings.Hide();
        }

        private void buttonOpenSettings_Click(object sender, EventArgs e)
        {
            SyncSettings();
            panelSettings.Visible = !panelSettings.Visible;
        }
    }
}
