﻿namespace tPost
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
            this.addFile = new System.Windows.Forms.Button();
            this.symbolCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentFormat = new System.Windows.Forms.Label();
            this.filePanel = new System.Windows.Forms.Panel();
            this.fileInfoField = new System.Windows.Forms.Label();
            this.fileSizeField = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.Label();
            this.fileSize = new System.Windows.Forms.Label();
            this.deleteFileButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форматуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.htmlText = new System.Windows.Forms.ToolStripMenuItem();
            this.markdownText = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.filePanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgText
            // 
            resources.ApplyResources(this.msgText, "msgText");
            this.msgText.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            // addFile
            // 
            this.addFile.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.addFile, "addFile");
            this.addFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addFile.FlatAppearance.BorderSize = 0;
            this.addFile.Name = "addFile";
            this.addFile.UseVisualStyleBackColor = true;
            this.addFile.Click += new System.EventHandler(this.addFile_Click);
            // 
            // symbolCount
            // 
            resources.ApplyResources(this.symbolCount, "symbolCount");
            this.symbolCount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.symbolCount.Name = "symbolCount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.currentFormat);
            this.panel1.Controls.Add(this.symbolCount);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // currentFormat
            // 
            resources.ApplyResources(this.currentFormat, "currentFormat");
            this.currentFormat.Name = "currentFormat";
            // 
            // filePanel
            // 
            this.filePanel.BackColor = System.Drawing.SystemColors.Info;
            this.filePanel.Controls.Add(this.label1);
            this.filePanel.Controls.Add(this.deleteFileButton);
            this.filePanel.Controls.Add(this.fileSize);
            this.filePanel.Controls.Add(this.fileName);
            this.filePanel.Controls.Add(this.fileSizeField);
            this.filePanel.Controls.Add(this.fileInfoField);
            resources.ApplyResources(this.filePanel, "filePanel");
            this.filePanel.Name = "filePanel";
            // 
            // fileInfoField
            // 
            resources.ApplyResources(this.fileInfoField, "fileInfoField");
            this.fileInfoField.Name = "fileInfoField";
            // 
            // fileSizeField
            // 
            resources.ApplyResources(this.fileSizeField, "fileSizeField");
            this.fileSizeField.Name = "fileSizeField";
            // 
            // fileName
            // 
            resources.ApplyResources(this.fileName, "fileName");
            this.fileName.Name = "fileName";
            // 
            // fileSize
            // 
            resources.ApplyResources(this.fileSize, "fileSize");
            this.fileSize.Name = "fileSize";
            // 
            // deleteFileButton
            // 
            resources.ApplyResources(this.deleteFileButton, "deleteFileButton");
            this.deleteFileButton.Name = "deleteFileButton";
            this.deleteFileButton.UseVisualStyleBackColor = true;
            this.deleteFileButton.Click += new System.EventHandler(this.deleteFileButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.налаштуванняToolStripMenuItem,
            this.форматуванняToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            resources.ApplyResources(this.налаштуванняToolStripMenuItem, "налаштуванняToolStripMenuItem");
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addFile);
            this.Controls.Add(this.publicMsg);
            this.Controls.Add(this.msgText);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.panel1.ResumeLayout(false);
            this.filePanel.ResumeLayout(false);
            this.filePanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox msgText;
        private System.Windows.Forms.Button publicMsg;
        private System.Windows.Forms.Button addFile;
        private System.Windows.Forms.Label symbolCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label currentFormat;
        private System.Windows.Forms.Panel filePanel;
        private System.Windows.Forms.Label fileSize;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label fileSizeField;
        private System.Windows.Forms.Label fileInfoField;
        private System.Windows.Forms.Button deleteFileButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форматуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem htmlText;
        private System.Windows.Forms.ToolStripMenuItem markdownText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

