namespace ChanGenTool
{
    partial class ConfigBox
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
            this.lalChanCfg = new System.Windows.Forms.Label();
            this.btnChanCfg = new System.Windows.Forms.Button();
            this.txtChanCfg = new System.Windows.Forms.TextBox();
            this.btnCfgCnl = new System.Windows.Forms.Button();
            this.btnCfgOk = new System.Windows.Forms.Button();
            this.errorShow = new System.Windows.Forms.ErrorProvider(this.components);
            this.TipShow = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lalChanCfg
            // 
            this.lalChanCfg.AutoSize = true;
            this.lalChanCfg.Font = new System.Drawing.Font("STKaiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.lalChanCfg.ForeColor = System.Drawing.Color.Black;
            this.lalChanCfg.Location = new System.Drawing.Point(9, 26);
            this.lalChanCfg.Name = "lalChanCfg";
            this.lalChanCfg.Size = new System.Drawing.Size(130, 21);
            this.lalChanCfg.TabIndex = 59;
            this.lalChanCfg.Text = "信道衰落文件";
            // 
            // btnChanCfg
            // 
            this.btnChanCfg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnChanCfg.Font = new System.Drawing.Font("Calibri", 10.8F);
            this.btnChanCfg.ForeColor = System.Drawing.Color.Black;
            this.btnChanCfg.Location = new System.Drawing.Point(427, 18);
            this.btnChanCfg.Name = "btnChanCfg";
            this.btnChanCfg.Size = new System.Drawing.Size(37, 37);
            this.btnChanCfg.TabIndex = 61;
            this.btnChanCfg.TabStop = false;
            this.btnChanCfg.Text = "...";
            this.btnChanCfg.UseVisualStyleBackColor = false;
            this.btnChanCfg.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtChanCfg
            // 
            this.txtChanCfg.AllowDrop = true;
            this.errorShow.SetError(this.txtChanCfg, "文件不存在");
            this.txtChanCfg.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtChanCfg.Location = new System.Drawing.Point(152, 22);
            this.txtChanCfg.Name = "txtChanCfg";
            this.txtChanCfg.Size = new System.Drawing.Size(269, 29);
            this.txtChanCfg.TabIndex = 60;
            this.txtChanCfg.TabStop = false;
            this.txtChanCfg.TextChanged += new System.EventHandler(this.txtFileExist_TextChanged);
            this.txtChanCfg.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtChanCfg_DragDrop);
            this.txtChanCfg.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtChanCfg_DragEnter);
            // 
            // btnCfgCnl
            // 
            this.btnCfgCnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCfgCnl.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCfgCnl.Location = new System.Drawing.Point(389, 71);
            this.btnCfgCnl.Name = "btnCfgCnl";
            this.btnCfgCnl.Size = new System.Drawing.Size(75, 32);
            this.btnCfgCnl.TabIndex = 63;
            this.btnCfgCnl.Text = "取消";
            this.btnCfgCnl.UseVisualStyleBackColor = false;
            // 
            // btnCfgOk
            // 
            this.btnCfgOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCfgOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCfgOk.Enabled = false;
            this.btnCfgOk.Location = new System.Drawing.Point(301, 71);
            this.btnCfgOk.Name = "btnCfgOk";
            this.btnCfgOk.Size = new System.Drawing.Size(75, 32);
            this.btnCfgOk.TabIndex = 62;
            this.btnCfgOk.Text = "确定";
            this.btnCfgOk.UseVisualStyleBackColor = false;
            // 
            // errorShow
            // 
            this.errorShow.BlinkRate = 0;
            this.errorShow.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorShow.ContainerControl = this;
            this.errorShow.RightToLeft = true;
            // 
            // TipShow
            // 
            this.TipShow.ShowAlways = true;
            // 
            // ConfigBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(481, 113);
            this.Controls.Add(this.btnCfgCnl);
            this.Controls.Add(this.btnCfgOk);
            this.Controls.Add(this.lalChanCfg);
            this.Controls.Add(this.btnChanCfg);
            this.Controls.Add(this.txtChanCfg);
            this.Font = new System.Drawing.Font("STKaiti", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "硬件配置";
            ((System.ComponentModel.ISupportInitialize)(this.errorShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lalChanCfg;
        private System.Windows.Forms.Button btnChanCfg;
        private System.Windows.Forms.TextBox txtChanCfg;
        private System.Windows.Forms.Button btnCfgCnl;
        private System.Windows.Forms.Button btnCfgOk;
        private System.Windows.Forms.ErrorProvider errorShow;
        private System.Windows.Forms.ToolTip TipShow;
    }
}