namespace MainWinFormApp
{
    partial class AddStaffAcc
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
            this.lblAddAcc = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCfmPassword = new System.Windows.Forms.Label();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbCfmPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddAcc = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAddAcc
            // 
            this.lblAddAcc.AutoSize = true;
            this.lblAddAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblAddAcc.Location = new System.Drawing.Point(199, 26);
            this.lblAddAcc.Name = "lblAddAcc";
            this.lblAddAcc.Size = new System.Drawing.Size(342, 46);
            this.lblAddAcc.TabIndex = 0;
            this.lblAddAcc.Text = "Add Staff Account";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblFname.Location = new System.Drawing.Point(150, 103);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(111, 24);
            this.lblFname.TabIndex = 2;
            this.lblFname.Text = "First Name: ";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblLname.Location = new System.Drawing.Point(150, 161);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(109, 24);
            this.lblLname.TabIndex = 3;
            this.lblLname.Text = "Last Name: ";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblStaffID.Location = new System.Drawing.Point(150, 271);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(0, 24);
            this.lblStaffID.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblPassword.Location = new System.Drawing.Point(150, 280);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(102, 24);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password: ";
            // 
            // lblCfmPassword
            // 
            this.lblCfmPassword.AutoSize = true;
            this.lblCfmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblCfmPassword.Location = new System.Drawing.Point(150, 344);
            this.lblCfmPassword.Name = "lblCfmPassword";
            this.lblCfmPassword.Size = new System.Drawing.Size(172, 24);
            this.lblCfmPassword.TabIndex = 6;
            this.lblCfmPassword.Text = "Confirm Password: ";
            // 
            // tbFname
            // 
            this.tbFname.BackColor = System.Drawing.Color.Gray;
            this.tbFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFname.Location = new System.Drawing.Point(371, 105);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(170, 22);
            this.tbFname.TabIndex = 7;
            // 
            // tbLname
            // 
            this.tbLname.BackColor = System.Drawing.Color.Gray;
            this.tbLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLname.Location = new System.Drawing.Point(371, 163);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(170, 22);
            this.tbLname.TabIndex = 8;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.Gray;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Location = new System.Drawing.Point(371, 282);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(170, 22);
            this.tbPassword.TabIndex = 10;
            // 
            // tbCfmPassword
            // 
            this.tbCfmPassword.BackColor = System.Drawing.Color.Gray;
            this.tbCfmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCfmPassword.Location = new System.Drawing.Point(371, 344);
            this.tbCfmPassword.Name = "tbCfmPassword";
            this.tbCfmPassword.PasswordChar = '*';
            this.tbCfmPassword.Size = new System.Drawing.Size(170, 22);
            this.tbCfmPassword.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnCancel.Location = new System.Drawing.Point(154, 422);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 58);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddAcc
            // 
            this.btnAddAcc.BackColor = System.Drawing.Color.Black;
            this.btnAddAcc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnAddAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnAddAcc.Location = new System.Drawing.Point(384, 422);
            this.btnAddAcc.Name = "btnAddAcc";
            this.btnAddAcc.Size = new System.Drawing.Size(157, 58);
            this.btnAddAcc.TabIndex = 13;
            this.btnAddAcc.Text = "Add Account";
            this.btnAddAcc.UseVisualStyleBackColor = false;
            this.btnAddAcc.Click += new System.EventHandler(this.btnAddAcc_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblPosition.Location = new System.Drawing.Point(150, 220);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(122, 24);
            this.lblPosition.TabIndex = 14;
            this.lblPosition.Text = "Job Position: ";
            // 
            // tbPosition
            // 
            this.tbPosition.BackColor = System.Drawing.Color.Gray;
            this.tbPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPosition.Location = new System.Drawing.Point(371, 223);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(170, 22);
            this.tbPosition.TabIndex = 15;
            // 
            // AddStaffAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(708, 545);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnAddAcc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbCfmPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.lblCfmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblAddAcc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStaffAcc";
            this.Text = "AddStaffAcc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddAcc;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCfmPassword;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbCfmPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddAcc;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox tbPosition;
    }
}