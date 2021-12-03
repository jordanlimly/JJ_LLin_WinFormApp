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
            this.btnCrowdLvl = new System.Windows.Forms.Button();
            this.btnPopularity = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CrowdTab = new System.Windows.Forms.TabPage();
            this.PopularityTab = new System.Windows.Forms.TabPage();
            this.MaintenanceTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.CrowdTab.SuspendLayout();
            this.PopularityTab.SuspendLayout();
            this.MaintenanceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrowdLvl
            // 
            this.btnCrowdLvl.Location = new System.Drawing.Point(1, 89);
            this.btnCrowdLvl.Name = "btnCrowdLvl";
            this.btnCrowdLvl.Size = new System.Drawing.Size(161, 51);
            this.btnCrowdLvl.TabIndex = 0;
            this.btnCrowdLvl.Text = "Crowd Level";
            this.btnCrowdLvl.UseVisualStyleBackColor = true;
            this.btnCrowdLvl.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPopularity
            // 
            this.btnPopularity.Location = new System.Drawing.Point(1, 146);
            this.btnPopularity.Name = "btnPopularity";
            this.btnPopularity.Size = new System.Drawing.Size(161, 51);
            this.btnPopularity.TabIndex = 1;
            this.btnPopularity.Text = "Game Popularity";
            this.btnPopularity.UseVisualStyleBackColor = true;
            this.btnPopularity.Click += new System.EventHandler(this.btnPopularity_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Location = new System.Drawing.Point(1, 203);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(161, 51);
            this.btnMaintenance.TabIndex = 2;
            this.btnMaintenance.Text = "Maintenance";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(1, 260);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(161, 51);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.CrowdTab);
            this.tabControl1.Controls.Add(this.PopularityTab);
            this.tabControl1.Controls.Add(this.MaintenanceTab);
            this.tabControl1.ItemSize = new System.Drawing.Size(150, 31);
            this.tabControl1.Location = new System.Drawing.Point(164, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(851, 576);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            // 
            // CrowdTab
            // 
            this.CrowdTab.Controls.Add(this.label1);
            this.CrowdTab.Location = new System.Drawing.Point(4, 35);
            this.CrowdTab.Name = "CrowdTab";
            this.CrowdTab.Padding = new System.Windows.Forms.Padding(3);
            this.CrowdTab.Size = new System.Drawing.Size(843, 537);
            this.CrowdTab.TabIndex = 0;
            this.CrowdTab.Text = "CrowdTab";
            this.CrowdTab.UseVisualStyleBackColor = true;
            // 
            // PopularityTab
            // 
            this.PopularityTab.Controls.Add(this.label2);
            this.PopularityTab.Location = new System.Drawing.Point(4, 35);
            this.PopularityTab.Name = "PopularityTab";
            this.PopularityTab.Padding = new System.Windows.Forms.Padding(3);
            this.PopularityTab.Size = new System.Drawing.Size(843, 537);
            this.PopularityTab.TabIndex = 1;
            this.PopularityTab.Text = "PopularityTab";
            this.PopularityTab.UseVisualStyleBackColor = true;
            // 
            // MaintenanceTab
            // 
            this.MaintenanceTab.Controls.Add(this.label3);
            this.MaintenanceTab.Location = new System.Drawing.Point(4, 35);
            this.MaintenanceTab.Name = "MaintenanceTab";
            this.MaintenanceTab.Size = new System.Drawing.Size(843, 537);
            this.MaintenanceTab.TabIndex = 2;
            this.MaintenanceTab.Text = "MaintenanceTab";
            this.MaintenanceTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CrowdTab";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "PopularityTab";
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
            // AdminMainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 576);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMaintenance);
            this.Controls.Add(this.btnPopularity);
            this.Controls.Add(this.btnCrowdLvl);
            this.Name = "AdminMainpage";
            this.Text = "AdminMainpage";
            this.tabControl1.ResumeLayout(false);
            this.CrowdTab.ResumeLayout(false);
            this.CrowdTab.PerformLayout();
            this.PopularityTab.ResumeLayout(false);
            this.PopularityTab.PerformLayout();
            this.MaintenanceTab.ResumeLayout(false);
            this.MaintenanceTab.PerformLayout();
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
    }
}