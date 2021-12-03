namespace MainWinFormApp
{
    partial class Profile
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
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.lblProfileCredits = new System.Windows.Forms.Label();
            this.lblProfileCuPoints = new System.Windows.Forms.Label();
            this.lblProfileCumPoints = new System.Windows.Forms.Label();
            this.lblProfileMemTier = new System.Windows.Forms.Label();
            this.tbProfileName = new System.Windows.Forms.TextBox();
            this.tbProfileMemTier = new System.Windows.Forms.TextBox();
            this.tbProfileCumPoints = new System.Windows.Forms.TextBox();
            this.tbProfileCuPoints = new System.Windows.Forms.TextBox();
            this.tbProfileCredits = new System.Windows.Forms.TextBox();
            this.tbProfileEmail = new System.Windows.Forms.TextBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.Location = new System.Drawing.Point(167, 100);
            this.lblProfileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(66, 24);
            this.lblProfileName.TabIndex = 0;
            this.lblProfileName.Text = "Name:";
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileEmail.Location = new System.Drawing.Point(167, 148);
            this.lblProfileEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(62, 24);
            this.lblProfileEmail.TabIndex = 1;
            this.lblProfileEmail.Text = "Email:";
            // 
            // lblProfileCredits
            // 
            this.lblProfileCredits.AutoSize = true;
            this.lblProfileCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileCredits.Location = new System.Drawing.Point(167, 210);
            this.lblProfileCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileCredits.Name = "lblProfileCredits";
            this.lblProfileCredits.Size = new System.Drawing.Size(73, 24);
            this.lblProfileCredits.TabIndex = 2;
            this.lblProfileCredits.Text = "Credits:";
            // 
            // lblProfileCuPoints
            // 
            this.lblProfileCuPoints.AutoSize = true;
            this.lblProfileCuPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileCuPoints.Location = new System.Drawing.Point(167, 270);
            this.lblProfileCuPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileCuPoints.Name = "lblProfileCuPoints";
            this.lblProfileCuPoints.Size = new System.Drawing.Size(133, 24);
            this.lblProfileCuPoints.TabIndex = 3;
            this.lblProfileCuPoints.Text = "Current Points:";
            // 
            // lblProfileCumPoints
            // 
            this.lblProfileCumPoints.AutoSize = true;
            this.lblProfileCumPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileCumPoints.Location = new System.Drawing.Point(167, 316);
            this.lblProfileCumPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileCumPoints.Name = "lblProfileCumPoints";
            this.lblProfileCumPoints.Size = new System.Drawing.Size(162, 24);
            this.lblProfileCumPoints.TabIndex = 4;
            this.lblProfileCumPoints.Text = "Cumulated Points:";
            // 
            // lblProfileMemTier
            // 
            this.lblProfileMemTier.AutoSize = true;
            this.lblProfileMemTier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileMemTier.Location = new System.Drawing.Point(167, 362);
            this.lblProfileMemTier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfileMemTier.Name = "lblProfileMemTier";
            this.lblProfileMemTier.Size = new System.Drawing.Size(159, 24);
            this.lblProfileMemTier.TabIndex = 5;
            this.lblProfileMemTier.Text = "Membership Tier:";
            // 
            // tbProfileName
            // 
            this.tbProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfileName.Location = new System.Drawing.Point(379, 100);
            this.tbProfileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProfileName.Name = "tbProfileName";
            this.tbProfileName.ReadOnly = true;
            this.tbProfileName.Size = new System.Drawing.Size(243, 28);
            this.tbProfileName.TabIndex = 6;
            // 
            // tbProfileMemTier
            // 
            this.tbProfileMemTier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfileMemTier.Location = new System.Drawing.Point(379, 362);
            this.tbProfileMemTier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProfileMemTier.Name = "tbProfileMemTier";
            this.tbProfileMemTier.ReadOnly = true;
            this.tbProfileMemTier.Size = new System.Drawing.Size(243, 28);
            this.tbProfileMemTier.TabIndex = 7;
            // 
            // tbProfileCumPoints
            // 
            this.tbProfileCumPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfileCumPoints.Location = new System.Drawing.Point(379, 316);
            this.tbProfileCumPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProfileCumPoints.Name = "tbProfileCumPoints";
            this.tbProfileCumPoints.ReadOnly = true;
            this.tbProfileCumPoints.Size = new System.Drawing.Size(243, 28);
            this.tbProfileCumPoints.TabIndex = 8;
            // 
            // tbProfileCuPoints
            // 
            this.tbProfileCuPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfileCuPoints.Location = new System.Drawing.Point(379, 270);
            this.tbProfileCuPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProfileCuPoints.Name = "tbProfileCuPoints";
            this.tbProfileCuPoints.ReadOnly = true;
            this.tbProfileCuPoints.Size = new System.Drawing.Size(243, 28);
            this.tbProfileCuPoints.TabIndex = 9;
            this.tbProfileCuPoints.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // tbProfileCredits
            // 
            this.tbProfileCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfileCredits.Location = new System.Drawing.Point(379, 210);
            this.tbProfileCredits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProfileCredits.Name = "tbProfileCredits";
            this.tbProfileCredits.ReadOnly = true;
            this.tbProfileCredits.Size = new System.Drawing.Size(243, 28);
            this.tbProfileCredits.TabIndex = 10;
            // 
            // tbProfileEmail
            // 
            this.tbProfileEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProfileEmail.Location = new System.Drawing.Point(379, 148);
            this.tbProfileEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbProfileEmail.Name = "tbProfileEmail";
            this.tbProfileEmail.ReadOnly = true;
            this.tbProfileEmail.Size = new System.Drawing.Size(243, 28);
            this.tbProfileEmail.TabIndex = 11;
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(289, 11);
            this.lblProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(147, 52);
            this.lblProfile.TabIndex = 12;
            this.lblProfile.Text = "Profile";
            this.lblProfile.Click += new System.EventHandler(this.label1_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 421);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.tbProfileEmail);
            this.Controls.Add(this.tbProfileCredits);
            this.Controls.Add(this.tbProfileCuPoints);
            this.Controls.Add(this.tbProfileCumPoints);
            this.Controls.Add(this.tbProfileMemTier);
            this.Controls.Add(this.tbProfileName);
            this.Controls.Add(this.lblProfileMemTier);
            this.Controls.Add(this.lblProfileCumPoints);
            this.Controls.Add(this.lblProfileCuPoints);
            this.Controls.Add(this.lblProfileCredits);
            this.Controls.Add(this.lblProfileEmail);
            this.Controls.Add(this.lblProfileName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Profile";
            this.Text = "Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.Label lblProfileCredits;
        private System.Windows.Forms.Label lblProfileCuPoints;
        private System.Windows.Forms.Label lblProfileCumPoints;
        private System.Windows.Forms.Label lblProfileMemTier;
        private System.Windows.Forms.TextBox tbProfileName;
        private System.Windows.Forms.TextBox tbProfileMemTier;
        private System.Windows.Forms.TextBox tbProfileCumPoints;
        private System.Windows.Forms.TextBox tbProfileCuPoints;
        private System.Windows.Forms.TextBox tbProfileCredits;
        private System.Windows.Forms.TextBox tbProfileEmail;
        private System.Windows.Forms.Label lblProfile;
    }
}