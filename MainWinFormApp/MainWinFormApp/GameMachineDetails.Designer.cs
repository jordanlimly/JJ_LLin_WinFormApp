namespace MainWinFormApp
{
    partial class GameMachineDetails
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
            this.lblGameMachineDetails = new System.Windows.Forms.Label();
            this.lblGMachineID = new System.Windows.Forms.Label();
            this.lblGMachineName = new System.Windows.Forms.Label();
            this.tbGMachineID = new System.Windows.Forms.TextBox();
            this.tbGMachineName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameMachineDetails
            // 
            this.lblGameMachineDetails.AutoSize = true;
            this.lblGameMachineDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameMachineDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblGameMachineDetails.Location = new System.Drawing.Point(197, 48);
            this.lblGameMachineDetails.Name = "lblGameMachineDetails";
            this.lblGameMachineDetails.Size = new System.Drawing.Size(423, 46);
            this.lblGameMachineDetails.TabIndex = 0;
            this.lblGameMachineDetails.Text = "Game Machine Details";
            // 
            // lblGMachineID
            // 
            this.lblGMachineID.AutoSize = true;
            this.lblGMachineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMachineID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblGMachineID.Location = new System.Drawing.Point(155, 144);
            this.lblGMachineID.Name = "lblGMachineID";
            this.lblGMachineID.Size = new System.Drawing.Size(166, 24);
            this.lblGMachineID.TabIndex = 1;
            this.lblGMachineID.Text = "Game Machine ID:";
            // 
            // lblGMachineName
            // 
            this.lblGMachineName.AutoSize = true;
            this.lblGMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGMachineName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblGMachineName.Location = new System.Drawing.Point(155, 196);
            this.lblGMachineName.Name = "lblGMachineName";
            this.lblGMachineName.Size = new System.Drawing.Size(200, 24);
            this.lblGMachineName.TabIndex = 2;
            this.lblGMachineName.Text = "Game Machine Name:";
            // 
            // tbGMachineID
            // 
            this.tbGMachineID.BackColor = System.Drawing.Color.Gray;
            this.tbGMachineID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGMachineID.Location = new System.Drawing.Point(407, 144);
            this.tbGMachineID.Name = "tbGMachineID";
            this.tbGMachineID.Size = new System.Drawing.Size(117, 22);
            this.tbGMachineID.TabIndex = 3;
            // 
            // tbGMachineName
            // 
            this.tbGMachineName.BackColor = System.Drawing.Color.Gray;
            this.tbGMachineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGMachineName.Location = new System.Drawing.Point(407, 198);
            this.tbGMachineName.Name = "tbGMachineName";
            this.tbGMachineName.Size = new System.Drawing.Size(262, 22);
            this.tbGMachineName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnAdd.Location = new System.Drawing.Point(436, 257);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 58);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnCancel.Location = new System.Drawing.Point(208, 257);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(157, 58);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GameMachineDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(818, 363);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbGMachineName);
            this.Controls.Add(this.tbGMachineID);
            this.Controls.Add(this.lblGMachineName);
            this.Controls.Add(this.lblGMachineID);
            this.Controls.Add(this.lblGameMachineDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMachineDetails";
            this.Text = "GameMachineDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameMachineDetails;
        private System.Windows.Forms.Label lblGMachineID;
        private System.Windows.Forms.Label lblGMachineName;
        private System.Windows.Forms.TextBox tbGMachineID;
        private System.Windows.Forms.TextBox tbGMachineName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}