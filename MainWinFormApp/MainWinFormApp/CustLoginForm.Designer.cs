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
            this.tbLoginPw = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCreateAcc = new System.Windows.Forms.Label();
            this.lblHere = new System.Windows.Forms.Label();
            this.lnklblForgetPw = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblLoginfrm
            // 
            this.lblLoginfrm.AutoSize = true;
            this.lblLoginfrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginfrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblLoginfrm.Location = new System.Drawing.Point(253, 42);
            this.lblLoginfrm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginfrm.Name = "lblLoginfrm";
            this.lblLoginfrm.Size = new System.Drawing.Size(96, 37);
            this.lblLoginfrm.TabIndex = 0;
            this.lblLoginfrm.Text = "Login";
            // 
            // lblLoginEmail
            // 
            this.lblLoginEmail.AutoSize = true;
            this.lblLoginEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblLoginEmail.Location = new System.Drawing.Point(168, 132);
            this.lblLoginEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoginEmail.Name = "lblLoginEmail";
            this.lblLoginEmail.Size = new System.Drawing.Size(49, 18);
            this.lblLoginEmail.TabIndex = 1;
            this.lblLoginEmail.Text = "Email:";
            // 
            // lblloginpw
            // 
            this.lblloginpw.AutoSize = true;
            this.lblloginpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblloginpw.Location = new System.Drawing.Point(168, 201);
            this.lblloginpw.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblloginpw.Name = "lblloginpw";
            this.lblloginpw.Size = new System.Drawing.Size(79, 18);
            this.lblloginpw.TabIndex = 2;
            this.lblloginpw.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnLogin.Location = new System.Drawing.Point(171, 317);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 43);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbLoginEmail
            // 
            this.tbLoginEmail.BackColor = System.Drawing.Color.Gray;
            this.tbLoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLoginEmail.Location = new System.Drawing.Point(274, 132);
            this.tbLoginEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoginEmail.Name = "tbLoginEmail";
            this.tbLoginEmail.Size = new System.Drawing.Size(179, 20);
            this.tbLoginEmail.TabIndex = 4;
            // 
            // tbLoginPw
            // 
            this.tbLoginPw.BackColor = System.Drawing.Color.Gray;
            this.tbLoginPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLoginPw.Location = new System.Drawing.Point(274, 202);
            this.tbLoginPw.Margin = new System.Windows.Forms.Padding(2);
            this.tbLoginPw.Name = "tbLoginPw";
            this.tbLoginPw.PasswordChar = '*';
            this.tbLoginPw.Size = new System.Drawing.Size(179, 20);
            this.tbLoginPw.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnCancel.Location = new System.Drawing.Point(349, 317);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCreateAcc
            // 
            this.lblCreateAcc.AutoSize = true;
            this.lblCreateAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblCreateAcc.Location = new System.Drawing.Point(211, 256);
            this.lblCreateAcc.Name = "lblCreateAcc";
            this.lblCreateAcc.Size = new System.Drawing.Size(134, 13);
            this.lblCreateAcc.TabIndex = 7;
            this.lblCreateAcc.Text = "New? Create your account";
            // 
            // lblHere
            // 
            this.lblHere.AutoSize = true;
            this.lblHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblHere.Location = new System.Drawing.Point(346, 256);
            this.lblHere.Name = "lblHere";
            this.lblHere.Size = new System.Drawing.Size(36, 13);
            this.lblHere.TabIndex = 8;
            this.lblHere.Text = "here!";
            this.lblHere.Click += new System.EventHandler(this.lblHere_Click);
            // 
            // lnklblForgetPw
            // 
            this.lnklblForgetPw.AutoSize = true;
            this.lnklblForgetPw.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lnklblForgetPw.Location = new System.Drawing.Point(211, 280);
            this.lnklblForgetPw.Name = "lnklblForgetPw";
            this.lnklblForgetPw.Size = new System.Drawing.Size(92, 13);
            this.lnklblForgetPw.TabIndex = 9;
            this.lnklblForgetPw.TabStop = true;
            this.lnklblForgetPw.Text = "Forget Password?";
            this.lnklblForgetPw.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblForgetPw_LinkClicked);
            // 
            // CustLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(608, 403);
            this.Controls.Add(this.lnklblForgetPw);
            this.Controls.Add(this.lblHere);
            this.Controls.Add(this.lblCreateAcc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbLoginPw);
            this.Controls.Add(this.tbLoginEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblloginpw);
            this.Controls.Add(this.lblLoginEmail);
            this.Controls.Add(this.lblLoginfrm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox tbLoginPw;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCreateAcc;
        private System.Windows.Forms.Label lblHere;
        private System.Windows.Forms.LinkLabel lnklblForgetPw;
    }
}