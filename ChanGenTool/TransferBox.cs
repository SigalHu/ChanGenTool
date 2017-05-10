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
    public partial class TransferBox : Form
    {
        public TransferBox()
        {
            InitializeComponent();
        }

        public void ShowProg(int dmaTimeS, double dmaSpeedMB, int dmaCompleted)
        {
            TimeSpan ts = new TimeSpan(0, 0, dmaTimeS);
            pgbDmaTransfer.Value = dmaCompleted;
            lalDmaSpeed.Text = dmaSpeedMB + " MB/s";
            if (ts.Days > 0)
                lalDmaTime.Text = ts.Days + " 天 " + ts.Hours +" 小时 " + ts.Minutes + " 分钟 " + ts.Seconds + " 秒";
            else if (ts.Hours > 0)
                lalDmaTime.Text = ts.Hours + " 小时 " + ts.Minutes + " 分钟 " + ts.Seconds + " 秒";
            else if (ts.Minutes > 0)
                lalDmaTime.Text = ts.Minutes + " 分钟 " + ts.Seconds + " 秒";
            else
                lalDmaTime.Text = ts.Seconds + " 秒";
        }

        public void GetProgInfo(out int progMin,out int progMax,out int progStep)
        {
            progMin = pgbDmaTransfer.Minimum;
            progMax = pgbDmaTransfer.Maximum;
            progStep = pgbDmaTransfer.Step;
        }
    }
}
