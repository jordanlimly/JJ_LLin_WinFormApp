namespace MainWinFormApp
{
    partial class UserDashboard
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnGameMachineUsage = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pBUserAvatar = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblDashboardText = new System.Windows.Forms.Label();
            this.pnlCurrCreds = new System.Windows.Forms.Panel();
            this.lblCurrentCredits = new System.Windows.Forms.Label();
            this.pnlMemTier = new System.Windows.Forms.Panel();
            this.lblMemTier = new System.Windows.Forms.Label();
            this.pnlAccumPoints = new System.Windows.Forms.Panel();
            this.lblAccumPoints = new System.Windows.Forms.Label();
            this.pnlCurrPoints = new System.Windows.Forms.Panel();
            this.lblCurrentPoints = new System.Windows.Forms.Label();
            this.panelGMU = new System.Windows.Forms.Panel();
            this.lblGMU = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlCurrCreds.SuspendLayout();
            this.pnlMemTier.SuspendLayout();
            this.pnlAccumPoints.SuspendLayout();
            this.pnlCurrPoints.SuspendLayout();
            this.panelGMU.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.pnlNav);
            this.panelMenu.Controls.Add(this.btnGameMachineUsage);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelUser);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(178, 527);
            this.panelMenu.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.pnlNav.ForeColor = System.Drawing.Color.Black;
            this.pnlNav.Location = new System.Drawing.Point(0, 224);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 302);
            this.pnlNav.TabIndex = 10;
            // 
            // btnGameMachineUsage
            // 
            this.btnGameMachineUsage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGameMachineUsage.FlatAppearance.BorderSize = 0;
            this.btnGameMachineUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameMachineUsage.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameMachineUsage.ForeColor = System.Drawing.Color.White;
            this.btnGameMachineUsage.Location = new System.Drawing.Point(0, 294);
            this.btnGameMachineUsage.Name = "btnGameMachineUsage";
            this.btnGameMachineUsage.Size = new System.Drawing.Size(178, 35);
            this.btnGameMachineUsage.TabIndex = 9;
            this.btnGameMachineUsage.Text = "Game Machine Usage";
            this.btnGameMachineUsage.UseVisualStyleBackColor = true;
            this.btnGameMachineUsage.Click += new System.EventHandler(this.btnGameMachineUsage_Click);
            this.btnGameMachineUsage.Leave += new System.EventHandler(this.btnGameMachineUsage_Leave);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 492);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(178, 35);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 259);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(178, 35);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Leave += new System.EventHandler(this.btnSettings_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 224);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(178, 35);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.label1);
            this.panelUser.Controls.Add(this.pBUserAvatar);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 80);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(178, 144);
            this.panelUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pBUserAvatar
            // 
            this.pBUserAvatar.Image = global::MainWinFormApp.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_User_yellow_0_removebg_preview1;
            this.pBUserAvatar.InitialImage = null;
            this.pBUserAvatar.Location = new System.Drawing.Point(60, 22);
            this.pBUserAvatar.Name = "pBUserAvatar";
            this.pBUserAvatar.Size = new System.Drawing.Size(63, 63);
            this.pBUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBUserAvatar.TabIndex = 0;
            this.pBUserAvatar.TabStop = false;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = global::MainWinFormApp.Properties.Resources.JJ_LLin_logo_png1;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(178, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.lblDashboardText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(178, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 80);
            this.panel1.TabIndex = 1;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.BackgroundImage = global::MainWinFormApp.Properties.Resources.Windows_Close_Icon__1_;
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(679, 11);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(36, 19);
            this.btnX.TabIndex = 2;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblDashboardText
            // 
            this.lblDashboardText.AutoSize = true;
            this.lblDashboardText.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboardText.Font = new System.Drawing.Font("Britannic Bold", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblDashboardText.Location = new System.Drawing.Point(280, 23);
            this.lblDashboardText.Name = "lblDashboardText";
            this.lblDashboardText.Size = new System.Drawing.Size(148, 31);
            this.lblDashboardText.TabIndex = 2;
            this.lblDashboardText.Text = "Dashboard";
            // 
            // pnlCurrCreds
            // 
            this.pnlCurrCreds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlCurrCreds.Controls.Add(this.lblCurrentCredits);
            this.pnlCurrCreds.Location = new System.Drawing.Point(192, 94);
            this.pnlCurrCreds.Name = "pnlCurrCreds";
            this.pnlCurrCreds.Size = new System.Drawing.Size(258, 130);
            this.pnlCurrCreds.TabIndex = 2;
            this.pnlCurrCreds.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCurrCreds_Paint);
            // 
            // lblCurrentCredits
            // 
            this.lblCurrentCredits.AutoSize = true;
            this.lblCurrentCredits.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCredits.Location = new System.Drawing.Point(15, 8);
            this.lblCurrentCredits.Name = "lblCurrentCredits";
            this.lblCurrentCredits.Size = new System.Drawing.Size(96, 15);
            this.lblCurrentCredits.TabIndex = 0;
            this.lblCurrentCredits.Text = "Current Credits";
            // 
            // pnlMemTier
            // 
            this.pnlMemTier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlMemTier.Controls.Add(this.lblMemTier);
            this.pnlMemTier.Location = new System.Drawing.Point(586, 294);
            this.pnlMemTier.Name = "pnlMemTier";
            this.pnlMemTier.Size = new System.Drawing.Size(258, 130);
            this.pnlMemTier.TabIndex = 3;
            // 
            // lblMemTier
            // 
            this.lblMemTier.AutoSize = true;
            this.lblMemTier.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemTier.Location = new System.Drawing.Point(15, 8);
            this.lblMemTier.Name = "lblMemTier";
            this.lblMemTier.Size = new System.Drawing.Size(104, 15);
            this.lblMemTier.TabIndex = 0;
            this.lblMemTier.Text = "Membership Tier";
            // 
            // pnlAccumPoints
            // 
            this.pnlAccumPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlAccumPoints.Controls.Add(this.lblAccumPoints);
            this.pnlAccumPoints.Location = new System.Drawing.Point(192, 294);
            this.pnlAccumPoints.Name = "pnlAccumPoints";
            this.pnlAccumPoints.Size = new System.Drawing.Size(258, 130);
            this.pnlAccumPoints.TabIndex = 3;
            // 
            // lblAccumPoints
            // 
            this.lblAccumPoints.AutoSize = true;
            this.lblAccumPoints.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccumPoints.Location = new System.Drawing.Point(15, 8);
            this.lblAccumPoints.Name = "lblAccumPoints";
            this.lblAccumPoints.Size = new System.Drawing.Size(119, 15);
            this.lblAccumPoints.TabIndex = 0;
            this.lblAccumPoints.Text = "Accumulated Points";
            // 
            // pnlCurrPoints
            // 
            this.pnlCurrPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlCurrPoints.Controls.Add(this.lblCurrentPoints);
            this.pnlCurrPoints.Location = new System.Drawing.Point(586, 94);
            this.pnlCurrPoints.Name = "pnlCurrPoints";
            this.pnlCurrPoints.Size = new System.Drawing.Size(258, 130);
            this.pnlCurrPoints.TabIndex = 3;
            // 
            // lblCurrentPoints
            // 
            this.lblCurrentPoints.AutoSize = true;
            this.lblCurrentPoints.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPoints.Location = new System.Drawing.Point(15, 8);
            this.lblCurrentPoints.Name = "lblCurrentPoints";
            this.lblCurrentPoints.Size = new System.Drawing.Size(91, 15);
            this.lblCurrentPoints.TabIndex = 0;
            this.lblCurrentPoints.Text = "Current Points";
            // 
            // panelGMU
            // 
            this.panelGMU.BackgroundImage = global::MainWinFormApp.Properties.Resources.istockphoto_1061119906_612x612;
            this.panelGMU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGMU.Controls.Add(this.lblGMU);
            this.panelGMU.Location = new System.Drawing.Point(178, 80);
            this.panelGMU.Name = "panelGMU";
            this.panelGMU.Size = new System.Drawing.Size(718, 447);
            this.panelGMU.TabIndex = 4;
            this.panelGMU.Visible = false;
            // 
            // lblGMU
            // 
            this.lblGMU.AutoSize = true;
            this.lblGMU.BackColor = System.Drawing.Color.Transparent;
            this.lblGMU.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblGMU.Location = new System.Drawing.Point(6, 10);
            this.lblGMU.Name = "lblGMU";
            this.lblGMU.Size = new System.Drawing.Size(240, 27);
            this.lblGMU.TabIndex = 4;
            this.lblGMU.Text = "Game Machine Usage";
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainWinFormApp.Properties.Resources.istockphoto_1061119906_612x6121;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 527);
            this.Controls.Add(this.panelGMU);
            this.Controls.Add(this.pnlMemTier);
            this.Controls.Add(this.pnlAccumPoints);
            this.Controls.Add(this.pnlCurrPoints);
            this.Controls.Add(this.pnlCurrCreds);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.panelMenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCurrCreds.ResumeLayout(false);
            this.pnlCurrCreds.PerformLayout();
            this.pnlMemTier.ResumeLayout(false);
            this.pnlMemTier.PerformLayout();
            this.pnlAccumPoints.ResumeLayout(false);
            this.pnlAccumPoints.PerformLayout();
            this.pnlCurrPoints.ResumeLayout(false);
            this.pnlCurrPoints.PerformLayout();
            this.panelGMU.ResumeLayout(false);
            this.panelGMU.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pBUserAvatar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblDashboardText;
        private System.Windows.Forms.Panel pnlCurrCreds;
        private System.Windows.Forms.Label lblCurrentCredits;
        private System.Windows.Forms.Panel pnlMemTier;
        private System.Windows.Forms.Label lblMemTier;
        private System.Windows.Forms.Panel pnlAccumPoints;
        private System.Windows.Forms.Label lblAccumPoints;
        private System.Windows.Forms.Panel pnlCurrPoints;
        private System.Windows.Forms.Label lblCurrentPoints;
        private System.Windows.Forms.Button btnGameMachineUsage;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panelGMU;
        private System.Windows.Forms.Label lblGMU;
    }
}