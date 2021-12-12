namespace MainWinFormApp
{
    partial class RMachineDetails
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
            this.lblGMachineDetails = new System.Windows.Forms.Label();
            this.lblGMachineName = new System.Windows.Forms.Label();
            this.lblGMachineID = new System.Windows.Forms.Label();
            this.lblGMachineUsage = new System.Windows.Forms.Label();
            this.tbGMachineName = new System.Windows.Forms.TextBox();
            this.tbGMachineID = new System.Windows.Forms.TextBox();
            this.tbUsageCount = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGMachineDetails
            // 
            this.lblGMachineDetails.AutoSize = true;
            this.lblGMachineDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMachineDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblGMachineDetails.Location = new System.Drawing.Point(129, 33);
            this.lblGMachineDetails.Name = "lblGMachineDetails";
            this.lblGMachineDetails.Size = new System.Drawing.Size(423, 46);
            this.lblGMachineDetails.TabIndex = 0;
            this.lblGMachineDetails.Text = "Game Machine Details";
            // 
            // lblGMachineName
            // 
            this.lblGMachineName.AutoSize = true;
            this.lblGMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMachineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblGMachineName.Location = new System.Drawing.Point(84, 132);
            this.lblGMachineName.Name = "lblGMachineName";
            this.lblGMachineName.Size = new System.Drawing.Size(200, 24);
            this.lblGMachineName.TabIndex = 1;
            this.lblGMachineName.Text = "Game Machine Name:";
            // 
            // lblGMachineID
            // 
            this.lblGMachineID.AutoSize = true;
            this.lblGMachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMachineID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblGMachineID.Location = new System.Drawing.Point(84, 194);
            this.lblGMachineID.Name = "lblGMachineID";
            this.lblGMachineID.Size = new System.Drawing.Size(166, 24);
            this.lblGMachineID.TabIndex = 2;
            this.lblGMachineID.Text = "Game Machine ID:";
            // 
            // lblGMachineUsage
            // 
            this.lblGMachineUsage.AutoSize = true;
            this.lblGMachineUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMachineUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblGMachineUsage.Location = new System.Drawing.Point(84, 255);
            this.lblGMachineUsage.Name = "lblGMachineUsage";
            this.lblGMachineUsage.Size = new System.Drawing.Size(124, 24);
            this.lblGMachineUsage.TabIndex = 3;
            this.lblGMachineUsage.Text = "Usage Count:";
            // 
            // tbGMachineName
            // 
            this.tbGMachineName.BackColor = System.Drawing.Color.Gray;
            this.tbGMachineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGMachineName.Location = new System.Drawing.Point(316, 134);
            this.tbGMachineName.Name = "tbGMachineName";
            this.tbGMachineName.Size = new System.Drawing.Size(220, 22);
            this.tbGMachineName.TabIndex = 4;
            // 
            // tbGMachineID
            // 
            this.tbGMachineID.BackColor = System.Drawing.Color.Gray;
            this.tbGMachineID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGMachineID.Location = new System.Drawing.Point(316, 197);
            this.tbGMachineID.Name = "tbGMachineID";
            this.tbGMachineID.ReadOnly = true;
            this.tbGMachineID.Size = new System.Drawing.Size(107, 22);
            this.tbGMachineID.TabIndex = 5;
            // 
            // tbUsageCount
            // 
            this.tbUsageCount.BackColor = System.Drawing.Color.Gray;
            this.tbUsageCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsageCount.Location = new System.Drawing.Point(316, 258);
            this.tbUsageCount.Name = "tbUsageCount";
            this.tbUsageCount.ReadOnly = true;
            this.tbUsageCount.Size = new System.Drawing.Size(107, 22);
            this.tbUsageCount.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnExit.Location = new System.Drawing.Point(137, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 58);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnRetrieve.Location = new System.Drawing.Point(395, 320);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(157, 58);
            this.btnRetrieve.TabIndex = 8;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // RMachineDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(688, 418);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbUsageCount);
            this.Controls.Add(this.tbGMachineID);
            this.Controls.Add(this.tbGMachineName);
            this.Controls.Add(this.lblGMachineUsage);
            this.Controls.Add(this.lblGMachineID);
            this.Controls.Add(this.lblGMachineName);
            this.Controls.Add(this.lblGMachineDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RMachineDetails";
            this.Text = "RMachineDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGMachineDetails;
        private System.Windows.Forms.Label lblGMachineName;
        private System.Windows.Forms.Label lblGMachineID;
        private System.Windows.Forms.Label lblGMachineUsage;
        private System.Windows.Forms.TextBox tbGMachineName;
        private System.Windows.Forms.TextBox tbGMachineID;
        private System.Windows.Forms.TextBox tbUsageCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRetrieve;
    }
}