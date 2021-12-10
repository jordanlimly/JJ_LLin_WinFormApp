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
            this.lblForgetpw.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblForgetpw.Location = new System.Drawing.Point(125, 38);
            this.lblForgetpw.Name = "lblForgetpw";
            this.lblForgetpw.Size = new System.Drawing.Size(250, 36);
            this.lblForgetpw.TabIndex = 0;
            this.lblForgetpw.Text = "Forget Password";
            this.lblForgetpw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblForgetpw.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNewpw
            // 
            this.lblNewpw.AutoSize = true;
            this.lblNewpw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblNewpw.Location = new System.Drawing.Point(96, 111);
            this.lblNewpw.Name = "lblNewpw";
            this.lblNewpw.Size = new System.Drawing.Size(117, 17);
            this.lblNewpw.TabIndex = 1;
            this.lblNewpw.Text = "New Password:";
            // 
            // lblcfmpw
            // 
            this.lblcfmpw.AutoSize = true;
            this.lblcfmpw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblcfmpw.Location = new System.Drawing.Point(96, 156);
            this.lblcfmpw.Name = "lblcfmpw";
            this.lblcfmpw.Size = new System.Drawing.Size(145, 17);
            this.lblcfmpw.TabIndex = 2;
            this.lblcfmpw.Text = "Confirm Password:";
            // 
            // tbNewpw
            // 
            this.tbNewpw.Location = new System.Drawing.Point(258, 108);
            this.tbNewpw.Name = "tbNewpw";
            this.tbNewpw.Size = new System.Drawing.Size(152, 20);
            this.tbNewpw.TabIndex = 3;
            // 
            // tbCfmpw
            // 
            this.tbCfmpw.Location = new System.Drawing.Point(258, 153);
            this.tbCfmpw.Name = "tbCfmpw";
            this.tbCfmpw.Size = new System.Drawing.Size(152, 20);
            this.tbCfmpw.TabIndex = 4;
            // 
            // btnsubmit
            // 
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnsubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnsubmit.Location = new System.Drawing.Point(192, 219);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(91, 41);
            this.btnsubmit.TabIndex = 5;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            // 
            // frmforgetpw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(492, 311);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.tbCfmpw);
            this.Controls.Add(this.tbNewpw);
            this.Controls.Add(this.lblcfmpw);
            this.Controls.Add(this.lblNewpw);
            this.Controls.Add(this.lblForgetpw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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

