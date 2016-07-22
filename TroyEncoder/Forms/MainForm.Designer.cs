namespace TroyEncoder.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._fileList = new System.Windows.Forms.ListBox();
            this.mainFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._progress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this._extCombo = new System.Windows.Forms.ToolStripComboBox();
            this.decodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._convertedFile = new System.Windows.Forms.LinkLabel();
            this._encodeFldrLabel = new System.Windows.Forms.LinkLabel();
            this._folderSelectDlg = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _fileList
            // 
            this._fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._fileList.DataSource = this.mainFormBindingSource;
            this._fileList.FormattingEnabled = true;
            this._fileList.Location = new System.Drawing.Point(12, 32);
            this._fileList.Name = "_fileList";
            this._fileList.Size = new System.Drawing.Size(432, 199);
            this._fileList.TabIndex = 0;
            this._fileList.SelectedIndexChanged += new System.EventHandler(this._fileList_SelectedIndexChanged);
            // 
            // mainFormBindingSource
            // 
            this.mainFormBindingSource.DataSource = typeof(TroyEncoder.Forms.MainForm);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this._progress,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 266);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(456, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(428, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "Ready.";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _progress
            // 
            this._progress.Name = "_progress";
            this._progress.Size = new System.Drawing.Size(100, 16);
            this._progress.Visible = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._extCombo,
            this.decodeToolStripMenuItem,
            this.encodeToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(13, 20);
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // _extCombo
            // 
            this._extCombo.Items.AddRange(new object[] {
            "*.uue",
            "*.*"});
            this._extCombo.Name = "_extCombo";
            this._extCombo.Size = new System.Drawing.Size(121, 23);
            this._extCombo.Text = global::TroyEncoder.Properties.Settings.Default.SearchPattern;
            this._extCombo.ToolTipText = "Filter list by file extension";
            this._extCombo.TextChanged += new System.EventHandler(this._extCombo_TextChanged);
            // 
            // decodeToolStripMenuItem
            // 
            this.decodeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
            this.decodeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.decodeToolStripMenuItem.Text = "Decode";
            this.decodeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.decodeToolStripMenuItem.Click += new System.EventHandler(this.decodeToolStripMenuItem_Click);
            // 
            // encodeToolStripMenuItem
            // 
            this.encodeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.encodeToolStripMenuItem.Name = "encodeToolStripMenuItem";
            this.encodeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.encodeToolStripMenuItem.Text = "Encode";
            this.encodeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.encodeToolStripMenuItem.Click += new System.EventHandler(this.encodeToolStripMenuItem_Click);
            // 
            // _convertedFile
            // 
            this._convertedFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._convertedFile.AutoSize = true;
            this._convertedFile.Location = new System.Drawing.Point(13, 239);
            this._convertedFile.Name = "_convertedFile";
            this._convertedFile.Size = new System.Drawing.Size(0, 13);
            this._convertedFile.TabIndex = 3;
            this._convertedFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._convertedFile_LinkClicked);
            // 
            // _encodeFldrLabel
            // 
            this._encodeFldrLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._encodeFldrLabel.AutoSize = true;
            this._encodeFldrLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TroyEncoder.Properties.Settings.Default, "EncodedFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._encodeFldrLabel.Location = new System.Drawing.Point(12, 12);
            this._encodeFldrLabel.Name = "_encodeFldrLabel";
            this._encodeFldrLabel.Size = new System.Drawing.Size(309, 13);
            this._encodeFldrLabel.TabIndex = 1;
            this._encodeFldrLabel.TabStop = true;
            this._encodeFldrLabel.Text = global::TroyEncoder.Properties.Settings.Default.EncodedFolder;
            this._encodeFldrLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._encodeFldrLabel_LinkClicked);
            // 
            // _folderSelectDlg
            // 
            this._folderSelectDlg.SelectedPath = global::TroyEncoder.Properties.Settings.Default.EncodedFolder;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 288);
            this.Controls.Add(this._convertedFile);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this._encodeFldrLabel);
            this.Controls.Add(this._fileList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Troy\'s UUEncoder / UUDecoder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainFormBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog _folderSelectDlg;
        private System.Windows.Forms.ListBox _fileList;
        private System.Windows.Forms.LinkLabel _encodeFldrLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar _progress;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem encodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decodeToolStripMenuItem;
        private System.Windows.Forms.LinkLabel _convertedFile;
        private System.Windows.Forms.BindingSource mainFormBindingSource;
        private System.Windows.Forms.ToolStripComboBox _extCombo;
    }
}

