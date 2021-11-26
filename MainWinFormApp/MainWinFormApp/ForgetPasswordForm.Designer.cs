namespace MainWinFormApp
{
    partial class frmforgetpw
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
            this.lblForgetpw = new System.Windows.Forms.Label();
            this.lblNewpw = new System.Windows.Forms.Label();
            this.lblcfmpw = new System.Windows.Forms.Label();
            this.tbNewpw = new System.Windows.Forms.TextBox();
            this.tbCfmpw = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForgetpw
            // 
            this.lblForgetpw.AutoSize = true;
            this.lblForgetpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblForgetpw.Location = new System.Drawing.Point(167, 47);
            this.lblForgetpw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForgetpw.Name = "lblForgetpw";
            this.lblForgetpw.Size = new System.Drawing.Size(322, 46);
            this.lblForgetpw.TabIndex = 0;
            this.lblForgetpw.Text = "Forget Password";
            this.lblForgetpw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblForgetpw.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNewpw
            // 
            this.lblNewpw.AutoSize = true;
            this.lblNewpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewpw.Location = new System.Drawing.Point(128, 137);
            this.lblNewpw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewpw.Name = "lblNewpw";
            this.lblNewpw.Size = new System.Drawing.Size(141, 24);
            this.lblNewpw.TabIndex = 1;
            this.lblNewpw.Text = "New Password:";
            // 
            // lblcfmpw
            // 
            this.lblcfmpw.AutoSize = true;
            this.lblcfmpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmpw.Location = new System.Drawing.Point(128, 192);
            this.lblcfmpw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcfmpw.Name = "lblcfmpw";
            this.lblcfmpw.Size = new System.Drawing.Size(167, 24);
            this.lblcfmpw.TabIndex = 2;
            this.lblcfmpw.Text = "Confirm Password:";
            // 
            // tbNewpw
            // 
            this.tbNewpw.Location = new System.Drawing.Point(308, 139);
            this.tbNewpw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewpw.Name = "tbNewpw";
            this.tbNewpw.Size = new System.Drawing.Size(201, 22);
            this.tbNewpw.TabIndex = 3;
            // 
            // tbCfmpw
            // 
            this.tbCfmpw.Location = new System.Drawing.Point(308, 194);
            this.tbCfmpw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCfmpw.Name = "tbCfmpw";
            this.tbCfmpw.Size = new System.Drawing.Size(201, 22);
            this.tbCfmpw.TabIndex = 4;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnsubmit.Location = new System.Drawing.Point(256, 270);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(121, 51);
            this.btnsubmit.TabIndex = 5;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // frmforgetpw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 383);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.tbCfmpw);
            this.Controls.Add(this.tbNewpw);
            this.Controls.Add(this.lblcfmpw);
            this.Controls.Add(this.lblNewpw);
            this.Controls.Add(this.lblForgetpw);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmforgetpw";
            this.Text = "ForgetPasswordForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgetpw;
        private System.Windows.Forms.Label lblNewpw;
        private System.Windows.Forms.Label lblcfmpw;
        private System.Windows.Forms.TextBox tbNewpw;
        private System.Windows.Forms.TextBox tbCfmpw;
        private System.Windows.Forms.Button btnsubmit;
    }
}

