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
            this.lblOldpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldpw.Location = new System.Drawing.Point(107, 112);
            this.lblOldpw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOldpw.Name = "lblOldpw";
            this.lblOldpw.Size = new System.Drawing.Size(137, 24);
            this.lblOldpw.TabIndex = 0;
            this.lblOldpw.Text = "Old Password: ";
            this.lblOldpw.Click += new System.EventHandler(this.lblOldpw_Click);
            // 
            // lblResetpw
            // 
            this.lblResetpw.AutoSize = true;
            this.lblResetpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblResetpw.Location = new System.Drawing.Point(171, 36);
            this.lblResetpw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResetpw.Name = "lblResetpw";
            this.lblResetpw.Size = new System.Drawing.Size(311, 46);
            this.lblResetpw.TabIndex = 1;
            this.lblResetpw.Text = "Reset Password";
            this.lblResetpw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNewpw
            // 
            this.lblNewpw.AutoSize = true;
            this.lblNewpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewpw.Location = new System.Drawing.Point(107, 167);
            this.lblNewpw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewpw.Name = "lblNewpw";
            this.lblNewpw.Size = new System.Drawing.Size(141, 24);
            this.lblNewpw.TabIndex = 2;
            this.lblNewpw.Text = "New Password:";
            // 
            // lblCfmpw
            // 
            this.lblCfmpw.AutoSize = true;
            this.lblCfmpw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfmpw.Location = new System.Drawing.Point(107, 220);
            this.lblCfmpw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCfmpw.Name = "lblCfmpw";
            this.lblCfmpw.Size = new System.Drawing.Size(167, 24);
            this.lblCfmpw.TabIndex = 3;
            this.lblCfmpw.Text = "Confirm Password:";
            // 
            // tbOldpw
            // 
            this.tbOldpw.Location = new System.Drawing.Point(291, 114);
            this.tbOldpw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOldpw.Name = "tbOldpw";
            this.tbOldpw.Size = new System.Drawing.Size(206, 22);
            this.tbOldpw.TabIndex = 4;
            // 
            // tbNewpw
            // 
            this.tbNewpw.Location = new System.Drawing.Point(291, 167);
            this.tbNewpw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewpw.Name = "tbNewpw";
            this.tbNewpw.Size = new System.Drawing.Size(206, 22);
            this.tbNewpw.TabIndex = 5;
            // 
            // tbCfmpw
            // 
            this.tbCfmpw.Location = new System.Drawing.Point(291, 220);
            this.tbCfmpw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCfmpw.Name = "tbCfmpw";
            this.tbCfmpw.Size = new System.Drawing.Size(206, 22);
            this.tbCfmpw.TabIndex = 6;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.submitBtn.Location = new System.Drawing.Point(415, 288);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(120, 57);
            this.submitBtn.TabIndex = 7;
            this.submitBtn.Text = "Reset ";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancel.Location = new System.Drawing.Point(111, 288);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 57);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PasswordResetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 375);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.tbCfmpw);
            this.Controls.Add(this.tbNewpw);
            this.Controls.Add(this.tbOldpw);
            this.Controls.Add(this.lblCfmpw);
            this.Controls.Add(this.lblNewpw);
            this.Controls.Add(this.lblResetpw);
            this.Controls.Add(this.lblOldpw);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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