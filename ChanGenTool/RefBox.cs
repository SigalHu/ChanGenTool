using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChanGenTool
{
    public partial class RefBox : Form
    {
        private ChanGenTool cgt;

        public string GetDielectric()
        {
            return lalAeroDielectric.Text;
        }

        public bool SetDielectric(double dielectric)
        {
            if (cgt == null || !cgt.ParaLimitEst(dielectric, ChanGenTool.ChanAssign.apDielectric))
                return false;

            txtAeroDielectric.Text = dielectric.ToString();
            return true;
        }

        public string GetConductivity()
        {
            return lalAeroConductivity.Text;
        }

        public bool SetConductivity(double conductivity)
        {
            if (cgt == null || !cgt.ParaLimitEst(conductivity, ChanGenTool.ChanAssign.apConductivity))
                return false;

            txtAeroConductivity.Text = conductivity.ToString();
            return true;
        }

        public string GetAngSp()
        {
            return lalAeroAngSp.Text;
        }
        public void GetAngSp(out string name, out string unit)
        {
            name = lalAeroAngSp.Text;
            unit = lalAeroAngSpUnit.Text;
        }

        public bool SetAngSp(double angSp)
        {
            if (cgt == null || !cgt.ParaLimitEst(angSp, ChanGenTool.ChanAssign.apAngSp))
                return false;

            txtAeroAngSp.Text = angSp.ToString();
            return true;
        }

        public bool SetPara(double dielectric, double conductivity, double angSp)
        {
            if (cgt == null || !cgt.ParaLimitEst(dielectric, ChanGenTool.ChanAssign.apDielectric) ||
                               !cgt.ParaLimitEst(conductivity, ChanGenTool.ChanAssign.apConductivity) ||
                               !cgt.ParaLimitEst(angSp, ChanGenTool.ChanAssign.apAngSp))
                return false;

            txtAeroDielectric.Text = dielectric.ToString();
            txtAeroConductivity.Text = conductivity.ToString();
            txtAeroAngSp.Text = angSp.ToString();
            return true;
        }

        public bool GetPara(out double dielectric, out double conductivity, out double angSp)
        {
            bool isSucceed = true;
            if (!double.TryParse(txtAeroDielectric.Text, out dielectric))
                isSucceed = false;
            if (!double.TryParse(txtAeroConductivity.Text, out conductivity))
                isSucceed = false;
            if (!double.TryParse(txtAeroAngSp.Text, out angSp))
                isSucceed = false;
            return isSucceed;
        }

        public void SetMainFm(ChanGenTool fm)
        {
            cgt = fm;
        }

        public RefBox()
        {
            InitializeComponent();
        }

        public RefBox(ChanGenTool fm, double dielectric, double conductivity, double angSp)
        {
            InitializeComponent();

            cgt = fm;
            txtAeroDielectric.Text = dielectric.ToString();
            txtAeroConductivity.Text = conductivity.ToString();
            txtAeroAngSp.Text = angSp.ToString();
        }

        private void txtInputUFloat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ChanGenTool.InputLimit(sender as TextBox, e, ChanGenTool.InputMod.UFloat);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            bool isOK = true;
            double dbl;

            if (!double.TryParse(txtAeroDielectric.Text, out dbl) || !cgt.ParaLimitEst(dbl, ChanGenTool.ChanAssign.apDielectric))
            {
                errorShow.SetError(txtAeroDielectric, cgt.ParaLimitError(ChanGenTool.ChanAssign.apDielectric));
                isOK = false;
            }
            else
                errorShow.SetError(txtAeroDielectric, null);

            if (!double.TryParse(txtAeroConductivity.Text, out dbl) || !cgt.ParaLimitEst(dbl, ChanGenTool.ChanAssign.apConductivity))
            {
                errorShow.SetError(txtAeroConductivity, cgt.ParaLimitError(ChanGenTool.ChanAssign.apConductivity));
                isOK = false;
            }
            else
                errorShow.SetError(txtAeroConductivity, null);

            if (!double.TryParse(txtAeroAngSp.Text, out dbl) || !cgt.ParaLimitEst(dbl, ChanGenTool.ChanAssign.apAngSp))
            {
                errorShow.SetError(txtAeroAngSp, cgt.ParaLimitError(ChanGenTool.ChanAssign.apAngSp));
                isOK = false;
            }
            else
                errorShow.SetError(txtAeroAngSp, null);

            btnOk.Enabled = isOK;
        }
    }
}
