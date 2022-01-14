using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace АРМО_test.Controls
{
    public partial class DirectorySource : UserControl
    {
        public DirectorySource()
        {
            InitializeComponent();
        }

        public void Init(string s_path)
        {
            DirectorySourceText.Text = string.IsNullOrWhiteSpace(s_path) ? "" : s_path;
        }

        private void DirectorySourceBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fd = new FolderBrowserDialog())
            {
                fd.ShowNewFolderButton = false;
                fd.SelectedPath = (Directory.Exists(DirectorySourceText.Text.Trim()) ? DirectorySourceText.Text.Trim() : "");
                if(fd.ShowDialog() == DialogResult.OK)
                    DirectorySourceText.Text = fd.SelectedPath;
            }
        }
    }
}
