namespace ChanGenTool
{
    partial class DopplerBox
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
            this.btnGeneCnl = new System.Windows.Forms.Button();
            this.btnGeneOk = new System.Windows.Forms.Button();
            this.lalGeneDopplerUnit = new System.Windows.Forms.Label();
            this.txtGeneDoppler = new System.Windows.Forms.TextBox();
            this.lalGeneDoppler = new System.Windows.Forms.Label();
            this.errorShow = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGeneCnl
            // 
            this.btnGeneCnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGeneCnl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeneCnl.Location = new System.Drawing.Point(216, 72);
            this.btnGeneCnl.Name = "btnGeneCnl";
            this.btnGeneCnl.Size = new System.Drawing.Size(75, 32);
            this.btnGeneCnl.TabIndex = 15;
            this.btnGeneCnl.Text = "取消";
            this.btnGeneCnl.UseVisualStyleBackColor = false;
            // 
            // btnGeneOk
            // 
            this.btnGeneOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGeneOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGeneOk.Location = new System.Drawing.Point(128, 72);
            this.btnGeneOk.Name = "btnGeneOk";
            this.btnGeneOk.Size = new System.Drawing.Size(75, 32);
            this.btnGeneOk.TabIndex = 14;
            this.btnGeneOk.Text = "确定";
            this.btnGeneOk.UseVisualStyleBackColor = false;
            // 
            // lalGeneDopplerUnit
            // 
            this.lalGeneDopplerUnit.AutoSize = true;
            this.lalGeneDopplerUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalGeneDopplerUnit.Location = new System.Drawing.Point(259, 25);
            this.lalGeneDopplerUnit.Name = "lalGeneDopplerUnit";
            this.lalGeneDopplerUnit.Size = new System.Drawing.Size(30, 23);
            this.lalGeneDopplerUnit.TabIndex = 13;
            this.lalGeneDopplerUnit.Text = "Hz";
            // 
            // txtGeneDoppler
            // 
            this.txtGeneDoppler.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtGeneDoppler.Location = new System.Drawing.Point(157, 20);
            this.txtGeneDoppler.Name = "txtGeneDoppler";
            this.txtGeneDoppler.Size = new System.Drawing.Size(100, 29);
            this.txtGeneDoppler.TabIndex = 12;
            this.txtGeneDoppler.Text = "0";
            this.txtGeneDoppler.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGeneDoppler.TextChanged += new System.EventHandler(this.txtInputLimit_TextChanged);
            this.txtGeneDoppler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGeneDoppler_KeyPress);
            // 
            // lalGeneDoppler
            // 
            this.lalGeneDoppler.AutoSize = true;
            this.lalGeneDoppler.Location = new System.Drawing.Point(13, 25);
            this.lalGeneDoppler.Name = "lalGeneDoppler";
            this.lalGeneDoppler.Size = new System.Drawing.Size(110, 21);
            this.lalGeneDoppler.TabIndex = 11;
            this.lalGeneDoppler.Text = "多普勒频率";
            // 
            // errorShow
            // 
            this.errorShow.BlinkRate = 0;
            this.errorShow.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorShow.ContainerControl = this;
            this.errorShow.RightToLeft = true;
            // 
            // DopplerBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(311, 120);
            this.Controls.Add(this.btnGeneCnl);
            this.Controls.Add(this.btnGeneOk);
            this.Controls.Add(this.lalGeneDopplerUnit);
            this.Controls.Add(this.txtGeneDoppler);
            this.Controls.Add(this.lalGeneDoppler);
            this.Font = new System.Drawing.Font("STKaiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DopplerBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "纯多普勒设置";
            ((System.ComponentModel.ISupportInitialize)(this.errorShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneCnl;
        private System.Windows.Forms.Button btnGeneOk;
        private System.Windows.Forms.Label lalGeneDopplerUnit;
        private System.Windows.Forms.TextBox txtGeneDoppler;
        private System.Windows.Forms.Label lalGeneDoppler;
        private System.Windows.Forms.ErrorProvider errorShow;
    }
}