namespace MainWinFormApp
{
    partial class AdminMainpage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CrowdTab = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.TotalCrowdCht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTotalCrowd = new System.Windows.Forms.Label();
            this.CurCrowdPanel = new System.Windows.Forms.Panel();
            this.HourlyCrowdCht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblCurrentCrowd = new System.Windows.Forms.Label();
            this.lbCurCrowdCount = new System.Windows.Forms.Label();
            this.lbDataComms = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PopularityTab = new System.Windows.Forms.TabPage();
            this.btnRetrieveDetails = new System.Windows.Forms.Button();
            this.btnAddMachine = new System.Windows.Forms.Button();
            this.panelPopularityChart = new System.Windows.Forms.Panel();
            this.MaintenanceTab = new System.Windows.Forms.TabPage();
            this.panelUpForMtnce = new System.Windows.Forms.Panel();
            this.btnRetrieveMaintenanceRecord = new System.Windows.Forms.Button();
            this.btnAddMaintenanceRecord = new System.Windows.Forms.Button();
            this.panelNeedMtnce = new System.Windows.Forms.Panel();
            this.panelExpenditureChart = new System.Windows.Forms.Panel();
            this.MaintenanceExpenditureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideNavPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPopularity = new System.Windows.Forms.Button();
            this.btnCrowdLvl = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.MinCrowdCht = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.CrowdTab.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCrowdCht)).BeginInit();
            this.CurCrowdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HourlyCrowdCht)).BeginInit();
            this.PopularityTab.SuspendLayout();
            this.MaintenanceTab.SuspendLayout();
            this.panelExpenditureChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaintenanceExpenditureChart)).BeginInit();
            this.topPanel.SuspendLayout();
            this.sideNavPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinCrowdCht)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.Black;
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(14, 275);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(183, 44);
            this.btnMaintenance.TabIndex = 2;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            this.btnMaintenance.Leave += new System.EventHandler(this.btnMaintenance_Leave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(14, 402);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(183, 44);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.Leave += new System.EventHandler(this.btnLogout_Leave);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.CrowdTab);
            this.tabControl1.Controls.Add(this.PopularityTab);
            this.tabControl1.Controls.Add(this.MaintenanceTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1352, 822);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // CrowdTab
            // 
            this.CrowdTab.BackgroundImage = global::MainWinFormApp.Properties.Resources.istockphoto_1061119906_612x612;
            this.CrowdTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CrowdTab.Controls.Add(this.panel7);
            this.CrowdTab.Controls.Add(this.panel6);
            this.CrowdTab.Controls.Add(this.CurCrowdPanel);
            this.CrowdTab.Controls.Add(this.lbDataComms);
            this.CrowdTab.Controls.Add(this.label1);
            this.CrowdTab.Location = new System.Drawing.Point(4, 5);
            this.CrowdTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrowdTab.Name = "CrowdTab";
            this.CrowdTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrowdTab.Size = new System.Drawing.Size(1344, 813);
            this.CrowdTab.TabIndex = 0;
            this.CrowdTab.Text = "CrowdTab";
            this.CrowdTab.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TotalCrowdCht);
            this.panel6.Controls.Add(this.lblTotalCrowd);
            this.panel6.Location = new System.Drawing.Point(892, 146);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(410, 346);
            this.panel6.TabIndex = 8;
            // 
            // TotalCrowdCht
            // 
            chartArea2.Name = "ChartArea1";
            this.TotalCrowdCht.ChartAreas.Add(chartArea2);
            this.TotalCrowdCht.Location = new System.Drawing.Point(3, 42);
            this.TotalCrowdCht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TotalCrowdCht.Name = "TotalCrowdCht";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.TotalCrowdCht.Series.Add(series2);
            this.TotalCrowdCht.Size = new System.Drawing.Size(396, 238);
            this.TotalCrowdCht.TabIndex = 1;
            this.TotalCrowdCht.Text = "chart1";
            // 
            // lblTotalCrowd
            // 
            this.lblTotalCrowd.AutoSize = true;
            this.lblTotalCrowd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCrowd.Location = new System.Drawing.Point(116, 8);
            this.lblTotalCrowd.Name = "lblTotalCrowd";
            this.lblTotalCrowd.Size = new System.Drawing.Size(180, 32);
            this.lblTotalCrowd.TabIndex = 0;
            this.lblTotalCrowd.Text = "Total Visitors";
            // 
            // CurCrowdPanel
            // 
            this.CurCrowdPanel.BackColor = System.Drawing.Color.GhostWhite;
            this.CurCrowdPanel.Controls.Add(this.HourlyCrowdCht);
            this.CurCrowdPanel.Controls.Add(this.lblCurrentCrowd);
            this.CurCrowdPanel.Controls.Add(this.lbCurCrowdCount);
            this.CurCrowdPanel.Location = new System.Drawing.Point(231, 149);
            this.CurCrowdPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurCrowdPanel.Name = "CurCrowdPanel";
            this.CurCrowdPanel.Size = new System.Drawing.Size(622, 344);
            this.CurCrowdPanel.TabIndex = 7;
            // 
            // HourlyCrowdCht
            // 
            chartArea3.Name = "ChartArea1";
            this.HourlyCrowdCht.ChartAreas.Add(chartArea3);
            this.HourlyCrowdCht.Location = new System.Drawing.Point(16, 66);
            this.HourlyCrowdCht.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HourlyCrowdCht.Name = "HourlyCrowdCht";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.MarkerColor = System.Drawing.Color.White;
            series3.Name = "Series1";
            this.HourlyCrowdCht.Series.Add(series3);
            this.HourlyCrowdCht.Size = new System.Drawing.Size(586, 251);
            this.HourlyCrowdCht.TabIndex = 7;
            this.HourlyCrowdCht.Text = "chart1";
            // 
            // lblCurrentCrowd
            // 
            this.lblCurrentCrowd.AutoSize = true;
            this.lblCurrentCrowd.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentCrowd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCrowd.Location = new System.Drawing.Point(189, 8);
            this.lblCurrentCrowd.Name = "lblCurrentCrowd";
            this.lblCurrentCrowd.Size = new System.Drawing.Size(197, 32);
            this.lblCurrentCrowd.TabIndex = 4;
            this.lblCurrentCrowd.Text = "Current Crowd";
            // 
            // lbCurCrowdCount
            // 
            this.lbCurCrowdCount.AutoSize = true;
            this.lbCurCrowdCount.Location = new System.Drawing.Point(446, 14);
            this.lbCurCrowdCount.Name = "lbCurCrowdCount";
            this.lbCurCrowdCount.Size = new System.Drawing.Size(18, 20);
            this.lbCurCrowdCount.TabIndex = 6;
            this.lbCurCrowdCount.Text = "0";
            // 
            // lbDataComms
            // 
            this.lbDataComms.FormattingEnabled = true;
            this.lbDataComms.ItemHeight = 20;
            this.lbDataComms.Location = new System.Drawing.Point(892, 528);
            this.lbDataComms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDataComms.Name = "lbDataComms";
            this.lbDataComms.Size = new System.Drawing.Size(410, 244);
            this.lbDataComms.TabIndex = 5;
            this.lbDataComms.Tag = "";
            this.lbDataComms.SelectedIndexChanged += new System.EventHandler(this.lbDataComms_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CrowdTab";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PopularityTab
            // 
            this.PopularityTab.BackgroundImage = global::MainWinFormApp.Properties.Resources.istockphoto_1061119906_612x612;
            this.PopularityTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PopularityTab.Controls.Add(this.btnRetrieveDetails);
            this.PopularityTab.Controls.Add(this.btnAddMachine);
            this.PopularityTab.Controls.Add(this.panelPopularityChart);
            this.PopularityTab.Location = new System.Drawing.Point(4, 5);
            this.PopularityTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PopularityTab.Name = "PopularityTab";
            this.PopularityTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PopularityTab.Size = new System.Drawing.Size(1344, 813);
            this.PopularityTab.TabIndex = 1;
            this.PopularityTab.Text = "GameMachinesTab";
            this.PopularityTab.UseVisualStyleBackColor = true;
            // 
            // btnRetrieveDetails
            // 
            this.btnRetrieveDetails.BackColor = System.Drawing.Color.Black;
            this.btnRetrieveDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnRetrieveDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieveDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnRetrieveDetails.Location = new System.Drawing.Point(786, 658);
            this.btnRetrieveDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRetrieveDetails.Name = "btnRetrieveDetails";
            this.btnRetrieveDetails.Size = new System.Drawing.Size(177, 72);
            this.btnRetrieveDetails.TabIndex = 2;
            this.btnRetrieveDetails.Text = "Retrieve Details";
            this.btnRetrieveDetails.UseVisualStyleBackColor = false;
            this.btnRetrieveDetails.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAddMachine
            // 
            this.btnAddMachine.BackColor = System.Drawing.Color.Black;
            this.btnAddMachine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnAddMachine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMachine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnAddMachine.Location = new System.Drawing.Point(504, 658);
            this.btnAddMachine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMachine.Name = "btnAddMachine";
            this.btnAddMachine.Size = new System.Drawing.Size(177, 72);
            this.btnAddMachine.TabIndex = 1;
            this.btnAddMachine.Text = "Add Machine";
            this.btnAddMachine.UseVisualStyleBackColor = false;
            this.btnAddMachine.Click += new System.EventHandler(this.btnAddMachine_Click);
            // 
            // panelPopularityChart
            // 
            this.panelPopularityChart.Location = new System.Drawing.Point(405, 148);
            this.panelPopularityChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPopularityChart.Name = "panelPopularityChart";
            this.panelPopularityChart.Size = new System.Drawing.Size(640, 442);
            this.panelPopularityChart.TabIndex = 0;
            // 
            // MaintenanceTab
            // 
            this.MaintenanceTab.BackgroundImage = global::MainWinFormApp.Properties.Resources.istockphoto_1061119906_612x612;
            this.MaintenanceTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaintenanceTab.Controls.Add(this.panelUpForMtnce);
            this.MaintenanceTab.Controls.Add(this.btnRetrieveMaintenanceRecord);
            this.MaintenanceTab.Controls.Add(this.btnAddMaintenanceRecord);
            this.MaintenanceTab.Controls.Add(this.panelNeedMtnce);
            this.MaintenanceTab.Controls.Add(this.panelExpenditureChart);
            this.MaintenanceTab.Controls.Add(this.label3);
            this.MaintenanceTab.Location = new System.Drawing.Point(4, 5);
            this.MaintenanceTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaintenanceTab.Name = "MaintenanceTab";
            this.MaintenanceTab.Size = new System.Drawing.Size(1344, 813);
            this.MaintenanceTab.TabIndex = 2;
            this.MaintenanceTab.Text = "MaintenanceTab";
            this.MaintenanceTab.UseVisualStyleBackColor = true;
            // 
            // panelUpForMtnce
            // 
            this.panelUpForMtnce.Location = new System.Drawing.Point(953, 385);
            this.panelUpForMtnce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUpForMtnce.Name = "panelUpForMtnce";
            this.panelUpForMtnce.Size = new System.Drawing.Size(323, 180);
            this.panelUpForMtnce.TabIndex = 5;
            // 
            // btnRetrieveMaintenanceRecord
            // 
            this.btnRetrieveMaintenanceRecord.BackColor = System.Drawing.Color.Black;
            this.btnRetrieveMaintenanceRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnRetrieveMaintenanceRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieveMaintenanceRecord.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveMaintenanceRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnRetrieveMaintenanceRecord.Location = new System.Drawing.Point(821, 639);
            this.btnRetrieveMaintenanceRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRetrieveMaintenanceRecord.Name = "btnRetrieveMaintenanceRecord";
            this.btnRetrieveMaintenanceRecord.Size = new System.Drawing.Size(184, 89);
            this.btnRetrieveMaintenanceRecord.TabIndex = 4;
            this.btnRetrieveMaintenanceRecord.Text = "Retrieve Record";
            this.btnRetrieveMaintenanceRecord.UseVisualStyleBackColor = false;
            this.btnRetrieveMaintenanceRecord.Click += new System.EventHandler(this.btnRetrieveMaintenanceRecord_Click);
            // 
            // btnAddMaintenanceRecord
            // 
            this.btnAddMaintenanceRecord.BackColor = System.Drawing.Color.Black;
            this.btnAddMaintenanceRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnAddMaintenanceRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMaintenanceRecord.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMaintenanceRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnAddMaintenanceRecord.Location = new System.Drawing.Point(510, 639);
            this.btnAddMaintenanceRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddMaintenanceRecord.Name = "btnAddMaintenanceRecord";
            this.btnAddMaintenanceRecord.Size = new System.Drawing.Size(184, 89);
            this.btnAddMaintenanceRecord.TabIndex = 3;
            this.btnAddMaintenanceRecord.Text = "Add Record";
            this.btnAddMaintenanceRecord.UseVisualStyleBackColor = false;
            this.btnAddMaintenanceRecord.Click += new System.EventHandler(this.btnAddMaintenanceRecord_Click);
            // 
            // panelNeedMtnce
            // 
            this.panelNeedMtnce.Location = new System.Drawing.Point(953, 164);
            this.panelNeedMtnce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelNeedMtnce.Name = "panelNeedMtnce";
            this.panelNeedMtnce.Size = new System.Drawing.Size(323, 198);
            this.panelNeedMtnce.TabIndex = 2;
            // 
            // panelExpenditureChart
            // 
            this.panelExpenditureChart.Controls.Add(this.MaintenanceExpenditureChart);
            this.panelExpenditureChart.Location = new System.Drawing.Point(248, 164);
            this.panelExpenditureChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelExpenditureChart.Name = "panelExpenditureChart";
            this.panelExpenditureChart.Size = new System.Drawing.Size(664, 401);
            this.panelExpenditureChart.TabIndex = 1;
            // 
            // MaintenanceExpenditureChart
            // 
            chartArea4.Name = "ChartArea1";
            this.MaintenanceExpenditureChart.ChartAreas.Add(chartArea4);
            legend1.Name = "Legend1";
            this.MaintenanceExpenditureChart.Legends.Add(legend1);
            this.MaintenanceExpenditureChart.Location = new System.Drawing.Point(3, -4);
            this.MaintenanceExpenditureChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaintenanceExpenditureChart.Name = "MaintenanceExpenditureChart";
            this.MaintenanceExpenditureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Maintenance Monthly Expenditure";
            this.MaintenanceExpenditureChart.Series.Add(series4);
            this.MaintenanceExpenditureChart.Size = new System.Drawing.Size(664, 401);
            this.MaintenanceExpenditureChart.TabIndex = 0;
            this.MaintenanceExpenditureChart.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(706, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "MaintenanceTab";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.btnCloseWindow);
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1352, 125);
            this.topPanel.TabIndex = 5;
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.BackgroundImage = global::MainWinFormApp.Properties.Resources.Windows_Close_Icon__1_;
            this.btnCloseWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Location = new System.Drawing.Point(1285, 12);
            this.btnCloseWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(54, 29);
            this.btnCloseWindow.TabIndex = 1;
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MainWinFormApp.Properties.Resources.JJ_LLin_logo_png;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 125);
            this.panel1.TabIndex = 0;
            // 
            // sideNavPanel
            // 
            this.sideNavPanel.BackColor = System.Drawing.Color.Black;
            this.sideNavPanel.Controls.Add(this.panel5);
            this.sideNavPanel.Controls.Add(this.panel4);
            this.sideNavPanel.Controls.Add(this.panel3);
            this.sideNavPanel.Controls.Add(this.panel2);
            this.sideNavPanel.Controls.Add(this.btnPopularity);
            this.sideNavPanel.Controls.Add(this.btnCrowdLvl);
            this.sideNavPanel.Controls.Add(this.btnMaintenance);
            this.sideNavPanel.Controls.Add(this.btnLogout);
            this.sideNavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideNavPanel.Location = new System.Drawing.Point(0, 125);
            this.sideNavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sideNavPanel.Name = "sideNavPanel";
            this.sideNavPanel.Size = new System.Drawing.Size(200, 697);
            this.sideNavPanel.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.panel5.Location = new System.Drawing.Point(4, 402);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 44);
            this.panel5.TabIndex = 5;
            this.panel5.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.panel4.Location = new System.Drawing.Point(4, 275);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 44);
            this.panel4.TabIndex = 4;
            this.panel4.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.panel3.Location = new System.Drawing.Point(4, 149);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 44);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.panel2.Location = new System.Drawing.Point(4, 29);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 44);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // btnPopularity
            // 
            this.btnPopularity.BackColor = System.Drawing.Color.Black;
            this.btnPopularity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPopularity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopularity.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopularity.ForeColor = System.Drawing.Color.White;
            this.btnPopularity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPopularity.Location = new System.Drawing.Point(14, 149);
            this.btnPopularity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPopularity.Name = "btnPopularity";
            this.btnPopularity.Size = new System.Drawing.Size(183, 44);
            this.btnPopularity.TabIndex = 1;
            this.btnPopularity.Text = "Game Machines";
            this.btnPopularity.UseVisualStyleBackColor = false;
            this.btnPopularity.Click += new System.EventHandler(this.btnPopularity_Click);
            this.btnPopularity.Leave += new System.EventHandler(this.btnPopularity_Leave);
            // 
            // btnCrowdLvl
            // 
            this.btnCrowdLvl.BackColor = System.Drawing.Color.Black;
            this.btnCrowdLvl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrowdLvl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCrowdLvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrowdLvl.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrowdLvl.ForeColor = System.Drawing.Color.White;
            this.btnCrowdLvl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrowdLvl.Location = new System.Drawing.Point(14, 29);
            this.btnCrowdLvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrowdLvl.Name = "btnCrowdLvl";
            this.btnCrowdLvl.Size = new System.Drawing.Size(183, 44);
            this.btnCrowdLvl.TabIndex = 0;
            this.btnCrowdLvl.Text = "Crowd Level";
            this.btnCrowdLvl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrowdLvl.UseVisualStyleBackColor = false;
            this.btnCrowdLvl.Click += new System.EventHandler(this.button1_Click);
            this.btnCrowdLvl.Leave += new System.EventHandler(this.btnCrowdLvl_Leave);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.MinCrowdCht);
            this.panel7.Location = new System.Drawing.Point(231, 528);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(621, 243);
            this.panel7.TabIndex = 9;
            // 
            // MinCrowdCht
            // 
            chartArea1.Name = "ChartArea1";
            this.MinCrowdCht.ChartAreas.Add(chartArea1);
            this.MinCrowdCht.Location = new System.Drawing.Point(16, 3);
            this.MinCrowdCht.Name = "MinCrowdCht";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.MinCrowdCht.Series.Add(series1);
            this.MinCrowdCht.Size = new System.Drawing.Size(482, 227);
            this.MinCrowdCht.TabIndex = 0;
            this.MinCrowdCht.Text = "chart1";
            // 
            // AdminMainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 822);
            this.Controls.Add(this.sideNavPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMainpage";
            this.Text = "AdminMainpage";
            this.Load += new System.EventHandler(this.AdminMainpage_Load);
            this.tabControl1.ResumeLayout(false);
            this.CrowdTab.ResumeLayout(false);
            this.CrowdTab.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalCrowdCht)).EndInit();
            this.CurCrowdPanel.ResumeLayout(false);
            this.CurCrowdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HourlyCrowdCht)).EndInit();
            this.PopularityTab.ResumeLayout(false);
            this.MaintenanceTab.ResumeLayout(false);
            this.MaintenanceTab.PerformLayout();
            this.panelExpenditureChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaintenanceExpenditureChart)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.sideNavPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinCrowdCht)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrowdLvl;
        private System.Windows.Forms.Button btnPopularity;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CrowdTab;
        private System.Windows.Forms.TabPage PopularityTab;
        private System.Windows.Forms.TabPage MaintenanceTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sideNavPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbCurCrowdCount;
        private System.Windows.Forms.ListBox lbDataComms;
        private System.Windows.Forms.Label lblCurrentCrowd;
        private System.Windows.Forms.Panel CurCrowdPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalCrowd;
        private System.Windows.Forms.Button btnRetrieveMaintenanceRecord;
        private System.Windows.Forms.Button btnAddMaintenanceRecord;
        private System.Windows.Forms.Panel panelNeedMtnce;
        private System.Windows.Forms.Panel panelExpenditureChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart MaintenanceExpenditureChart;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Panel panelUpForMtnce;
        private System.Windows.Forms.Panel panelPopularityChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart TotalCrowdCht;
        private System.Windows.Forms.DataVisualization.Charting.Chart HourlyCrowdCht;
        private System.Windows.Forms.Button btnAddMachine;
        private System.Windows.Forms.Button btnRetrieveDetails;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart MinCrowdCht;
    }
}