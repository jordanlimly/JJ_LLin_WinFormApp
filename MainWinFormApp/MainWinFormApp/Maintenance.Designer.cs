namespace MainWinFormApp
{
    partial class frmMaintenance
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
            this.lbl_maintenance = new System.Windows.Forms.Label();
            this.lbl_machineID = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_remarks = new System.Windows.Forms.Label();
            this.tbMachineID = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_maintenance
            // 
            this.lbl_maintenance.AutoSize = true;
            this.lbl_maintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maintenance.Location = new System.Drawing.Point(107, 31);
            this.lbl_maintenance.Name = "lbl_maintenance";
            this.lbl_maintenance.Size = new System.Drawing.Size(540, 46);
            this.lbl_maintenance.TabIndex = 0;
            this.lbl_maintenance.Text = "Game Machine Maintenance ";
            // 
            // lbl_machineID
            // 
            this.lbl_machineID.AutoSize = true;
            this.lbl_machineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_machineID.Location = new System.Drawing.Point(103, 136);
            this.lbl_machineID.Name = "lbl_machineID";
            this.lbl_machineID.Size = new System.Drawing.Size(166, 24);
            this.lbl_machineID.TabIndex = 2;
            this.lbl_machineID.Text = "Game Machine ID:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(103, 182);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(188, 24);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Date (YYYY-MM-DD):";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.Location = new System.Drawing.Point(103, 223);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(52, 24);
            this.lbl_cost.TabIndex = 4;
            this.lbl_cost.Text = "Cost:";
            // 
            // lbl_remarks
            // 
            this.lbl_remarks.AutoSize = true;
            this.lbl_remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remarks.Location = new System.Drawing.Point(103, 263);
            this.lbl_remarks.Name = "lbl_remarks";
            this.lbl_remarks.Size = new System.Drawing.Size(89, 24);
            this.lbl_remarks.TabIndex = 5;
            this.lbl_remarks.Text = "Remarks:";
            // 
            // tbMachineID
            // 
            this.tbMachineID.Location = new System.Drawing.Point(331, 138);
            this.tbMachineID.Name = "tbMachineID";
            this.tbMachineID.Size = new System.Drawing.Size(129, 22);
            this.tbMachineID.TabIndex = 6;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(331, 184);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(187, 22);
            this.tbDate.TabIndex = 7;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(331, 225);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(129, 22);
            this.tbCost.TabIndex = 8;
            this.tbCost.TextChanged += new System.EventHandler(this.tbCost_TextChanged);
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(331, 265);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(351, 22);
            this.tbRemarks.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(280, 352);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(157, 58);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 475);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbRemarks);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbMachineID);
            this.Controls.Add(this.lbl_remarks);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_machineID);
            this.Controls.Add(this.lbl_maintenance);
            this.Name = "frmMaintenance";
            this.Text = "MaintenanceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_maintenance;
        private System.Windows.Forms.Label lbl_machineID;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_remarks;
        private System.Windows.Forms.TextBox tbMachineID;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Button btnSubmit;
    }
}