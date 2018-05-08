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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.msgText = new System.Windows.Forms.RichTextBox();
            this.publicMsg = new System.Windows.Forms.Button();
            this.addDocumentButton = new System.Windows.Forms.Button();
            this.symbolCount = new System.Windows.Forms.Label();
            this.StatusBarPanel = new System.Windows.Forms.Panel();
            this.currentFormat = new System.Windows.Forms.Label();
            this.filePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileSizeField = new System.Windows.Forms.Label();
            this.fileNameField = new System.Windows.Forms.Label();
            this.boldButton = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.formatTextPanel = new System.Windows.Forms.Panel();
            this.urlButton = new System.Windows.Forms.Button();
            this.preButton = new System.Windows.Forms.Button();
            this.AddMediaPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.addPhotoButton = new System.Windows.Forms.Button();
            this.isSilentMessageButton = new System.Windows.Forms.Button();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlText = new System.Windows.Forms.ToolStripMenuItem();
            this.markdownText = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.TextInputAreaPanel = new System.Windows.Forms.Panel();
            this.MainButtonPanel = new System.Windows.Forms.Panel();
            this.LinkPreviewButton = new System.Windows.Forms.Button();
            this.StatusBarPanel.SuspendLayout();
            this.filePanel.SuspendLayout();
            this.formatTextPanel.SuspendLayout();
            this.AddMediaPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.TextInputAreaPanel.SuspendLayout();
            this.MainButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgText
            // 
            this.msgText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.msgText, "msgText");
            this.msgText.Name = "msgText";
            this.msgText.TextChanged += new System.EventHandler(this.msgText_TextChanged);
            // 
            // publicMsg
            // 
            resources.ApplyResources(this.publicMsg, "publicMsg");
            this.publicMsg.BackColor = System.Drawing.SystemColors.Control;
            this.publicMsg.Name = "publicMsg";
            this.publicMsg.UseVisualStyleBackColor = false;
            this.publicMsg.Click += new System.EventHandler(this.publicMsg_Click);
            // 
            // addDocumentButton
            // 
            resources.ApplyResources(this.addDocumentButton, "addDocumentButton");
            this.addDocumentButton.BackColor = System.Drawing.Color.Transparent;
            this.addDocumentButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addDocumentButton.FlatAppearance.BorderSize = 0;
            this.addDocumentButton.Name = "addDocumentButton";
            this.addDocumentButton.UseVisualStyleBackColor = true;
            this.addDocumentButton.Click += new System.EventHandler(this.addDocumentButton_Click);
            // 
            // symbolCount
            // 
            resources.ApplyResources(this.symbolCount, "symbolCount");
            this.symbolCount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.symbolCount.Name = "symbolCount";
            // 
            // StatusBarPanel
            // 
            this.StatusBarPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StatusBarPanel.Controls.Add(this.currentFormat);
            this.StatusBarPanel.Controls.Add(this.symbolCount);
            resources.ApplyResources(this.StatusBarPanel, "StatusBarPanel");
            this.StatusBarPanel.Name = "StatusBarPanel";
            // 
            // currentFormat
            // 
            resources.ApplyResources(this.currentFormat, "currentFormat");
            this.currentFormat.Name = "currentFormat";
            // 
            // filePanel
            // 
            this.filePanel.BackColor = System.Drawing.Color.LightBlue;
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
            // formatTextPanel
            // 
            this.formatTextPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formatTextPanel.Controls.Add(this.urlButton);
            this.formatTextPanel.Controls.Add(this.preButton);
            this.formatTextPanel.Controls.Add(this.boldButton);
            this.formatTextPanel.Controls.Add(this.italicButton);
            resources.ApplyResources(this.formatTextPanel, "formatTextPanel");
            this.formatTextPanel.Name = "formatTextPanel";
            this.formatTextPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.formatTextPanel_Paint);
            // 
            // urlButton
            // 
            this.urlButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.urlButton, "urlButton");
            this.urlButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.urlButton.FlatAppearance.BorderSize = 0;
            this.urlButton.ForeColor = System.Drawing.Color.Black;
            this.urlButton.Name = "urlButton";
            this.urlButton.UseVisualStyleBackColor = true;
            this.urlButton.Click += new System.EventHandler(this.urlButton_Click);
            // 
            // preButton
            // 
            this.preButton.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.preButton, "preButton");
            this.preButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.preButton.FlatAppearance.BorderSize = 0;
            this.preButton.ForeColor = System.Drawing.Color.SkyBlue;
            this.preButton.Name = "preButton";
            this.preButton.UseVisualStyleBackColor = true;
            this.preButton.Click += new System.EventHandler(this.preButton_Click);
            // 
            // AddMediaPanel
            // 
            this.AddMediaPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddMediaPanel.Controls.Add(this.button1);
            this.AddMediaPanel.Controls.Add(this.addPhotoButton);
            this.AddMediaPanel.Controls.Add(this.addDocumentButton);
            resources.ApplyResources(this.AddMediaPanel, "AddMediaPanel");
            this.AddMediaPanel.Name = "AddMediaPanel";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addPhotoButton
            // 
            resources.ApplyResources(this.addPhotoButton, "addPhotoButton");
            this.addPhotoButton.BackColor = System.Drawing.Color.Transparent;
            this.addPhotoButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addPhotoButton.FlatAppearance.BorderSize = 0;
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.UseVisualStyleBackColor = true;
            // 
            // isSilentMessageButton
            // 
            resources.ApplyResources(this.isSilentMessageButton, "isSilentMessageButton");
            this.isSilentMessageButton.BackColor = System.Drawing.SystemColors.Control;
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
            // 
            // TextInputAreaPanel
            // 
            this.TextInputAreaPanel.BackColor = System.Drawing.Color.Transparent;
            this.TextInputAreaPanel.Controls.Add(this.msgText);
            this.TextInputAreaPanel.Controls.Add(this.formatTextPanel);
            this.TextInputAreaPanel.Controls.Add(this.filePanel);
            resources.ApplyResources(this.TextInputAreaPanel, "TextInputAreaPanel");
            this.TextInputAreaPanel.Name = "TextInputAreaPanel";
            // 
            // MainButtonPanel
            // 
            this.MainButtonPanel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MainButtonPanel, "MainButtonPanel");
            this.MainButtonPanel.Controls.Add(this.LinkPreviewButton);
            this.MainButtonPanel.Controls.Add(this.AddMediaPanel);
            this.MainButtonPanel.Controls.Add(this.isSilentMessageButton);
            this.MainButtonPanel.Controls.Add(this.publicMsg);
            this.MainButtonPanel.Name = "MainButtonPanel";
            // 
            // LinkPreviewButton
            // 
            resources.ApplyResources(this.LinkPreviewButton, "LinkPreviewButton");
            this.LinkPreviewButton.BackColor = System.Drawing.SystemColors.Control;
            this.LinkPreviewButton.Name = "LinkPreviewButton";
            this.LinkPreviewButton.UseVisualStyleBackColor = false;
            this.LinkPreviewButton.Click += new System.EventHandler(this.LinkPreviewButton_Click);
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.MainButtonPanel);
            this.Controls.Add(this.TextInputAreaPanel);
            this.Controls.Add(this.StatusBarPanel);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.StatusBarPanel.ResumeLayout(false);
            this.filePanel.ResumeLayout(false);
            this.filePanel.PerformLayout();
            this.formatTextPanel.ResumeLayout(false);
            this.AddMediaPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.TextInputAreaPanel.ResumeLayout(false);
            this.MainButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox msgText;
        private System.Windows.Forms.Button publicMsg;
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
        private System.Windows.Forms.Panel formatTextPanel;
        private System.Windows.Forms.Panel AddMediaPanel;
        private System.Windows.Forms.Button preButton;
        private System.Windows.Forms.Button urlButton;
        private System.Windows.Forms.Button isSilentMessageButton;
        private System.Windows.Forms.Button addPhotoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ботToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlText;
        private System.Windows.Forms.ToolStripMenuItem markdownText;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel TextInputAreaPanel;
        private System.Windows.Forms.Panel MainButtonPanel;
        private System.Windows.Forms.Button LinkPreviewButton;
    }
}

