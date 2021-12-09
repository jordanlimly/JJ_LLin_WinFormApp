﻿namespace MainWinFormApp
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pBUserAvatar = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDashboardText = new System.Windows.Forms.Label();
            this.pnlCurrCreds = new System.Windows.Forms.Panel();
            this.lblCurrentCredits = new System.Windows.Forms.Label();
            this.pnlMemTier = new System.Windows.Forms.Panel();
            this.lblMemTier = new System.Windows.Forms.Label();
            this.pnlAccumPoints = new System.Windows.Forms.Panel();
            this.lblAccumPoints = new System.Windows.Forms.Label();
            this.pnlCurrPoints = new System.Windows.Forms.Panel();
            this.lblCurrentPoints = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlCurrCreds.SuspendLayout();
            this.pnlMemTier.SuspendLayout();
            this.pnlAccumPoints.SuspendLayout();
            this.pnlCurrPoints.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.pnlNav);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnDashboard);
            this.panelMenu.Controls.Add(this.panelUser);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(237, 649);
            this.panelMenu.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.pnlNav.Location = new System.Drawing.Point(4, 283);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 123);
            this.pnlNav.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 361);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(237, 43);
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
            this.btnSettings.Location = new System.Drawing.Point(0, 318);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(237, 43);
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
            this.btnDashboard.Location = new System.Drawing.Point(0, 275);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(237, 43);
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
            this.panelUser.Location = new System.Drawing.Point(0, 98);
            this.panelUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(237, 177);
            this.panelUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pBUserAvatar
            // 
            this.pBUserAvatar.Image = global::MainWinFormApp.Properties.Resources.Custom_Icon_Design_Pretty_Office_8_User_yellow_0_removebg_preview1;
            this.pBUserAvatar.InitialImage = null;
            this.pBUserAvatar.Location = new System.Drawing.Point(80, 27);
            this.pBUserAvatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pBUserAvatar.Name = "pBUserAvatar";
            this.pBUserAvatar.Size = new System.Drawing.Size(84, 78);
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
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(237, 98);
            this.panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblDashboardText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(237, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 98);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::MainWinFormApp.Properties.Resources.Windows_Close_Icon__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(905, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDashboardText
            // 
            this.lblDashboardText.AutoSize = true;
            this.lblDashboardText.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboardText.Font = new System.Drawing.Font("Britannic Bold", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblDashboardText.Location = new System.Drawing.Point(373, 28);
            this.lblDashboardText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboardText.Name = "lblDashboardText";
            this.lblDashboardText.Size = new System.Drawing.Size(187, 38);
            this.lblDashboardText.TabIndex = 2;
            this.lblDashboardText.Text = "Dashboard";
            // 
            // pnlCurrCreds
            // 
            this.pnlCurrCreds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlCurrCreds.Controls.Add(this.lblCurrentCredits);
            this.pnlCurrCreds.Location = new System.Drawing.Point(256, 116);
            this.pnlCurrCreds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCurrCreds.Name = "pnlCurrCreds";
            this.pnlCurrCreds.Size = new System.Drawing.Size(344, 160);
            this.pnlCurrCreds.TabIndex = 2;
            // 
            // lblCurrentCredits
            // 
            this.lblCurrentCredits.AutoSize = true;
            this.lblCurrentCredits.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCredits.Location = new System.Drawing.Point(20, 10);
            this.lblCurrentCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentCredits.Name = "lblCurrentCredits";
            this.lblCurrentCredits.Size = new System.Drawing.Size(123, 19);
            this.lblCurrentCredits.TabIndex = 0;
            this.lblCurrentCredits.Text = "Current Credits";
            // 
            // pnlMemTier
            // 
            this.pnlMemTier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlMemTier.Controls.Add(this.lblMemTier);
            this.pnlMemTier.Location = new System.Drawing.Point(781, 306);
            this.pnlMemTier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMemTier.Name = "pnlMemTier";
            this.pnlMemTier.Size = new System.Drawing.Size(344, 160);
            this.pnlMemTier.TabIndex = 3;
            // 
            // lblMemTier
            // 
            this.lblMemTier.AutoSize = true;
            this.lblMemTier.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemTier.Location = new System.Drawing.Point(20, 10);
            this.lblMemTier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMemTier.Name = "lblMemTier";
            this.lblMemTier.Size = new System.Drawing.Size(133, 19);
            this.lblMemTier.TabIndex = 0;
            this.lblMemTier.Text = "Membership Tier";
            // 
            // pnlAccumPoints
            // 
            this.pnlAccumPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlAccumPoints.Controls.Add(this.lblAccumPoints);
            this.pnlAccumPoints.Location = new System.Drawing.Point(256, 306);
            this.pnlAccumPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAccumPoints.Name = "pnlAccumPoints";
            this.pnlAccumPoints.Size = new System.Drawing.Size(344, 160);
            this.pnlAccumPoints.TabIndex = 3;
            // 
            // lblAccumPoints
            // 
            this.lblAccumPoints.AutoSize = true;
            this.lblAccumPoints.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccumPoints.Location = new System.Drawing.Point(20, 10);
            this.lblAccumPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccumPoints.Name = "lblAccumPoints";
            this.lblAccumPoints.Size = new System.Drawing.Size(156, 19);
            this.lblAccumPoints.TabIndex = 0;
            this.lblAccumPoints.Text = "Accumulated Points";
            // 
            // pnlCurrPoints
            // 
            this.pnlCurrPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlCurrPoints.Controls.Add(this.lblCurrentPoints);
            this.pnlCurrPoints.Location = new System.Drawing.Point(781, 116);
            this.pnlCurrPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlCurrPoints.Name = "pnlCurrPoints";
            this.pnlCurrPoints.Size = new System.Drawing.Size(344, 160);
            this.pnlCurrPoints.TabIndex = 3;
            // 
            // lblCurrentPoints
            // 
            this.lblCurrentPoints.AutoSize = true;
            this.lblCurrentPoints.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPoints.Location = new System.Drawing.Point(20, 10);
            this.lblCurrentPoints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentPoints.Name = "lblCurrentPoints";
            this.lblCurrentPoints.Size = new System.Drawing.Size(118, 19);
            this.lblCurrentPoints.TabIndex = 0;
            this.lblCurrentPoints.Text = "Current Points";
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainWinFormApp.Properties.Resources.istockphoto_1061119906_612x6121;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 649);
            this.Controls.Add(this.pnlMemTier);
            this.Controls.Add(this.pnlAccumPoints);
            this.Controls.Add(this.pnlCurrPoints);
            this.Controls.Add(this.pnlCurrCreds);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDashboardText;
        private System.Windows.Forms.Panel pnlCurrCreds;
        private System.Windows.Forms.Label lblCurrentCredits;
        private System.Windows.Forms.Panel pnlMemTier;
        private System.Windows.Forms.Label lblMemTier;
        private System.Windows.Forms.Panel pnlAccumPoints;
        private System.Windows.Forms.Label lblAccumPoints;
        private System.Windows.Forms.Panel pnlCurrPoints;
        private System.Windows.Forms.Label lblCurrentPoints;
    }
}