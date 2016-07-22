using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TroyEncoder.Model;
using TroyEncoder.Properties;

namespace TroyEncoder.Forms
{
    public partial class MainForm : Form
    {
        public List<string> FileList =>
            Directory.EnumerateFiles(_folderSelectDlg.SelectedPath, SearchPattern).Select(Path.GetFileName).ToList();

        public string SelectedFile { get; private set; }

        private string _searchPattern;
        public string SearchPattern
        {
            get { return _searchPattern; }
            private set
            {
                _searchPattern = value;
                toolStripDropDownButton1.Text = value;
                mainFormBindingSource.DataSource = FileList;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void _encodeFldrLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _folderSelectDlg.ShowDialog();
        }

        private void encodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var file = Path.Combine(_encodeFldrLabel.Text, SelectedFile);
            if (!File.Exists(file))
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                toolStripStatusLabel1.Text = $"Encoding file [{ SelectedFile }]...";
                var uu = new UUFormater();
                var result = uu.EncodeFile(file, $"{ file }.uue");
                toolStripStatusLabel1.Text = @"Encoding complete.";
                _convertedFile.Text = result;
            }
            finally
            {
                toolStripStatusLabel1.Text = @"Ready";
                this.Cursor = Cursors.Default;
            }
        }

        private void decodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ext = Path.GetExtension(SelectedFile);
            var file = Path.Combine(_encodeFldrLabel.Text, SelectedFile);
            if (!File.Exists(file) || ext == null || !ext.Contains("uue"))
                return;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                toolStripStatusLabel1.Text = $"Decoding file [{SelectedFile}]...";
                var uu = new UUFormater();
                var result = uu.DecodeFile(file, _encodeFldrLabel.Text);
                toolStripStatusLabel1.Text = @"Decoding complete.";
                _convertedFile.Text = result;
            }
            finally
            {
                toolStripStatusLabel1.Text = @"Ready";
                this.Cursor = Cursors.Default;
            }
        }

        private void _convertedFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!string.IsNullOrEmpty(_convertedFile.Text) && File.Exists(_convertedFile.Text))
                System.Diagnostics.Process.Start(_convertedFile.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SearchPattern = Settings.Default.SearchPattern;
            _extCombo.Text = SearchPattern;

            _fileList.Focus();
            if (_fileList.Items.Count > 0)
                _fileList.SelectedItem = _fileList.Items[0];
        }

        private void _fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedFile = _fileList.SelectedItem?.ToString();
        }

        private void _extCombo_TextChanged(object sender, EventArgs e)
        {
            SearchPattern = _extCombo.Text;
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            decodeToolStripMenuItem.Enabled = !string.IsNullOrEmpty(SelectedFile) && 
                                                Path.GetExtension(SelectedFile).Contains("uue");
            encodeToolStripMenuItem.Enabled = !string.IsNullOrEmpty(SelectedFile) &&
                                                !Path.GetExtension(SelectedFile).Contains("uue");
        }
    }
}
