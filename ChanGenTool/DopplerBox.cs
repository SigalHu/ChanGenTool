using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ChanGenTool
{
    public partial class DopplerBox : Form
    {
        private ChanGenTool cgt;

        public string GetDoppler()
        {
            return lalGeneDoppler.Text;
        }
        public void GetDoppler(out string name, out string unit)
        {
            name = lalGeneDoppler.Text;
            unit = lalGeneDopplerUnit.Text;
        }

        public bool GetDoppler(out double doppler)
        {
            return double.TryParse(txtGeneDoppler.Text, out doppler);
        }

        public bool SetDoppler(double dopplerFre)
        {
            if (cgt == null || !cgt.ParaLimitEst(dopplerFre, ChanGenTool.ChanAssign.gpDopplerFre))
                return false;

            txtGeneDoppler.Text = dopplerFre.ToString();
            return true;
        }

        public void SetMainFm(ChanGenTool fm)
        {
            cgt = fm;
        }

        public DopplerBox()
        {
            InitializeComponent();
        }

        public DopplerBox(ChanGenTool fm)
        {
            InitializeComponent();

            cgt = fm;
        }

        public DopplerBox(ChanGenTool fm, double dopplerFre)
        {
            InitializeComponent();

            cgt = fm;
            txtGeneDoppler.Text = dopplerFre.ToString();
        }

        private void txtInputLimit_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            bool isOK = true;
            double dbl;

            if (!double.TryParse(txtGeneDoppler.Text, out dbl) || !cgt.ParaLimitEst(dbl, ChanGenTool.ChanAssign.gpDopplerFre))
            {
                errorShow.SetError(txtGeneDoppler, cgt.ParaLimitError(ChanGenTool.ChanAssign.gpDopplerFre));
                isOK = false;
            }
            else
                errorShow.SetError(txtGeneDoppler, null);

            btnGeneOk.Enabled = isOK;
        }

        private void txtGeneDoppler_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChanGenTool.InputLimit(sender as TextBox, e, ChanGenTool.InputMod.UInt);
        }
    }
}
