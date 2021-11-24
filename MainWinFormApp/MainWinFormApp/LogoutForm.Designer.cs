namespace MainWinFormApp
{
    partial class LogoutForm
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
            this.lblLogout = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCancelLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(107, 78);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(462, 36);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "Are you sure you want to log out?";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(158, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelLogout
            // 
            this.btnCancelLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogout.Location = new System.Drawing.Point(393, 190);
            this.btnCancelLogout.Name = "btnCancelLogout";
            this.btnCancelLogout.Size = new System.Drawing.Size(107, 48);
            this.btnCancelLogout.TabIndex = 2;
            this.btnCancelLogout.Text = "Cancel";
            this.btnCancelLogout.UseVisualStyleBackColor = true;
            // 
            // LogoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 325);
            this.Controls.Add(this.btnCancelLogout);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLogout);
            this.Name = "LogoutForm";
            this.Text = "LogoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelLogout;
    }
}