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
    public partial class RiceBox : Form
    {
        private ChanGenTool cgt;

        public string GetRiceK()
        {
            return lalGeneRiceK.Text;
        }
        public void GetRiceK(out string name, out string unit)
        {
            name = lalGeneRiceK.Text;
            unit = lalGeneRiceKUnit.Text;
        }

        public string GetRiceAOA()
        {
            return lalGeneRiceAOA.Text;
        }
        public void GetRiceAOA(out string name, out string unit)
        {
            name = lalGeneRiceAOA.Text;
            unit = lalGeneRiceAOAUnit.Text;
        }

        public bool SetPara(double riceK, double riceAOA)
        {
            if (cgt == null || !cgt.ParaLimitEst(riceK, ChanGenTool.ChanAssign.gpRiceK) ||
                               !cgt.ParaLimitEst(riceAOA, ChanGenTool.ChanAssign.gpRiceAOA))
                return false;

            txtGeneRiceK.Text = riceK.ToString();
            txtGeneRiceAOA.Text = riceAOA.ToString();
            return true;
        }

        public bool GetPara(out double riceK, out double riceAOA)
        {
            bool isSucceed = true;
            if (!double.TryParse(txtGeneRiceK.Text, out riceK))
                isSucceed = false;
            if (!double.TryParse(txtGeneRiceAOA.Text, out riceAOA))
                isSucceed = false;
            return isSucceed;
        }

        public void SetMainFm(ChanGenTool fm)
        {
            cgt = fm;
        }

        public RiceBox()
        {
            InitializeComponent();
        }

        public RiceBox(ChanGenTool fm)
        {
            InitializeComponent();

            cgt = fm;
        }

        public RiceBox(ChanGenTool fm,double riceK,double riceAOA)
        {
            InitializeComponent();

            cgt = fm;
            txtGeneRiceK.Text = riceK.ToString();
            txtGeneRiceAOA.Text = riceAOA.ToString();
        }

        private void txtInputLimit_TextChanged(object sender, EventArgs e)
        {
            bool isOK = true;
            double dbl;

            if (!double.TryParse(txtGeneRiceK.Text, out dbl) || !cgt.ParaLimitEst(dbl, ChanGenTool.ChanAssign.gpRiceK))
            {
                errorShow.SetError(txtGeneRiceK, cgt.ParaLimitError(ChanGenTool.ChanAssign.gpRiceK));
                isOK = false;
            }
            else
                errorShow.SetError(txtGeneRiceK, null);

            if (!double.TryParse(txtGeneRiceAOA.Text, out dbl) || !cgt.ParaLimitEst(dbl, ChanGenTool.ChanAssign.gpRiceAOA))
            {
                errorShow.SetError(txtGeneRiceAOA, cgt.ParaLimitError(ChanGenTool.ChanAssign.gpRiceAOA));
                isOK = false;
            }
            else
                errorShow.SetError(txtGeneRiceAOA, null);

            btnGeneOk.Enabled = isOK;
        }

        private void txtGeneRiceK_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChanGenTool.InputLimit(sender as TextBox, e, ChanGenTool.InputMod.Int);
        }

        private void txtGeneAOA_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChanGenTool.InputLimit(sender as TextBox, e, ChanGenTool.InputMod.UInt);
        }
    }
}
