namespace MainWinFormApp
{
    partial class RUDMaintenance
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
            this.lblMaintenanceRecordDetails = new System.Windows.Forms.Label();
            this.lblGameMachineID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tbGameMachineID = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaintenanceRecordDetails
            // 
            this.lblMaintenanceRecordDetails.AutoSize = true;
            this.lblMaintenanceRecordDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintenanceRecordDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblMaintenanceRecordDetails.Location = new System.Drawing.Point(239, 46);
            this.lblMaintenanceRecordDetails.Name = "lblMaintenanceRecordDetails";
            this.lblMaintenanceRecordDetails.Size = new System.Drawing.Size(514, 46);
            this.lblMaintenanceRecordDetails.TabIndex = 0;
            this.lblMaintenanceRecordDetails.Text = "Check Maintenance Record";
            // 
            // lblGameMachineID
            // 
            this.lblGameMachineID.AutoSize = true;
            this.lblGameMachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMachineID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblGameMachineID.Location = new System.Drawing.Point(186, 135);
            this.lblGameMachineID.Name = "lblGameMachineID";
            this.lblGameMachineID.Size = new System.Drawing.Size(166, 24);
            this.lblGameMachineID.TabIndex = 1;
            this.lblGameMachineID.Text = "Game Machine ID:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblDate.Location = new System.Drawing.Point(186, 183);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(188, 24);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date (YYYY-MM-DD):";
            // 
            // tbGameMachineID
            // 
            this.tbGameMachineID.BackColor = System.Drawing.Color.Gray;
            this.tbGameMachineID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGameMachineID.Location = new System.Drawing.Point(392, 136);
            this.tbGameMachineID.Name = "tbGameMachineID";
            this.tbGameMachineID.Size = new System.Drawing.Size(146, 22);
            this.tbGameMachineID.TabIndex = 3;
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.Color.Gray;
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDate.Location = new System.Drawing.Point(392, 185);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(206, 22);
            this.tbDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.label1.Location = new System.Drawing.Point(344, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Record Details";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblCost.Location = new System.Drawing.Point(186, 334);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(166, 24);
            this.lblCost.TabIndex = 6;
            this.lblCost.Text = "Maintenance Cost:";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblRemarks.Location = new System.Drawing.Point(186, 383);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(89, 24);
            this.lblRemarks.TabIndex = 7;
            this.lblRemarks.Text = "Remarks:";
            // 
            // tbCost
            // 
            this.tbCost.BackColor = System.Drawing.Color.Gray;
            this.tbCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCost.Location = new System.Drawing.Point(392, 334);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(113, 22);
            this.tbCost.TabIndex = 8;
            // 
            // tbRemarks
            // 
            this.tbRemarks.BackColor = System.Drawing.Color.Gray;
            this.tbRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRemarks.Location = new System.Drawing.Point(392, 383);
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(324, 22);
            this.tbRemarks.TabIndex = 9;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnRetrieve.Location = new System.Drawing.Point(717, 136);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(157, 58);
            this.btnRetrieve.TabIndex = 10;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnModify.Location = new System.Drawing.Point(167, 467);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(157, 58);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modify ";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnDelete.Location = new System.Drawing.Point(412, 467);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(157, 58);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnExit.Location = new System.Drawing.Point(650, 467);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 58);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RUDMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(961, 587);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.tbRemarks);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbGameMachineID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblGameMachineID);
            this.Controls.Add(this.lblMaintenanceRecordDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RUDMaintenance";
            this.Text = "RUDMaintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaintenanceRecordDetails;
        private System.Windows.Forms.Label lblGameMachineID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox tbGameMachineID;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}