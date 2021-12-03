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
            this.btnPopularity = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PopularityTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.MaintenanceTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.sideNavPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCrowdLvl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CrowdTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.PopularityTab.SuspendLayout();
            this.MaintenanceTab.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.sideNavPanel.SuspendLayout();
            this.CrowdTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPopularity
            // 
            this.btnPopularity.BackColor = System.Drawing.Color.Black;
            this.btnPopularity.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPopularity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPopularity.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopularity.ForeColor = System.Drawing.Color.White;
            this.btnPopularity.Location = new System.Drawing.Point(12, 119);
            this.btnPopularity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPopularity.Name = "btnPopularity";
            this.btnPopularity.Size = new System.Drawing.Size(163, 35);
            this.btnPopularity.TabIndex = 1;
            this.btnPopularity.Text = "Game Popularity";
            this.btnPopularity.UseVisualStyleBackColor = false;
            this.btnPopularity.Click += new System.EventHandler(this.btnPopularity_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.Black;
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenance.ForeColor = System.Drawing.Color.White;
            this.btnMaintenance.Location = new System.Drawing.Point(12, 220);
            this.btnMaintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(163, 35);
            this.btnMaintenance.TabIndex = 2;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = false;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(12, 322);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(163, 35);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.CrowdTab);
            this.tabControl1.Controls.Add(this.PopularityTab);
            this.tabControl1.Controls.Add(this.MaintenanceTab);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(167, 88);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 603);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // PopularityTab
            // 
            this.PopularityTab.Controls.Add(this.label2);
            this.PopularityTab.Location = new System.Drawing.Point(4, 5);
            this.PopularityTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PopularityTab.Name = "PopularityTab";
            this.PopularityTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PopularityTab.Size = new System.Drawing.Size(1000, 594);
            this.PopularityTab.TabIndex = 1;
            this.PopularityTab.Text = "PopularityTab";
            this.PopularityTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "PopularityTab";
            // 
            // MaintenanceTab
            // 
            this.MaintenanceTab.Controls.Add(this.label3);
            this.MaintenanceTab.Location = new System.Drawing.Point(4, 5);
            this.MaintenanceTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaintenanceTab.Name = "MaintenanceTab";
            this.MaintenanceTab.Size = new System.Drawing.Size(1000, 594);
            this.MaintenanceTab.TabIndex = 2;
            this.MaintenanceTab.Text = "MaintenanceTab";
            this.MaintenanceTab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(628, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "MaintenanceTab";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.panel1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1161, 100);
            this.topPanel.TabIndex = 5;
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
            this.sideNavPanel.Location = new System.Drawing.Point(0, 100);
            this.sideNavPanel.Margin = new System.Windows.Forms.Padding(0);
            this.sideNavPanel.Name = "sideNavPanel";
            this.sideNavPanel.Size = new System.Drawing.Size(178, 578);
            this.sideNavPanel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.panel2.Location = new System.Drawing.Point(4, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 35);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.panel3.Location = new System.Drawing.Point(4, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 35);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.panel4.Location = new System.Drawing.Point(4, 220);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 35);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.panel5.Location = new System.Drawing.Point(4, 322);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 35);
            this.panel5.TabIndex = 5;
            // 
            // btnCrowdLvl
            // 
            this.btnCrowdLvl.BackColor = System.Drawing.Color.Black;
            this.btnCrowdLvl.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCrowdLvl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrowdLvl.Font = new System.Drawing.Font("Bernard MT Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrowdLvl.ForeColor = System.Drawing.Color.White;
            this.btnCrowdLvl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrowdLvl.Location = new System.Drawing.Point(12, 23);
            this.btnCrowdLvl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrowdLvl.Name = "btnCrowdLvl";
            this.btnCrowdLvl.Size = new System.Drawing.Size(163, 35);
            this.btnCrowdLvl.TabIndex = 0;
            this.btnCrowdLvl.Text = "Crowd Level";
            this.btnCrowdLvl.UseVisualStyleBackColor = false;
            this.btnCrowdLvl.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MainWinFormApp.Properties.Resources.JJ_LLin_logo_png;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 100);
            this.panel1.TabIndex = 0;
            // 
            // CrowdTab
            // 
            this.CrowdTab.BackgroundImage = global::MainWinFormApp.Properties.Resources.istockphoto_1061119906_612x612;
            this.CrowdTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CrowdTab.Controls.Add(this.label1);
            this.CrowdTab.Location = new System.Drawing.Point(4, 5);
            this.CrowdTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrowdTab.Name = "CrowdTab";
            this.CrowdTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CrowdTab.Size = new System.Drawing.Size(1000, 594);
            this.CrowdTab.TabIndex = 0;
            this.CrowdTab.Text = "CrowdTab";
            this.CrowdTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CrowdTab";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AdminMainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 678);
            this.Controls.Add(this.sideNavPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminMainpage";
            this.Text = "AdminMainpage";
            this.tabControl1.ResumeLayout(false);
            this.PopularityTab.ResumeLayout(false);
            this.PopularityTab.PerformLayout();
            this.MaintenanceTab.ResumeLayout(false);
            this.MaintenanceTab.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.sideNavPanel.ResumeLayout(false);
            this.CrowdTab.ResumeLayout(false);
            this.CrowdTab.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sideNavPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}