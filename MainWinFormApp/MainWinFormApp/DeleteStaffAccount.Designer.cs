namespace MainWinFormApp
{
    partial class DeleteStaffAccount
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
            this.lblDeleteStaffAcc = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblManagerID = new System.Windows.Forms.Label();
            this.lblManagerPW = new System.Windows.Forms.Label();
            this.tbStaffID = new System.Windows.Forms.TextBox();
            this.tbMID = new System.Windows.Forms.TextBox();
            this.tbMPW = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeleteStaffAcc
            // 
            this.lblDeleteStaffAcc.AutoSize = true;
            this.lblDeleteStaffAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteStaffAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblDeleteStaffAcc.Location = new System.Drawing.Point(168, 45);
            this.lblDeleteStaffAcc.Name = "lblDeleteStaffAcc";
            this.lblDeleteStaffAcc.Size = new System.Drawing.Size(386, 46);
            this.lblDeleteStaffAcc.TabIndex = 0;
            this.lblDeleteStaffAcc.Text = "Delete Staff Account";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblStaffID.Location = new System.Drawing.Point(155, 140);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(71, 24);
            this.lblStaffID.TabIndex = 1;
            this.lblStaffID.Text = "Staff ID:";
            // 
            // lblManagerID
            // 
            this.lblManagerID.AutoSize = true;
            this.lblManagerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblManagerID.Location = new System.Drawing.Point(155, 189);
            this.lblManagerID.Name = "lblManagerID";
            this.lblManagerID.Size = new System.Drawing.Size(112, 24);
            this.lblManagerID.TabIndex = 2;
            this.lblManagerID.Text = "Manager ID:";
            // 
            // lblManagerPW
            // 
            this.lblManagerPW.AutoSize = true;
            this.lblManagerPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblManagerPW.Location = new System.Drawing.Point(155, 239);
            this.lblManagerPW.Name = "lblManagerPW";
            this.lblManagerPW.Size = new System.Drawing.Size(190, 24);
            this.lblManagerPW.TabIndex = 3;
            this.lblManagerPW.Text = "Manager\'s Password:";
            // 
            // tbStaffID
            // 
            this.tbStaffID.BackColor = System.Drawing.Color.Gray;
            this.tbStaffID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStaffID.Location = new System.Drawing.Point(387, 140);
            this.tbStaffID.Name = "tbStaffID";
            this.tbStaffID.Size = new System.Drawing.Size(167, 22);
            this.tbStaffID.TabIndex = 4;
            // 
            // tbMID
            // 
            this.tbMID.BackColor = System.Drawing.Color.Gray;
            this.tbMID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMID.Location = new System.Drawing.Point(387, 191);
            this.tbMID.Name = "tbMID";
            this.tbMID.Size = new System.Drawing.Size(167, 22);
            this.tbMID.TabIndex = 5;
            // 
            // tbMPW
            // 
            this.tbMPW.BackColor = System.Drawing.Color.Gray;
            this.tbMPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMPW.Location = new System.Drawing.Point(387, 241);
            this.tbMPW.Name = "tbMPW";
            this.tbMPW.PasswordChar = '*';
            this.tbMPW.Size = new System.Drawing.Size(167, 22);
            this.tbMPW.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnCancel.Location = new System.Drawing.Point(159, 302);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 71);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnDelete.Location = new System.Drawing.Point(390, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 71);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteStaffAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(737, 401);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbMPW);
            this.Controls.Add(this.tbMID);
            this.Controls.Add(this.tbStaffID);
            this.Controls.Add(this.lblManagerPW);
            this.Controls.Add(this.lblManagerID);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lblDeleteStaffAcc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteStaffAccount";
            this.Text = "DeleteStaffAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteStaffAcc;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblManagerID;
        private System.Windows.Forms.Label lblManagerPW;
        private System.Windows.Forms.TextBox tbStaffID;
        private System.Windows.Forms.TextBox tbMID;
        private System.Windows.Forms.TextBox tbMPW;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}