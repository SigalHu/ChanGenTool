namespace ChanGenTool
{
    partial class TransferBox
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
            this.pgbDmaTransfer = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lalDmaSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lalDmaTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbDmaTransfer
            // 
            this.pgbDmaTransfer.Location = new System.Drawing.Point(8, 119);
            this.pgbDmaTransfer.Name = "pgbDmaTransfer";
            this.pgbDmaTransfer.Size = new System.Drawing.Size(366, 23);
            this.pgbDmaTransfer.Step = 1;
            this.pgbDmaTransfer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "硬件配置中...";
            // 
            // lalDmaSpeed
            // 
            this.lalDmaSpeed.AutoSize = true;
            this.lalDmaSpeed.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalDmaSpeed.Location = new System.Drawing.Point(113, 83);
            this.lalDmaSpeed.Name = "lalDmaSpeed";
            this.lalDmaSpeed.Size = new System.Drawing.Size(67, 23);
            this.lalDmaSpeed.TabIndex = 4;
            this.lalDmaSpeed.Text = "0 MB/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "剩余时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "配置速度:";
            // 
            // lalDmaTime
            // 
            this.lalDmaTime.AutoSize = true;
            this.lalDmaTime.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalDmaTime.Location = new System.Drawing.Point(113, 48);
            this.lalDmaTime.Name = "lalDmaTime";
            this.lalDmaTime.Size = new System.Drawing.Size(32, 23);
            this.lalDmaTime.TabIndex = 7;
            this.lalDmaTime.Text = "0 s";
            // 
            // TransferBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(377, 160);
            this.ControlBox = false;
            this.Controls.Add(this.lalDmaTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lalDmaSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgbDmaTransfer);
            this.Font = new System.Drawing.Font("STKaiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "提示";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbDmaTransfer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lalDmaSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lalDmaTime;
    }
}