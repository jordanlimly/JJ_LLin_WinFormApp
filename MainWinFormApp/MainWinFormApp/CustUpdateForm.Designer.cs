﻿namespace MainWinFormApp
{
    partial class CustUpdateForm
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
            this.lblName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.TextBox();
            this.lblCardID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblSecurityQn = new System.Windows.Forms.Label();
            this.combSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.Location = new System.Drawing.Point(195, 137);
            this.lblName.Name = "lblName";
            this.lblName.ReadOnly = true;
            this.lblName.Size = new System.Drawing.Size(120, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEmail.Location = new System.Drawing.Point(195, 194);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.ReadOnly = true;
            this.lblEmail.Size = new System.Drawing.Size(58, 19);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // lblCardID
            // 
            this.lblCardID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCardID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCardID.Location = new System.Drawing.Point(195, 250);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.ReadOnly = true;
            this.lblCardID.Size = new System.Drawing.Size(58, 19);
            this.lblCardID.TabIndex = 2;
            this.lblCardID.Text = "Card ID:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(293, 134);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(170, 22);
            this.tbName.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(293, 194);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(170, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(293, 250);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(170, 22);
            this.textBox6.TabIndex = 5;
            // 
            // lblSecurityQn
            // 
            this.lblSecurityQn.AutoSize = true;
            this.lblSecurityQn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSecurityQn.Location = new System.Drawing.Point(191, 312);
            this.lblSecurityQn.Name = "lblSecurityQn";
            this.lblSecurityQn.Size = new System.Drawing.Size(147, 20);
            this.lblSecurityQn.TabIndex = 6;
            this.lblSecurityQn.Text = "Security Question:";
            // 
            // combSecurityQuestion
            // 
            this.combSecurityQuestion.FormattingEnabled = true;
            this.combSecurityQuestion.Location = new System.Drawing.Point(360, 312);
            this.combSecurityQuestion.Name = "combSecurityQuestion";
            this.combSecurityQuestion.Size = new System.Drawing.Size(261, 24);
            this.combSecurityQuestion.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(462, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(160, 49);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(180, 371);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(160, 49);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 46);
            this.label1.TabIndex = 15;
            this.label1.Text = "Update Particulars ";
            // 
            // CustUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.combSecurityQuestion);
            this.Controls.Add(this.lblSecurityQn);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Name = "CustUpdateForm";
            this.Text = "CustUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblName;
        private System.Windows.Forms.TextBox lblEmail;
        private System.Windows.Forms.TextBox lblCardID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblSecurityQn;
        private System.Windows.Forms.ComboBox combSecurityQuestion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
    }
}