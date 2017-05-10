namespace ChanGenTool
{
    partial class RefBox
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
            this.txtAeroDielectric = new System.Windows.Forms.TextBox();
            this.lalAeroDielectric = new System.Windows.Forms.Label();
            this.txtAeroAngSp = new System.Windows.Forms.TextBox();
            this.lalAeroAngSp = new System.Windows.Forms.Label();
            this.lalAeroAngSpUnit = new System.Windows.Forms.Label();
            this.txtAeroConductivity = new System.Windows.Forms.TextBox();
            this.lalAeroConductivity = new System.Windows.Forms.Label();
            this.btnCnl = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorShow = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAeroDielectric
            // 
            this.txtAeroDielectric.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAeroDielectric.Location = new System.Drawing.Point(129, 23);
            this.txtAeroDielectric.Name = "txtAeroDielectric";
            this.txtAeroDielectric.Size = new System.Drawing.Size(107, 29);
            this.txtAeroDielectric.TabIndex = 23;
            this.txtAeroDielectric.Text = "15";
            this.txtAeroDielectric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAeroDielectric.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtAeroDielectric.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputUFloat_KeyPress);
            // 
            // lalAeroDielectric
            // 
            this.lalAeroDielectric.AutoSize = true;
            this.lalAeroDielectric.ForeColor = System.Drawing.Color.Black;
            this.lalAeroDielectric.Location = new System.Drawing.Point(22, 28);
            this.lalAeroDielectric.Name = "lalAeroDielectric";
            this.lalAeroDielectric.Size = new System.Drawing.Size(90, 21);
            this.lalAeroDielectric.TabIndex = 24;
            this.lalAeroDielectric.Text = "介电常数";
            // 
            // txtAeroAngSp
            // 
            this.txtAeroAngSp.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAeroAngSp.Location = new System.Drawing.Point(129, 125);
            this.txtAeroAngSp.Name = "txtAeroAngSp";
            this.txtAeroAngSp.Size = new System.Drawing.Size(92, 29);
            this.txtAeroAngSp.TabIndex = 73;
            this.txtAeroAngSp.Text = "1";
            this.txtAeroAngSp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAeroAngSp.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtAeroAngSp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputUFloat_KeyPress);
            // 
            // lalAeroAngSp
            // 
            this.lalAeroAngSp.AutoSize = true;
            this.lalAeroAngSp.BackColor = System.Drawing.Color.Transparent;
            this.lalAeroAngSp.Font = new System.Drawing.Font("STKaiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalAeroAngSp.ForeColor = System.Drawing.Color.Black;
            this.lalAeroAngSp.Location = new System.Drawing.Point(22, 130);
            this.lalAeroAngSp.Name = "lalAeroAngSp";
            this.lalAeroAngSp.Size = new System.Drawing.Size(90, 21);
            this.lalAeroAngSp.TabIndex = 75;
            this.lalAeroAngSp.Text = "角度扩展";
            // 
            // lalAeroAngSpUnit
            // 
            this.lalAeroAngSpUnit.AutoSize = true;
            this.lalAeroAngSpUnit.BackColor = System.Drawing.Color.Transparent;
            this.lalAeroAngSpUnit.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalAeroAngSpUnit.ForeColor = System.Drawing.Color.Black;
            this.lalAeroAngSpUnit.Location = new System.Drawing.Point(224, 128);
            this.lalAeroAngSpUnit.Name = "lalAeroAngSpUnit";
            this.lalAeroAngSpUnit.Size = new System.Drawing.Size(39, 23);
            this.lalAeroAngSpUnit.TabIndex = 76;
            this.lalAeroAngSpUnit.Text = "deg";
            // 
            // txtAeroConductivity
            // 
            this.txtAeroConductivity.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtAeroConductivity.Location = new System.Drawing.Point(129, 74);
            this.txtAeroConductivity.Name = "txtAeroConductivity";
            this.txtAeroConductivity.Size = new System.Drawing.Size(107, 29);
            this.txtAeroConductivity.TabIndex = 72;
            this.txtAeroConductivity.Text = "0.08";
            this.txtAeroConductivity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAeroConductivity.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtAeroConductivity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputUFloat_KeyPress);
            // 
            // lalAeroConductivity
            // 
            this.lalAeroConductivity.AutoSize = true;
            this.lalAeroConductivity.ForeColor = System.Drawing.Color.Black;
            this.lalAeroConductivity.Location = new System.Drawing.Point(22, 79);
            this.lalAeroConductivity.Name = "lalAeroConductivity";
            this.lalAeroConductivity.Size = new System.Drawing.Size(70, 21);
            this.lalAeroConductivity.TabIndex = 74;
            this.lalAeroConductivity.Text = "电导率";
            // 
            // btnCnl
            // 
            this.btnCnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCnl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCnl.Location = new System.Drawing.Point(204, 183);
            this.btnCnl.Name = "btnCnl";
            this.btnCnl.Size = new System.Drawing.Size(75, 32);
            this.btnCnl.TabIndex = 78;
            this.btnCnl.Text = "取消";
            this.btnCnl.UseVisualStyleBackColor = false;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(116, 183);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 32);
            this.btnOk.TabIndex = 77;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // errorShow
            // 
            this.errorShow.BlinkRate = 0;
            this.errorShow.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorShow.ContainerControl = this;
            this.errorShow.RightToLeft = true;
            // 
            // RefMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(291, 230);
            this.Controls.Add(this.btnCnl);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtAeroAngSp);
            this.Controls.Add(this.lalAeroAngSp);
            this.Controls.Add(this.lalAeroAngSpUnit);
            this.Controls.Add(this.txtAeroConductivity);
            this.Controls.Add(this.lalAeroConductivity);
            this.Controls.Add(this.txtAeroDielectric);
            this.Controls.Add(this.lalAeroDielectric);
            this.Font = new System.Drawing.Font("STKaiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RefMod";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "地面特性设置";
            ((System.ComponentModel.ISupportInitialize)(this.errorShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAeroDielectric;
        private System.Windows.Forms.Label lalAeroDielectric;
        private System.Windows.Forms.TextBox txtAeroAngSp;
        private System.Windows.Forms.Label lalAeroAngSp;
        private System.Windows.Forms.Label lalAeroAngSpUnit;
        private System.Windows.Forms.TextBox txtAeroConductivity;
        private System.Windows.Forms.Label lalAeroConductivity;
        private System.Windows.Forms.Button btnCnl;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorShow;
    }
}