using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ChanGenTool
{
    public partial class ConfigBox : Form
    {
        private string defaultDir;
        private string chanFilter;
        private string chanRegex;

        public string GetPath()
        {
            return txtChanCfg.Text;
        }

        public void SetPath(string str)
        {
            txtChanCfg.Text = str;
        }

        public void SetFilter(string filter)
        {
            chanFilter = filter;
        }

        public void SetRegex(string regex)
        {
            chanRegex = regex;
        }

        public void SetDefDir(string defDir)
        {
            defaultDir = defDir;
        }

        public void SetConfig(string filter, string regex, string defDir)
        {
            chanFilter = filter;
            chanRegex = regex;
            defaultDir = defDir;
        }

        public ConfigBox()
        {
            InitializeComponent();
        }

        public ConfigBox(string str,string filter,string regex,string defDir)
        {
            InitializeComponent();

            txtChanCfg.Text = str;
            chanFilter = filter;
            chanRegex = regex;
            defaultDir = defDir;
        }

        private void txtFileExist_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            TipShow.SetToolTip(txt, txt.Text);

            if (!txt.Focused)
                txt.SelectionStart = txt.Text.Length;

            Match mch = Regex.Match(txt.Text, chanRegex, RegexOptions.IgnoreCase);

            errorShow.SetError(txt, null);
            if (!mch.Groups[0].Success || !File.Exists(txt.Text))
            {
                btnCfgOk.Enabled = false;
                errorShow.SetError(txt, "文件不存在");
            }
            else
                btnCfgOk.Enabled = true;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            OpenFileDialog opeFilDia = new OpenFileDialog();
            opeFilDia.Filter = chanFilter;
            opeFilDia.FilterIndex = 1;
            opeFilDia.InitialDirectory = defaultDir;
            opeFilDia.RestoreDirectory = true;
            if (opeFilDia.ShowDialog() == DialogResult.OK)
                txtChanCfg.Text = opeFilDia.FileName;
        }

        private void txtChanCfg_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtChanCfg_DragDrop(object sender, DragEventArgs e)
        {
            string strFilePath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            TextBox txt = sender as TextBox;
            txt.Text = strFilePath;
        }
    }
}
