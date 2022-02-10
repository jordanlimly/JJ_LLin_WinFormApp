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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnGameMachineUsage = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelUser = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.TextBox();
            this.pBUserAvatar = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.lblDashboardText = new System.Windows.Forms.Label();
            this.pnlCurrCreds = new System.Windows.Forms.Panel();
            this.lblCurrentCredits = new System.Windows.Forms.Label();
            this.pnlAccumPoints = new System.Windows.Forms.Panel();
            this.lblAccumPoints = new System.Windows.Forms.Label();
            this.pnlCurrPoints = new System.Windows.Forms.Panel();
            this.lblCurrentPoints = new System.Windows.Forms.Label();
            this.panelGMU = new System.Windows.Forms.Panel();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblGMU = new System.Windows.Forms.Label();
            this.cCredit = new System.Windows.Forms.TextBox();
            this.cPoint = new System.Windows.Forms.TextBox();
            this.lblcWarning = new System.Windows.Forms.Label();
            this.aPoint = new System.Windows.Forms.TextBox();
            this.lblMemTier = new System.Windows.Forms.Label();
            this.lblmTier = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlCurrCreds.SuspendLayout();
            this.pnlAccumPoints.SuspendLayout();
            this.pnlCurrPoints.SuspendLayout();
            this.panelGMU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panelUser.Controls.Add(this.lblEmail);
            this.panelUser.Controls.Add(this.pBUserAvatar);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUser.Location = new System.Drawing.Point(0, 80);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(178, 144);
            this.panelUser.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Black;
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmail.Cursor = System.Windows.Forms.Cursors.No;
            this.lblEmail.Enabled = false;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblEmail.Location = new System.Drawing.Point(35, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.ReadOnly = true;
            this.lblEmail.Size = new System.Drawing.Size(116, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(678, 3);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(37, 32);
            this.btnX.TabIndex = 2;
            this.btnX.Text = "X";
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
            this.pnlCurrCreds.Controls.Add(this.lblcWarning);
            this.pnlCurrCreds.Controls.Add(this.cCredit);
            this.pnlCurrCreds.Controls.Add(this.lblCurrentCredits);
            this.pnlCurrCreds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlCurrCreds.Location = new System.Drawing.Point(455, 102);
            this.pnlCurrCreds.Name = "pnlCurrCreds";
            this.pnlCurrCreds.Size = new System.Drawing.Size(258, 88);
            this.pnlCurrCreds.TabIndex = 2;
            // 
            // lblCurrentCredits
            // 
            this.lblCurrentCredits.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCredits.Location = new System.Drawing.Point(15, 8);
            this.lblCurrentCredits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentCredits.Name = "lblCurrentCredits";
            this.lblCurrentCredits.Size = new System.Drawing.Size(123, 19);
            this.lblCurrentCredits.TabIndex = 0;
            this.lblCurrentCredits.Text = "Current Credits";
            // 
            // pnlAccumPoints
            // 
            this.pnlAccumPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlAccumPoints.Controls.Add(this.textBox1);
            this.pnlAccumPoints.Controls.Add(this.label5);
            this.pnlAccumPoints.Controls.Add(this.label4);
            this.pnlAccumPoints.Controls.Add(this.label3);
            this.pnlAccumPoints.Controls.Add(this.progressPanel);
            this.pnlAccumPoints.Controls.Add(this.progressBar2);
            this.pnlAccumPoints.Controls.Add(this.label2);
            this.pnlAccumPoints.Controls.Add(this.aPoint);
            this.pnlAccumPoints.Controls.Add(this.lblAccumPoints);
            this.pnlAccumPoints.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAccumPoints.ForeColor = System.Drawing.Color.Gold;
            this.pnlAccumPoints.Location = new System.Drawing.Point(197, 206);
            this.pnlAccumPoints.Name = "pnlAccumPoints";
            this.pnlAccumPoints.Size = new System.Drawing.Size(687, 297);
            this.pnlAccumPoints.TabIndex = 3;
            // 
            // lblAccumPoints
            // 
            this.lblAccumPoints.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccumPoints.ForeColor = System.Drawing.Color.White;
            this.lblAccumPoints.Location = new System.Drawing.Point(556, 21);
            this.lblAccumPoints.MaximumSize = new System.Drawing.Size(200, 200);
            this.lblAccumPoints.Name = "lblAccumPoints";
            this.lblAccumPoints.Size = new System.Drawing.Size(147, 19);
            this.lblAccumPoints.TabIndex = 0;
            this.lblAccumPoints.Text = "Accumulated Points";
            // 
            // pnlCurrPoints
            // 
            this.pnlCurrPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.pnlCurrPoints.Controls.Add(this.cPoint);
            this.pnlCurrPoints.Controls.Add(this.lblCurrentPoints);
            this.pnlCurrPoints.Location = new System.Drawing.Point(738, 102);
            this.pnlCurrPoints.Name = "pnlCurrPoints";
            this.pnlCurrPoints.Size = new System.Drawing.Size(146, 88);
            this.pnlCurrPoints.TabIndex = 3;
            // 
            // lblCurrentPoints
            // 
            this.lblCurrentPoints.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPoints.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCurrentPoints.Location = new System.Drawing.Point(15, 8);
            this.lblCurrentPoints.MaximumSize = new System.Drawing.Size(200, 200);
            this.lblCurrentPoints.Name = "lblCurrentPoints";
            this.lblCurrentPoints.Size = new System.Drawing.Size(118, 19);
            this.lblCurrentPoints.TabIndex = 0;
            this.lblCurrentPoints.Text = "Current Points";
            // 
            // panelGMU
            // 
            this.panelGMU.BackgroundImage = global::MainWinFormApp.Properties.Resources.istockphoto_1061119906_612x612;
            this.panelGMU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGMU.Controls.Add(this.btnLoadData);
            this.panelGMU.Controls.Add(this.chart1);
            this.panelGMU.Controls.Add(this.lblGMU);
            this.panelGMU.Location = new System.Drawing.Point(178, 80);
            this.panelGMU.Name = "panelGMU";
            this.panelGMU.Size = new System.Drawing.Size(718, 447);
            this.panelGMU.TabIndex = 4;
            this.panelGMU.Visible = false;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(624, 58);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(82, 38);
            this.btnLoadData.TabIndex = 6;
            this.btnLoadData.Text = "Refresh";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // chart1
            // 
            chartArea14.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart1.Legends.Add(legend14);
            this.chart1.Location = new System.Drawing.Point(31, 58);
            this.chart1.Name = "chart1";
            series14.ChartArea = "ChartArea1";
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(587, 366);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
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
            // cCredit
            // 
            this.cCredit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cCredit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cCredit.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cCredit.ForeColor = System.Drawing.Color.White;
            this.cCredit.Location = new System.Drawing.Point(18, 30);
            this.cCredit.MaximumSize = new System.Drawing.Size(200, 200);
            this.cCredit.Name = "cCredit";
            this.cCredit.ReadOnly = true;
            this.cCredit.Size = new System.Drawing.Size(149, 30);
            this.cCredit.TabIndex = 1;
            this.cCredit.Text = "35";
            // 
            // cPoint
            // 
            this.cPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cPoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cPoint.Font = new System.Drawing.Font("Britannic Bold", 20F);
            this.cPoint.ForeColor = System.Drawing.Color.White;
            this.cPoint.Location = new System.Drawing.Point(14, 30);
            this.cPoint.MaximumSize = new System.Drawing.Size(200, 200);
            this.cPoint.Name = "cPoint";
            this.cPoint.ReadOnly = true;
            this.cPoint.Size = new System.Drawing.Size(165, 30);
            this.cPoint.TabIndex = 1;
            this.cPoint.Text = "40";
            // 
            // lblcWarning
            // 
            this.lblcWarning.AutoSize = true;
            this.lblcWarning.Font = new System.Drawing.Font("Britannic Bold", 9.75F);
            this.lblcWarning.ForeColor = System.Drawing.Color.Red;
            this.lblcWarning.Location = new System.Drawing.Point(15, 63);
            this.lblcWarning.Name = "lblcWarning";
            this.lblcWarning.Size = new System.Drawing.Size(219, 15);
            this.lblcWarning.TabIndex = 2;
            this.lblcWarning.Text = "Warning: Please top up credits soon!";
            // 
            // aPoint
            // 
            this.aPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.aPoint.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aPoint.ForeColor = System.Drawing.Color.White;
            this.aPoint.Location = new System.Drawing.Point(571, 53);
            this.aPoint.MaximumSize = new System.Drawing.Size(200, 200);
            this.aPoint.Name = "aPoint";
            this.aPoint.ReadOnly = true;
            this.aPoint.Size = new System.Drawing.Size(103, 34);
            this.aPoint.TabIndex = 1;
            // 
            // lblMemTier
            // 
            this.lblMemTier.AutoSize = true;
            this.lblMemTier.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemTier.ForeColor = System.Drawing.Color.White;
            this.lblMemTier.Location = new System.Drawing.Point(15, 12);
            this.lblMemTier.Name = "lblMemTier";
            this.lblMemTier.Size = new System.Drawing.Size(104, 15);
            this.lblMemTier.TabIndex = 2;
            this.lblMemTier.Text = "Membership Tier";
            // 
            // lblmTier
            // 
            this.lblmTier.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.lblmTier.ForeColor = System.Drawing.Color.White;
            this.lblmTier.Location = new System.Drawing.Point(91, 53);
            this.lblmTier.Name = "lblmTier";
            this.lblmTier.Size = new System.Drawing.Size(67, 33);
            this.lblmTier.TabIndex = 3;
            this.lblmTier.Text = "Tier";
            // 
            // progressBar2
            // 
            this.progressBar2.ForeColor = System.Drawing.Color.White;
            this.progressBar2.Location = new System.Drawing.Point(18, 55);
            this.progressBar2.Maximum = 1000;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(500, 40);
            this.progressBar2.TabIndex = 6;
            this.progressBar2.Value = 1;
            // 
            // progressPanel
            // 
            this.progressPanel.BackColor = System.Drawing.Color.Peru;
            this.progressPanel.Location = new System.Drawing.Point(18, 54);
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.Size = new System.Drawing.Size(81, 40);
            this.progressPanel.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prizes unlocked";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblMemTier);
            this.panel2.Controls.Add(this.lblmTier);
            this.panel2.Location = new System.Drawing.Point(197, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 88);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "Gold\r\n1000\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(255, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Silver\r\n400";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Peru;
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Bronze";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Britannic Bold", 20F);
            this.textBox1.Location = new System.Drawing.Point(267, 57);
            this.textBox1.MaximumSize = new System.Drawing.Size(200, 200);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1, 37);
            this.textBox1.TabIndex = 18;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MainWinFormApp.Properties.Resources.istockphoto_1061119906_612x6121;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 527);
            this.Controls.Add(this.panelGMU);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAccumPoints);
            this.Controls.Add(this.pnlCurrPoints);
            this.Controls.Add(this.pnlCurrCreds);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBUserAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCurrCreds.ResumeLayout(false);
            this.pnlCurrCreds.PerformLayout();
            this.pnlAccumPoints.ResumeLayout(false);
            this.pnlAccumPoints.PerformLayout();
            this.pnlCurrPoints.ResumeLayout(false);
            this.pnlCurrPoints.PerformLayout();
            this.panelGMU.ResumeLayout(false);
            this.panelGMU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblDashboardText;
        private System.Windows.Forms.Panel pnlCurrCreds;
        private System.Windows.Forms.Label lblCurrentCredits;
        private System.Windows.Forms.Panel pnlAccumPoints;
        private System.Windows.Forms.Label lblAccumPoints;
        private System.Windows.Forms.Panel pnlCurrPoints;
        private System.Windows.Forms.Label lblCurrentPoints;
        private System.Windows.Forms.Button btnGameMachineUsage;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panelGMU;
        private System.Windows.Forms.Label lblGMU;
        private System.Windows.Forms.TextBox lblEmail;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.TextBox cCredit;
        private System.Windows.Forms.TextBox cPoint;
        private System.Windows.Forms.Label lblcWarning;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel progressPanel;
        private System.Windows.Forms.TextBox aPoint;
        private System.Windows.Forms.Label lblMemTier;
        private System.Windows.Forms.Label lblmTier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}