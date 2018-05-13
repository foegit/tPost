using System.Drawing;

namespace tPost
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.richTextBoxInputText = new System.Windows.Forms.RichTextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.addDocumentButton = new System.Windows.Forms.Button();
            this.symbolCount = new System.Windows.Forms.Label();
            this.StatusBarPanel = new System.Windows.Forms.Panel();
            this.labelSystemNotif = new System.Windows.Forms.Label();
            this.currentFormat = new System.Windows.Forms.Label();
            this.buttonAddInlineKeyboard = new System.Windows.Forms.Button();
            this.filePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileSizeField = new System.Windows.Forms.Label();
            this.fileNameField = new System.Windows.Forms.Label();
            this.boldButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.panelFormating = new System.Windows.Forms.Panel();
            this.buttonUrlFormating = new System.Windows.Forms.Button();
            this.buttomCodeFormating = new System.Windows.Forms.Button();
            this.AddMediaPanel = new System.Windows.Forms.Panel();
            this.buttonSlideFormatingPanel = new System.Windows.Forms.Button();
            this.buttonTimePicker = new System.Windows.Forms.Button();
            this.LinkPreviewButton = new System.Windows.Forms.Button();
            this.isSilentMessageButton = new System.Windows.Forms.Button();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlText = new System.Windows.Forms.ToolStripMenuItem();
            this.markdownText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.panelEditor = new System.Windows.Forms.Panel();
            this.panelContainIputText = new System.Windows.Forms.Panel();
            this.labelDefaultText = new System.Windows.Forms.Label();
            this.panelUrlButtonStock = new System.Windows.Forms.Panel();
            this.panelDisplayUrlButton = new System.Windows.Forms.Panel();
            this.panelAddInlineKbr = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAddressUrlButton = new System.Windows.Forms.TextBox();
            this.ButtonAddURLButton = new System.Windows.Forms.Button();
            this.textBoxTitleUrlButton = new System.Windows.Forms.TextBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.splitterLeftRightPanels = new System.Windows.Forms.Splitter();
            this.backgroundWorkerSend = new System.ComponentModel.BackgroundWorker();
            this.notifyIconTpost = new System.Windows.Forms.NotifyIcon(this.components);
            this.panelDateTimePicker = new System.Windows.Forms.Panel();
            this.panelDTPControl = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPubHour = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPubDay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPubMinute = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPubMonth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonHideDatePickerPanel = new System.Windows.Forms.Button();
            this.buttonAddNewPubDate = new System.Windows.Forms.Button();
            this.buttonCancelPickPubDate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPubYear = new System.Windows.Forms.TextBox();
            this.StatusBarPanel.SuspendLayout();
            this.filePanel.SuspendLayout();
            this.panelFormating.SuspendLayout();
            this.AddMediaPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelEditor.SuspendLayout();
            this.panelContainIputText.SuspendLayout();
            this.panelUrlButtonStock.SuspendLayout();
            this.panelAddInlineKbr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelDateTimePicker.SuspendLayout();
            this.panelDTPControl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxInputText
            // 
            resources.ApplyResources(this.richTextBoxInputText, "richTextBoxInputText");
            this.richTextBoxInputText.BackColor = System.Drawing.SystemColors.HighlightText;
            this.richTextBoxInputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInputText.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxInputText.Name = "richTextBoxInputText";
            this.richTextBoxInputText.TextChanged += new System.EventHandler(this.msgText_TextChanged);
            this.richTextBoxInputText.Enter += new System.EventHandler(this.richTextBoxInputText_Enter);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.buttonSend, "buttonSend");
            this.buttonSend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSend.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.publicMsg_Click);
            // 
            // addDocumentButton
            // 
            resources.ApplyResources(this.addDocumentButton, "addDocumentButton");
            this.addDocumentButton.BackColor = System.Drawing.Color.Transparent;
            this.addDocumentButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addDocumentButton.FlatAppearance.BorderSize = 0;
            this.addDocumentButton.Name = "addDocumentButton";
            this.addDocumentButton.UseVisualStyleBackColor = false;
            this.addDocumentButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // symbolCount
            // 
            this.symbolCount.BackColor = System.Drawing.Color.PaleTurquoise;
            resources.ApplyResources(this.symbolCount, "symbolCount");
            this.symbolCount.Name = "symbolCount";
            // 
            // StatusBarPanel
            // 
            this.StatusBarPanel.BackColor = System.Drawing.Color.White;
            this.StatusBarPanel.Controls.Add(this.labelSystemNotif);
            this.StatusBarPanel.Controls.Add(this.currentFormat);
            this.StatusBarPanel.Controls.Add(this.buttonAddInlineKeyboard);
            this.StatusBarPanel.Controls.Add(this.symbolCount);
            resources.ApplyResources(this.StatusBarPanel, "StatusBarPanel");
            this.StatusBarPanel.Name = "StatusBarPanel";
            // 
            // labelSystemNotif
            // 
            resources.ApplyResources(this.labelSystemNotif, "labelSystemNotif");
            this.labelSystemNotif.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelSystemNotif.Name = "labelSystemNotif";
            // 
            // currentFormat
            // 
            resources.ApplyResources(this.currentFormat, "currentFormat");
            this.currentFormat.Name = "currentFormat";
            // 
            // buttonAddInlineKeyboard
            // 
            this.buttonAddInlineKeyboard.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.buttonAddInlineKeyboard, "buttonAddInlineKeyboard");
            this.buttonAddInlineKeyboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAddInlineKeyboard.FlatAppearance.BorderSize = 0;
            this.buttonAddInlineKeyboard.Name = "buttonAddInlineKeyboard";
            this.buttonAddInlineKeyboard.UseVisualStyleBackColor = false;
            this.buttonAddInlineKeyboard.Click += new System.EventHandler(this.buttonAddInlineKeyboard_Click);
            // 
            // filePanel
            // 
            this.filePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filePanel.Controls.Add(this.label1);
            this.filePanel.Controls.Add(this.deleteFileButton);
            this.filePanel.Controls.Add(this.fileSizeLabel);
            this.filePanel.Controls.Add(this.fileNameLabel);
            this.filePanel.Controls.Add(this.fileSizeField);
            this.filePanel.Controls.Add(this.fileNameField);
            resources.ApplyResources(this.filePanel, "filePanel");
            this.filePanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filePanel.Name = "filePanel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // deleteFileButton
            // 
            resources.ApplyResources(this.deleteFileButton, "deleteFileButton");
            this.deleteFileButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.UseVisualStyleBackColor = true;
            this.deleteFileButton.Click += new System.EventHandler(this.deleteFileButton_Click);
            // 
            // fileSizeLabel
            // 
            resources.ApplyResources(this.fileSizeLabel, "fileSizeLabel");
            this.fileSizeLabel.Name = "fileSizeLabel";
            // 
            // fileNameLabel
            // 
            resources.ApplyResources(this.fileNameLabel, "fileNameLabel");
            this.fileNameLabel.Name = "fileNameLabel";
            // 
            // fileSizeField
            // 
            resources.ApplyResources(this.fileSizeField, "fileSizeField");
            this.fileSizeField.Name = "fileSizeField";
            // 
            // fileNameField
            // 
            resources.ApplyResources(this.fileNameField, "fileNameField");
            this.fileNameField.Name = "fileNameField";
            // 
            // boldButton
            // 
            this.boldButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.boldButton, "boldButton");
            this.boldButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.boldButton.FlatAppearance.BorderSize = 0;
            this.boldButton.Name = "boldButton";
            this.boldButton.UseVisualStyleBackColor = true;
            this.boldButton.Click += new System.EventHandler(this.boldButton_Click);
            // 
            // italicButton
            // 
            this.italicButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.italicButton, "italicButton");
            this.italicButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.italicButton.FlatAppearance.BorderSize = 0;
            this.italicButton.Name = "italicButton";
            this.italicButton.UseVisualStyleBackColor = true;
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // panelFormating
            // 
            this.panelFormating.BackColor = System.Drawing.Color.White;
            this.panelFormating.Controls.Add(this.buttonUrlFormating);
            this.panelFormating.Controls.Add(this.buttomCodeFormating);
            this.panelFormating.Controls.Add(this.boldButton);
            this.panelFormating.Controls.Add(this.italicButton);
            resources.ApplyResources(this.panelFormating, "panelFormating");
            this.panelFormating.Name = "panelFormating";
            this.panelFormating.Paint += new System.Windows.Forms.PaintEventHandler(this.formatTextPanel_Paint);
            // 
            // buttonUrlFormating
            // 
            this.buttonUrlFormating.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonUrlFormating, "buttonUrlFormating");
            this.buttonUrlFormating.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUrlFormating.FlatAppearance.BorderSize = 0;
            this.buttonUrlFormating.ForeColor = System.Drawing.Color.Black;
            this.buttonUrlFormating.Name = "buttonUrlFormating";
            this.buttonUrlFormating.UseVisualStyleBackColor = true;
            this.buttonUrlFormating.Click += new System.EventHandler(this.urlButton_Click);
            // 
            // buttomCodeFormating
            // 
            this.buttomCodeFormating.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttomCodeFormating, "buttomCodeFormating");
            this.buttomCodeFormating.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttomCodeFormating.FlatAppearance.BorderSize = 0;
            this.buttomCodeFormating.ForeColor = System.Drawing.Color.SkyBlue;
            this.buttomCodeFormating.Name = "buttomCodeFormating";
            this.buttomCodeFormating.UseVisualStyleBackColor = true;
            this.buttomCodeFormating.Click += new System.EventHandler(this.preButton_Click);
            // 
            // AddMediaPanel
            // 
            this.AddMediaPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddMediaPanel.Controls.Add(this.buttonTimePicker);
            this.AddMediaPanel.Controls.Add(this.buttonSlideFormatingPanel);
            this.AddMediaPanel.Controls.Add(this.addDocumentButton);
            this.AddMediaPanel.Controls.Add(this.LinkPreviewButton);
            this.AddMediaPanel.Controls.Add(this.buttonSend);
            this.AddMediaPanel.Controls.Add(this.isSilentMessageButton);
            resources.ApplyResources(this.AddMediaPanel, "AddMediaPanel");
            this.AddMediaPanel.Name = "AddMediaPanel";
            // 
            // buttonSlideFormatingPanel
            // 
            resources.ApplyResources(this.buttonSlideFormatingPanel, "buttonSlideFormatingPanel");
            this.buttonSlideFormatingPanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonSlideFormatingPanel.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.buttonSlideFormatingPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSlideFormatingPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonSlideFormatingPanel.Name = "buttonSlideFormatingPanel";
            this.buttonSlideFormatingPanel.UseVisualStyleBackColor = false;
            this.buttonSlideFormatingPanel.Click += new System.EventHandler(this.buttonOpenFormatingPanel_Click);
            // 
            // buttonTimePicker
            // 
            this.buttonTimePicker.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonTimePicker, "buttonTimePicker");
            this.buttonTimePicker.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.buttonTimePicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonTimePicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonTimePicker.Name = "buttonTimePicker";
            this.buttonTimePicker.UseVisualStyleBackColor = false;
            this.buttonTimePicker.Click += new System.EventHandler(this.buttonTimePicker_Click);
            // 
            // LinkPreviewButton
            // 
            resources.ApplyResources(this.LinkPreviewButton, "LinkPreviewButton");
            this.LinkPreviewButton.BackColor = System.Drawing.Color.Transparent;
            this.LinkPreviewButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.LinkPreviewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LinkPreviewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.LinkPreviewButton.Name = "LinkPreviewButton";
            this.LinkPreviewButton.UseVisualStyleBackColor = false;
            this.LinkPreviewButton.Click += new System.EventHandler(this.LinkPreviewButton_Click);
            // 
            // isSilentMessageButton
            // 
            resources.ApplyResources(this.isSilentMessageButton, "isSilentMessageButton");
            this.isSilentMessageButton.BackColor = System.Drawing.Color.Transparent;
            this.isSilentMessageButton.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.isSilentMessageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.isSilentMessageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.isSilentMessageButton.Name = "isSilentMessageButton";
            this.isSilentMessageButton.UseVisualStyleBackColor = false;
            this.isSilentMessageButton.Click += new System.EventHandler(this.isSilentMessageButton_Click);
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ботToolStripMenuItem});
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            resources.ApplyResources(this.налаштуванняToolStripMenuItem, "налаштуванняToolStripMenuItem");
            // 
            // ботToolStripMenuItem
            // 
            this.ботToolStripMenuItem.Name = "ботToolStripMenuItem";
            resources.ApplyResources(this.ботToolStripMenuItem, "ботToolStripMenuItem");
            // 
            // форматуванняToolStripMenuItem
            // 
            this.форматуванняToolStripMenuItem.Checked = true;
            this.форматуванняToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.форматуванняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.htmlText,
            this.markdownText});
            this.форматуванняToolStripMenuItem.Name = "форматуванняToolStripMenuItem";
            resources.ApplyResources(this.форматуванняToolStripMenuItem, "форматуванняToolStripMenuItem");
            // 
            // htmlText
            // 
            this.htmlText.Name = "htmlText";
            resources.ApplyResources(this.htmlText, "htmlText");
            this.htmlText.CheckedChanged += new System.EventHandler(this.htmlText_CheckedChanged);
            this.htmlText.Click += new System.EventHandler(this.htmlText_Click);
            // 
            // markdownText
            // 
            this.markdownText.Name = "markdownText";
            resources.ApplyResources(this.markdownText, "markdownText");
            this.markdownText.Click += new System.EventHandler(this.markdownText_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.налаштуванняToolStripMenuItem,
            this.форматуванняToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // panelEditor
            // 
            this.panelEditor.BackColor = System.Drawing.Color.Transparent;
            this.panelEditor.Controls.Add(this.panelContainIputText);
            this.panelEditor.Controls.Add(this.panelFormating);
            this.panelEditor.Controls.Add(this.AddMediaPanel);
            resources.ApplyResources(this.panelEditor, "panelEditor");
            this.panelEditor.Name = "panelEditor";
            // 
            // panelContainIputText
            // 
            this.panelContainIputText.BackColor = System.Drawing.Color.White;
            this.panelContainIputText.Controls.Add(this.panelDateTimePicker);
            this.panelContainIputText.Controls.Add(this.labelDefaultText);
            this.panelContainIputText.Controls.Add(this.richTextBoxInputText);
            this.panelContainIputText.Controls.Add(this.filePanel);
            resources.ApplyResources(this.panelContainIputText, "panelContainIputText");
            this.panelContainIputText.Name = "panelContainIputText";
            // 
            // labelDefaultText
            // 
            resources.ApplyResources(this.labelDefaultText, "labelDefaultText");
            this.labelDefaultText.BackColor = System.Drawing.Color.Transparent;
            this.labelDefaultText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelDefaultText.ForeColor = System.Drawing.Color.Silver;
            this.labelDefaultText.Name = "labelDefaultText";
            this.labelDefaultText.Click += new System.EventHandler(this.labelDefaultText_Click);
            // 
            // panelUrlButtonStock
            // 
            this.panelUrlButtonStock.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.panelUrlButtonStock, "panelUrlButtonStock");
            this.panelUrlButtonStock.Controls.Add(this.panelDisplayUrlButton);
            this.panelUrlButtonStock.Controls.Add(this.panelAddInlineKbr);
            this.panelUrlButtonStock.Name = "panelUrlButtonStock";
            this.panelUrlButtonStock.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUrlButtonStock_Paint);
            // 
            // panelDisplayUrlButton
            // 
            resources.ApplyResources(this.panelDisplayUrlButton, "panelDisplayUrlButton");
            this.panelDisplayUrlButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDisplayUrlButton.Name = "panelDisplayUrlButton";
            // 
            // panelAddInlineKbr
            // 
            this.panelAddInlineKbr.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.panelAddInlineKbr, "panelAddInlineKbr");
            this.panelAddInlineKbr.Name = "panelAddInlineKbr";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.textBoxAddressUrlButton);
            this.groupBox1.Controls.Add(this.ButtonAddURLButton);
            this.groupBox1.Controls.Add(this.textBoxTitleUrlButton);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // textBoxAddressUrlButton
            // 
            resources.ApplyResources(this.textBoxAddressUrlButton, "textBoxAddressUrlButton");
            this.textBoxAddressUrlButton.ForeColor = System.Drawing.Color.Silver;
            this.textBoxAddressUrlButton.Name = "textBoxAddressUrlButton";
            this.textBoxAddressUrlButton.Enter += new System.EventHandler(this.textBoxAddressUrlButton_Enter);
            this.textBoxAddressUrlButton.Leave += new System.EventHandler(this.textBoxAddressUrlButton_Leave);
            // 
            // ButtonAddURLButton
            // 
            resources.ApplyResources(this.ButtonAddURLButton, "ButtonAddURLButton");
            this.ButtonAddURLButton.BackColor = System.Drawing.Color.Ivory;
            this.ButtonAddURLButton.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.ButtonAddURLButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.ButtonAddURLButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LawnGreen;
            this.ButtonAddURLButton.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddURLButton.Name = "ButtonAddURLButton";
            this.ButtonAddURLButton.UseVisualStyleBackColor = false;
            this.ButtonAddURLButton.Click += new System.EventHandler(this.ButtonAddURLButton_Click);
            // 
            // textBoxTitleUrlButton
            // 
            this.textBoxTitleUrlButton.AllowDrop = true;
            resources.ApplyResources(this.textBoxTitleUrlButton, "textBoxTitleUrlButton");
            this.textBoxTitleUrlButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTitleUrlButton.ForeColor = System.Drawing.Color.Silver;
            this.textBoxTitleUrlButton.Name = "textBoxTitleUrlButton";
            this.textBoxTitleUrlButton.Enter += new System.EventHandler(this.textBoxTitleUrlButton_Enter);
            this.textBoxTitleUrlButton.Leave += new System.EventHandler(this.textBoxTitleUrlButton_Leave);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkViolet;
            this.panelLeft.Controls.Add(this.panelUrlButtonStock);
            resources.ApplyResources(this.panelLeft, "panelLeft");
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.VisibleChanged += new System.EventHandler(this.panelLeft_VisibleChanged);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.Crimson;
            this.panelRight.Controls.Add(this.panelEditor);
            resources.ApplyResources(this.panelRight, "panelRight");
            this.panelRight.Name = "panelRight";
            // 
            // splitterLeftRightPanels
            // 
            resources.ApplyResources(this.splitterLeftRightPanels, "splitterLeftRightPanels");
            this.splitterLeftRightPanels.Name = "splitterLeftRightPanels";
            this.splitterLeftRightPanels.TabStop = false;
            // 
            // backgroundWorkerSend
            // 
            this.backgroundWorkerSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerSend_DoWork);
            // 
            // notifyIconTpost
            // 
            this.notifyIconTpost.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIconTpost, "notifyIconTpost");
            this.notifyIconTpost.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // panelDateTimePicker
            // 
            this.panelDateTimePicker.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDateTimePicker.Controls.Add(this.panel2);
            this.panelDateTimePicker.Controls.Add(this.panelDTPControl);
            resources.ApplyResources(this.panelDateTimePicker, "panelDateTimePicker");
            this.panelDateTimePicker.Name = "panelDateTimePicker";
            // 
            // panelDTPControl
            // 
            this.panelDTPControl.BackColor = System.Drawing.Color.Crimson;
            this.panelDTPControl.Controls.Add(this.buttonHideDatePickerPanel);
            this.panelDTPControl.Controls.Add(this.label3);
            resources.ApplyResources(this.panelDTPControl, "panelDTPControl");
            this.panelDTPControl.Name = "panelDTPControl";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.buttonCancelPickPubDate);
            this.panel2.Controls.Add(this.buttonAddNewPubDate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxPubYear);
            this.panel2.Controls.Add(this.textBoxPubMonth);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxPubMinute);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxPubDay);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxPubHour);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPubHour
            // 
            this.textBoxPubHour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxPubHour, "textBoxPubHour");
            this.textBoxPubHour.Name = "textBoxPubHour";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxPubDay
            // 
            this.textBoxPubDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxPubDay, "textBoxPubDay");
            this.textBoxPubDay.Name = "textBoxPubDay";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxPubMinute
            // 
            this.textBoxPubMinute.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxPubMinute, "textBoxPubMinute");
            this.textBoxPubMinute.Name = "textBoxPubMinute";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Name = "label6";
            // 
            // textBoxPubMonth
            // 
            this.textBoxPubMonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxPubMonth, "textBoxPubMonth");
            this.textBoxPubMonth.Name = "textBoxPubMonth";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Name = "label7";
            // 
            // buttonHideDatePickerPanel
            // 
            resources.ApplyResources(this.buttonHideDatePickerPanel, "buttonHideDatePickerPanel");
            this.buttonHideDatePickerPanel.BackColor = System.Drawing.Color.Transparent;
            this.buttonHideDatePickerPanel.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.buttonHideDatePickerPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonHideDatePickerPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.buttonHideDatePickerPanel.Name = "buttonHideDatePickerPanel";
            this.buttonHideDatePickerPanel.UseVisualStyleBackColor = false;
            this.buttonHideDatePickerPanel.Click += new System.EventHandler(this.buttonHideDatePickerPanel_Click);
            // 
            // buttonAddNewPubDate
            // 
            resources.ApplyResources(this.buttonAddNewPubDate, "buttonAddNewPubDate");
            this.buttonAddNewPubDate.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddNewPubDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddNewPubDate.Name = "buttonAddNewPubDate";
            this.buttonAddNewPubDate.UseVisualStyleBackColor = false;
            this.buttonAddNewPubDate.Click += new System.EventHandler(this.buttonAddNewPubDate_Click);
            // 
            // buttonCancelPickPubDate
            // 
            resources.ApplyResources(this.buttonCancelPickPubDate, "buttonCancelPickPubDate");
            this.buttonCancelPickPubDate.BackColor = System.Drawing.Color.Coral;
            this.buttonCancelPickPubDate.Name = "buttonCancelPickPubDate";
            this.buttonCancelPickPubDate.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Name = "label8";
            // 
            // textBoxPubYear
            // 
            this.textBoxPubYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxPubYear, "textBoxPubYear");
            this.textBoxPubYear.Name = "textBoxPubYear";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.splitterLeftRightPanels);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.StatusBarPanel);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.StatusBarPanel.ResumeLayout(false);
            this.StatusBarPanel.PerformLayout();
            this.filePanel.ResumeLayout(false);
            this.filePanel.PerformLayout();
            this.panelFormating.ResumeLayout(false);
            this.AddMediaPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelEditor.ResumeLayout(false);
            this.panelContainIputText.ResumeLayout(false);
            this.panelContainIputText.PerformLayout();
            this.panelUrlButtonStock.ResumeLayout(false);
            this.panelAddInlineKbr.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelDateTimePicker.ResumeLayout(false);
            this.panelDTPControl.ResumeLayout(false);
            this.panelDTPControl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInputText;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button addDocumentButton;
        private System.Windows.Forms.Label symbolCount;
        private System.Windows.Forms.Panel StatusBarPanel;
        private System.Windows.Forms.Label currentFormat;
        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileSizeField;
        private System.Windows.Forms.Label fileNameField;
        private System.Windows.Forms.Button deleteFileButton;
        private System.Windows.Forms.Button boldButton;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelFormating;
        private System.Windows.Forms.Panel AddMediaPanel;
        private System.Windows.Forms.Button buttomCodeFormating;
        private System.Windows.Forms.Button buttonUrlFormating;
        private System.Windows.Forms.Button isSilentMessageButton;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ботToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlText;
        private System.Windows.Forms.ToolStripMenuItem markdownText;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel panelEditor;
        private System.Windows.Forms.Panel panelUrlButtonStock;
        private System.Windows.Forms.Button LinkPreviewButton;
        private System.Windows.Forms.Button buttonAddInlineKeyboard;
        private System.Windows.Forms.Panel panelDisplayUrlButton;
        private System.Windows.Forms.Panel panelAddInlineKbr;
        private System.Windows.Forms.TextBox textBoxAddressUrlButton;
        private System.Windows.Forms.TextBox textBoxTitleUrlButton;
        private System.Windows.Forms.Button ButtonAddURLButton;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Splitter splitterLeftRightPanels;
        private System.Windows.Forms.Panel panelContainIputText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTimePicker;
        private System.Windows.Forms.Label labelDefaultText;
        private System.Windows.Forms.Button buttonSlideFormatingPanel;
        private System.Windows.Forms.Label labelSystemNotif;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSend;
        private System.Windows.Forms.NotifyIcon notifyIconTpost;
        private System.Windows.Forms.Panel panelDateTimePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDTPControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPubMinute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPubDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPubHour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPubMonth;
        private System.Windows.Forms.Button buttonHideDatePickerPanel;
        private System.Windows.Forms.Button buttonCancelPickPubDate;
        private System.Windows.Forms.Button buttonAddNewPubDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPubYear;
    }
}

