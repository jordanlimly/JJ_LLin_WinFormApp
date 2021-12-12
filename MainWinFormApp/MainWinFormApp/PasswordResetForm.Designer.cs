namespace MainWinFormApp
{
    partial class PasswordResetForm
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
            this.SuspendLayout();
            // 
            // lblOldpw
            // 
            this.lblOldpw.AutoSize = true;
            this.lblOldpw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldpw.Location = new System.Drawing.Point(80, 91);
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
            this.lblResetpw.Size = new System.Drawing.Size(237, 36);
            this.lblResetpw.TabIndex = 1;
            this.lblResetpw.Text = "Reset Password";
            this.lblResetpw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNewpw
            // 
            this.lblNewpw.AutoSize = true;
            this.lblNewpw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewpw.Location = new System.Drawing.Point(80, 136);
            this.lblNewpw.Name = "lblNewpw";
            this.lblNewpw.Size = new System.Drawing.Size(117, 17);
            this.lblNewpw.TabIndex = 2;
            this.lblNewpw.Text = "New Password:";
            // 
            // lblCfmpw
            // 
            this.lblCfmpw.AutoSize = true;
            this.lblCfmpw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfmpw.Location = new System.Drawing.Point(80, 179);
            this.lblCfmpw.Name = "lblCfmpw";
            this.lblCfmpw.Size = new System.Drawing.Size(145, 17);
            this.lblCfmpw.TabIndex = 3;
            this.lblCfmpw.Text = "Confirm Password:";
            // 
            // tbOldpw
            // 
            this.tbOldpw.BackColor = System.Drawing.Color.Gray;
            this.tbOldpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOldpw.Location = new System.Drawing.Point(241, 88);
            this.tbOldpw.Name = "tbOldpw";
            this.tbOldpw.Size = new System.Drawing.Size(156, 20);
            this.tbOldpw.TabIndex = 4;
            // 
            // tbNewpw
            // 
            this.tbNewpw.BackColor = System.Drawing.Color.Gray;
            this.tbNewpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewpw.Location = new System.Drawing.Point(241, 133);
            this.tbNewpw.Name = "tbNewpw";
            this.tbNewpw.Size = new System.Drawing.Size(156, 20);
            this.tbNewpw.TabIndex = 5;
            // 
            // tbCfmpw
            // 
            this.tbCfmpw.BackColor = System.Drawing.Color.Gray;
            this.tbCfmpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCfmpw.Location = new System.Drawing.Point(241, 176);
            this.tbCfmpw.Name = "tbCfmpw";
            this.tbCfmpw.Size = new System.Drawing.Size(156, 20);
            this.tbCfmpw.TabIndex = 6;
            // 
            // submitBtn
            // 
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(311, 234);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(104, 43);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Reset ";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(83, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PasswordResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 305);
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
    }
}