namespace ChanGenTool
{
    partial class RiceBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RiceBox));
            this.lalGeneRiceK = new System.Windows.Forms.Label();
            this.lalGeneRiceAOA = new System.Windows.Forms.Label();
            this.txtGeneRiceK = new System.Windows.Forms.TextBox();
            this.txtGeneRiceAOA = new System.Windows.Forms.TextBox();
            this.lalGeneRiceKUnit = new System.Windows.Forms.Label();
            this.lalGeneRiceAOAUnit = new System.Windows.Forms.Label();
            this.btnGeneOk = new System.Windows.Forms.Button();
            this.btnGeneCnl = new System.Windows.Forms.Button();
            this.errorShow = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lalGeneRiceK
            // 
            this.lalGeneRiceK.AutoSize = true;
            this.lalGeneRiceK.Location = new System.Drawing.Point(21, 22);
            this.lalGeneRiceK.Name = "lalGeneRiceK";
            this.lalGeneRiceK.Size = new System.Drawing.Size(80, 21);
            this.lalGeneRiceK.TabIndex = 0;
            this.lalGeneRiceK.Text = "功率比k";
            // 
            // lalGeneRiceAOA
            // 
            this.lalGeneRiceAOA.AutoSize = true;
            this.lalGeneRiceAOA.Location = new System.Drawing.Point(21, 64);
            this.lalGeneRiceAOA.Name = "lalGeneRiceAOA";
            this.lalGeneRiceAOA.Size = new System.Drawing.Size(130, 21);
            this.lalGeneRiceAOA.TabIndex = 1;
            this.lalGeneRiceAOA.Text = "直射径入射角";
            // 
            // txtGeneRiceK
            // 
            this.txtGeneRiceK.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtGeneRiceK.Location = new System.Drawing.Point(165, 17);
            this.txtGeneRiceK.Name = "txtGeneRiceK";
            this.txtGeneRiceK.Size = new System.Drawing.Size(100, 29);
            this.txtGeneRiceK.TabIndex = 2;
            this.txtGeneRiceK.Text = "5";
            this.txtGeneRiceK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGeneRiceK.TextChanged += new System.EventHandler(this.txtInputLimit_TextChanged);
            this.txtGeneRiceK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGeneRiceK_KeyPress);
            // 
            // txtGeneRiceAOA
            // 
            this.txtGeneRiceAOA.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtGeneRiceAOA.Location = new System.Drawing.Point(165, 59);
            this.txtGeneRiceAOA.Name = "txtGeneRiceAOA";
            this.txtGeneRiceAOA.Size = new System.Drawing.Size(100, 29);
            this.txtGeneRiceAOA.TabIndex = 3;
            this.txtGeneRiceAOA.Text = "1";
            this.txtGeneRiceAOA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGeneRiceAOA.TextChanged += new System.EventHandler(this.txtInputLimit_TextChanged);
            this.txtGeneRiceAOA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGeneAOA_KeyPress);
            // 
            // lalGeneRiceKUnit
            // 
            this.lalGeneRiceKUnit.AutoSize = true;
            this.lalGeneRiceKUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalGeneRiceKUnit.Location = new System.Drawing.Point(267, 22);
            this.lalGeneRiceKUnit.Name = "lalGeneRiceKUnit";
            this.lalGeneRiceKUnit.Size = new System.Drawing.Size(31, 23);
            this.lalGeneRiceKUnit.TabIndex = 4;
            this.lalGeneRiceKUnit.Text = "dB";
            // 
            // lalGeneRiceAOAUnit
            // 
            this.lalGeneRiceAOAUnit.AutoSize = true;
            this.lalGeneRiceAOAUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalGeneRiceAOAUnit.Location = new System.Drawing.Point(267, 64);
            this.lalGeneRiceAOAUnit.Name = "lalGeneRiceAOAUnit";
            this.lalGeneRiceAOAUnit.Size = new System.Drawing.Size(39, 23);
            this.lalGeneRiceAOAUnit.TabIndex = 5;
            this.lalGeneRiceAOAUnit.Text = "deg";
            // 
            // btnGeneOk
            // 
            this.btnGeneOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGeneOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGeneOk.Location = new System.Drawing.Point(136, 111);
            this.btnGeneOk.Name = "btnGeneOk";
            this.btnGeneOk.Size = new System.Drawing.Size(75, 32);
            this.btnGeneOk.TabIndex = 9;
            this.btnGeneOk.Text = "确定";
            this.btnGeneOk.UseVisualStyleBackColor = false;
            // 
            // btnGeneCnl
            // 
            this.btnGeneCnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnGeneCnl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeneCnl.Location = new System.Drawing.Point(224, 111);
            this.btnGeneCnl.Name = "btnGeneCnl";
            this.btnGeneCnl.Size = new System.Drawing.Size(75, 32);
            this.btnGeneCnl.TabIndex = 10;
            this.btnGeneCnl.Text = "取消";
            this.btnGeneCnl.UseVisualStyleBackColor = false;
            // 
            // errorShow
            // 
            this.errorShow.BlinkRate = 0;
            this.errorShow.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorShow.ContainerControl = this;
            this.errorShow.RightToLeft = true;
            // 
            // RiceBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(311, 156);
            this.Controls.Add(this.btnGeneCnl);
            this.Controls.Add(this.btnGeneOk);
            this.Controls.Add(this.lalGeneRiceAOAUnit);
            this.Controls.Add(this.lalGeneRiceKUnit);
            this.Controls.Add(this.txtGeneRiceAOA);
            this.Controls.Add(this.txtGeneRiceK);
            this.Controls.Add(this.lalGeneRiceAOA);
            this.Controls.Add(this.lalGeneRiceK);
            this.Font = new System.Drawing.Font("STKaiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RiceBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "莱斯衰落设置";
            ((System.ComponentModel.ISupportInitialize)(this.errorShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalGeneRiceK;
        private System.Windows.Forms.Label lalGeneRiceAOA;
        private System.Windows.Forms.TextBox txtGeneRiceK;
        private System.Windows.Forms.TextBox txtGeneRiceAOA;
        private System.Windows.Forms.Label lalGeneRiceKUnit;
        private System.Windows.Forms.Label lalGeneRiceAOAUnit;
        private System.Windows.Forms.Button btnGeneOk;
        private System.Windows.Forms.Button btnGeneCnl;
        private System.Windows.Forms.ErrorProvider errorShow;
    }
}