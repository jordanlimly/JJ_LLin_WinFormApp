namespace MainWinFormApp
{
    partial class CustLoginForm
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
            this.lblLoginfrm = new System.Windows.Forms.Label();
            this.lblLoginEmail = new System.Windows.Forms.Label();
            this.lblloginpw = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbLoginEmail = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLoginfrm
            // 
            this.lblLoginfrm.AutoSize = true;
            this.lblLoginfrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginfrm.Location = new System.Drawing.Point(342, 60);
            this.lblLoginfrm.Name = "lblLoginfrm";
            this.lblLoginfrm.Size = new System.Drawing.Size(118, 46);
            this.lblLoginfrm.TabIndex = 0;
            this.lblLoginfrm.Text = "Login";
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEmail.Location = new System.Drawing.Point(231, 163);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(62, 24);
            this.lblLoginEmail.TabIndex = 1;
            this.lblLoginEmail.Text = "Email:";
            // 
            // lblloginpw
            // 
            this.lblloginpw.AutoSize = true;
            this.lblloginpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginpw.Location = new System.Drawing.Point(231, 245);
            this.lblloginpw.Name = "lblloginpw";
            this.lblloginpw.Size = new System.Drawing.Size(97, 24);
            this.lblloginpw.TabIndex = 2;
            this.lblloginpw.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(235, 357);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 35);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // tbLoginEmail
            // 
            this.tbLoginEmail.Location = new System.Drawing.Point(350, 163);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(237, 22);
            this.tbLoginEmail.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 22);
            this.textBox2.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(460, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(137, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // CustLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 496);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbLoginEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblloginpw);
            this.Controls.Add(this.lblLoginEmail);
            this.Controls.Add(this.lblLoginfrm);
            this.Name = "CustLoginForm";
            this.Text = "CustLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoginfrm;
        private System.Windows.Forms.Label lblLoginEmail;
        private System.Windows.Forms.Label lblloginpw;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbLoginEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCancel;
    }
}