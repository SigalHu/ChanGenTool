using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ChanGenTool
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", "http://www.nuaa.edu.cn/nuaanew/");
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", "http://ceie.nuaa.edu.cn/");
        }
    }
}
