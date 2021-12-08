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
            this.btnCfmLogout = new System.Windows.Forms.Button();
            this.btnCancelLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(80, 63);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(371, 27);
            this.lblLogout.TabIndex = 0;
            this.lblLogout.Text = "Are you sure you want to log out?";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCfmLogout
            // 
            this.btnCfmLogout.FlatAppearance.BorderSize = 0;
            this.btnCfmLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCfmLogout.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCfmLogout.Location = new System.Drawing.Point(282, 154);
            this.btnCfmLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnCfmLogout.Name = "btnCfmLogout";
            this.btnCfmLogout.Size = new System.Drawing.Size(81, 39);
            this.btnCfmLogout.TabIndex = 1;
            this.btnCfmLogout.Text = "Confirm";
            this.btnCfmLogout.UseVisualStyleBackColor = true;
            this.btnCfmLogout.Click += new System.EventHandler(this.btnCfmLogout_Click);
            // 
            // btnCancelLogout
            // 
            this.btnCancelLogout.FlatAppearance.BorderSize = 0;
            this.btnCancelLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelLogout.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelLogout.Location = new System.Drawing.Point(122, 154);
            this.btnCancelLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelLogout.Name = "btnCancelLogout";
            this.btnCancelLogout.Size = new System.Drawing.Size(80, 39);
            this.btnCancelLogout.TabIndex = 2;
            this.btnCancelLogout.Text = "Cancel";
            this.btnCancelLogout.UseVisualStyleBackColor = true;
            this.btnCancelLogout.Click += new System.EventHandler(this.btnCancelLogout_Click);
            // 
            // LogoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(508, 264);
            this.Controls.Add(this.btnCancelLogout);
            this.Controls.Add(this.btnCfmLogout);
            this.Controls.Add(this.lblLogout);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogoutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Button btnCfmLogout;
        private System.Windows.Forms.Button btnCancelLogout;
    }
}