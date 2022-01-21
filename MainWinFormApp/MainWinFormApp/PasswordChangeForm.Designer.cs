namespace MainWinFormApp
{
    partial class PasswordChangeForm
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
            this.lblOldpw = new System.Windows.Forms.Label();
            this.lblResetpw = new System.Windows.Forms.Label();
            this.lblNewpw = new System.Windows.Forms.Label();
            this.lblCfmpw = new System.Windows.Forms.Label();
            this.tbOldpw = new System.Windows.Forms.TextBox();
            this.tbNewpw = new System.Windows.Forms.TextBox();
            this.tbCfmpw = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOldpw
            // 
            this.lblOldpw.AutoSize = true;
            this.lblOldpw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldpw.Location = new System.Drawing.Point(87, 126);
            this.lblOldpw.Name = "lblOldpw";
            this.lblOldpw.Size = new System.Drawing.Size(116, 17);
            this.lblOldpw.TabIndex = 0;
            this.lblOldpw.Text = "Old Password: ";
            this.lblOldpw.Click += new System.EventHandler(this.lblOldpw_Click);
            // 
            // lblResetpw
            // 
            this.lblResetpw.AutoSize = true;
            this.lblResetpw.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetpw.Location = new System.Drawing.Point(128, 29);
            this.lblResetpw.Name = "lblResetpw";
            this.lblResetpw.Size = new System.Drawing.Size(265, 36);
            this.lblResetpw.TabIndex = 1;
            this.lblResetpw.Text = "Change Password";
            this.lblResetpw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNewpw
            // 
            this.lblNewpw.AutoSize = true;
            this.lblNewpw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewpw.Location = new System.Drawing.Point(86, 171);
            this.lblNewpw.Name = "lblNewpw";
            this.lblNewpw.Size = new System.Drawing.Size(117, 17);
            this.lblNewpw.TabIndex = 2;
            this.lblNewpw.Text = "New Password:";
            // 
            // lblCfmpw
            // 
            this.lblCfmpw.AutoSize = true;
            this.lblCfmpw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfmpw.Location = new System.Drawing.Point(86, 214);
            this.lblCfmpw.Name = "lblCfmpw";
            this.lblCfmpw.Size = new System.Drawing.Size(145, 17);
            this.lblCfmpw.TabIndex = 3;
            this.lblCfmpw.Text = "Confirm Password:";
            // 
            // tbOldpw
            // 
            this.tbOldpw.BackColor = System.Drawing.Color.Gray;
            this.tbOldpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOldpw.Location = new System.Drawing.Point(247, 123);
            this.tbOldpw.Name = "tbOldpw";
            this.tbOldpw.PasswordChar = '*';
            this.tbOldpw.Size = new System.Drawing.Size(156, 20);
            this.tbOldpw.TabIndex = 4;
            // 
            // tbNewpw
            // 
            this.tbNewpw.BackColor = System.Drawing.Color.Gray;
            this.tbNewpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewpw.Location = new System.Drawing.Point(247, 168);
            this.tbNewpw.Name = "tbNewpw";
            this.tbNewpw.PasswordChar = '*';
            this.tbNewpw.Size = new System.Drawing.Size(156, 20);
            this.tbNewpw.TabIndex = 5;
            // 
            // tbCfmpw
            // 
            this.tbCfmpw.BackColor = System.Drawing.Color.Gray;
            this.tbCfmpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCfmpw.Location = new System.Drawing.Point(247, 211);
            this.tbCfmpw.Name = "tbCfmpw";
            this.tbCfmpw.PasswordChar = '*';
            this.tbCfmpw.Size = new System.Drawing.Size(156, 20);
            this.tbCfmpw.TabIndex = 6;
            // 
            // submitBtn
            // 
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(314, 267);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(104, 43);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Change ";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(86, 267);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email: ";
            // 
            // tbEMail
            // 
            this.tbEMail.BackColor = System.Drawing.Color.Gray;
            this.tbEMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEMail.Location = new System.Drawing.Point(247, 85);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(156, 20);
            this.tbEMail.TabIndex = 11;
            // 
            // PasswordResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(490, 346);
            this.Controls.Add(this.tbEMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.tbCfmpw);
            this.Controls.Add(this.tbNewpw);
            this.Controls.Add(this.tbOldpw);
            this.Controls.Add(this.lblCfmpw);
            this.Controls.Add(this.lblNewpw);
            this.Controls.Add(this.lblResetpw);
            this.Controls.Add(this.lblOldpw);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordResetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordResetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOldpw;
        private System.Windows.Forms.Label lblResetpw;
        private System.Windows.Forms.Label lblNewpw;
        private System.Windows.Forms.Label lblCfmpw;
        private System.Windows.Forms.TextBox tbOldpw;
        private System.Windows.Forms.TextBox tbNewpw;
        private System.Windows.Forms.TextBox tbCfmpw;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEMail;
    }
}