namespace MainWinFormApp
{
    partial class frmCreateuserAcc
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
            this.lblCreateUserAcc = new System.Windows.Forms.Label();
            this.lblFullname = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblCardID = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbCfmPassword = new System.Windows.Forms.TextBox();
            this.tbCardID = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSQ2 = new System.Windows.Forms.Label();
            this.lblSQ1 = new System.Windows.Forms.Label();
            this.combSQ1 = new System.Windows.Forms.ComboBox();
            this.tbSQ1 = new System.Windows.Forms.TextBox();
            this.tbSQ2 = new System.Windows.Forms.TextBox();
            this.combSQ2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCreateUserAcc
            // 
            this.lblCreateUserAcc.AutoSize = true;
            this.lblCreateUserAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateUserAcc.Location = new System.Drawing.Point(326, 33);
            this.lblCreateUserAcc.Name = "lblCreateUserAcc";
            this.lblCreateUserAcc.Size = new System.Drawing.Size(297, 46);
            this.lblCreateUserAcc.TabIndex = 0;
            this.lblCreateUserAcc.Text = "Create Account";
            this.lblCreateUserAcc.Click += new System.EventHandler(this.lblCreateUserAcc_Click);
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Location = new System.Drawing.Point(216, 122);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(107, 24);
            this.lblFullname.TabIndex = 1;
            this.lblFullname.Text = "Full Name: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(216, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 24);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(216, 215);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 24);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password: ";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(216, 260);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(172, 24);
            this.lblConfirmPassword.TabIndex = 4;
            this.lblConfirmPassword.Text = "Confirm Password: ";
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardID.Location = new System.Drawing.Point(216, 313);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(82, 24);
            this.lblCardID.TabIndex = 5;
            this.lblCardID.Text = "Card ID: ";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(421, 124);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(290, 22);
            this.tbFullName.TabIndex = 6;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(421, 166);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(290, 22);
            this.tbEmail.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(421, 217);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(290, 22);
            this.tbPassword.TabIndex = 8;
            // 
            // tbCfmPassword
            // 
            this.tbCfmPassword.Location = new System.Drawing.Point(421, 262);
            this.tbCfmPassword.Name = "tbCfmPassword";
            this.tbCfmPassword.Size = new System.Drawing.Size(290, 22);
            this.tbCfmPassword.TabIndex = 9;
            // 
            // tbCardID
            // 
            this.tbCardID.Location = new System.Drawing.Point(421, 315);
            this.tbCardID.Name = "tbCardID";
            this.tbCardID.Size = new System.Drawing.Size(290, 22);
            this.tbCardID.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(194, 571);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(160, 49);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(642, 571);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 49);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblSQ2
            // 
            this.lblSQ2.AutoSize = true;
            this.lblSQ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQ2.Location = new System.Drawing.Point(216, 484);
            this.lblSQ2.Name = "lblSQ2";
            this.lblSQ2.Size = new System.Drawing.Size(183, 24);
            this.lblSQ2.TabIndex = 13;
            this.lblSQ2.Text = "Security Question 2: ";
            // 
            // lblSQ1
            // 
            this.lblSQ1.AutoSize = true;
            this.lblSQ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSQ1.Location = new System.Drawing.Point(216, 394);
            this.lblSQ1.Name = "lblSQ1";
            this.lblSQ1.Size = new System.Drawing.Size(183, 24);
            this.lblSQ1.TabIndex = 14;
            this.lblSQ1.Text = "Security Question 1: ";
            // 
            // combSQ1
            // 
            this.combSQ1.FormattingEnabled = true;
            this.combSQ1.Location = new System.Drawing.Point(421, 396);
            this.combSQ1.Name = "combSQ1";
            this.combSQ1.Size = new System.Drawing.Size(290, 24);
            this.combSQ1.TabIndex = 15;
            // 
            // tbSQ1
            // 
            this.tbSQ1.Location = new System.Drawing.Point(421, 437);
            this.tbSQ1.Name = "tbSQ1";
            this.tbSQ1.Size = new System.Drawing.Size(290, 22);
            this.tbSQ1.TabIndex = 16;
            // 
            // tbSQ2
            // 
            this.tbSQ2.Location = new System.Drawing.Point(421, 527);
            this.tbSQ2.Name = "tbSQ2";
            this.tbSQ2.Size = new System.Drawing.Size(290, 22);
            this.tbSQ2.TabIndex = 18;
            // 
            // combSQ2
            // 
            this.combSQ2.FormattingEnabled = true;
            this.combSQ2.Location = new System.Drawing.Point(421, 486);
            this.combSQ2.Name = "combSQ2";
            this.combSQ2.Size = new System.Drawing.Size(290, 24);
            this.combSQ2.TabIndex = 17;
            // 
            // frmCreateuserAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 713);
            this.Controls.Add(this.tbSQ2);
            this.Controls.Add(this.combSQ2);
            this.Controls.Add(this.tbSQ1);
            this.Controls.Add(this.combSQ1);
            this.Controls.Add(this.lblSQ1);
            this.Controls.Add(this.lblSQ2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbCardID);
            this.Controls.Add(this.tbCfmPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbFullName);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullname);
            this.Controls.Add(this.lblCreateUserAcc);
            this.Name = "frmCreateuserAcc";
            this.Text = "CreateUserAccForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateUserAcc;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbCfmPassword;
        private System.Windows.Forms.TextBox tbCardID;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblSQ2;
        private System.Windows.Forms.Label lblSQ1;
        private System.Windows.Forms.ComboBox combSQ1;
        private System.Windows.Forms.TextBox tbSQ1;
        private System.Windows.Forms.TextBox tbSQ2;
        private System.Windows.Forms.ComboBox combSQ2;
    }
}