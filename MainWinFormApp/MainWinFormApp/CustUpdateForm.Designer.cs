namespace MainWinFormApp
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbuCardID = new System.Windows.Forms.TextBox();
            this.lblSecurityQn = new System.Windows.Forms.Label();
            this.combSQ1 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSQ1 = new System.Windows.Forms.TextBox();
            this.tbSQ2 = new System.Windows.Forms.TextBox();
            this.combSQ2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCardID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Gray;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(299, 108);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(197, 20);
            this.tbName.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Gray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Location = new System.Drawing.Point(299, 154);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(196, 20);
            this.textBox5.TabIndex = 4;
            // 
            // tbuCardID
            // 
            this.tbuCardID.BackColor = System.Drawing.Color.Gray;
            this.tbuCardID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbuCardID.Location = new System.Drawing.Point(299, 200);
            this.tbuCardID.Margin = new System.Windows.Forms.Padding(2);
            this.tbuCardID.Name = "tbuCardID";
            this.tbuCardID.ReadOnly = true;
            this.tbuCardID.Size = new System.Drawing.Size(197, 20);
            this.tbuCardID.TabIndex = 5;
            // 
            // lblSecurityQn
            // 
            this.lblSecurityQn.AutoSize = true;
            this.lblSecurityQn.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblSecurityQn.Location = new System.Drawing.Point(131, 252);
            this.lblSecurityQn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecurityQn.Name = "lblSecurityQn";
            this.lblSecurityQn.Size = new System.Drawing.Size(152, 17);
            this.lblSecurityQn.TabIndex = 6;
            this.lblSecurityQn.Text = "Security Question 1:";
            // 
            // combSQ1
            // 
            this.combSQ1.BackColor = System.Drawing.Color.Gray;
            this.combSQ1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSQ1.FormattingEnabled = true;
            this.combSQ1.Items.AddRange(new object[] {
            "What is your mother\'s maiden name?",
            "What is your childhood nickname?",
            "What primary school/secondary school did you go to?",
            "What is your PC model?"});
            this.combSQ1.Location = new System.Drawing.Point(298, 248);
            this.combSQ1.Margin = new System.Windows.Forms.Padding(2);
            this.combSQ1.Name = "combSQ1";
            this.combSQ1.Size = new System.Drawing.Size(197, 21);
            this.combSQ1.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnCancel.Location = new System.Drawing.Point(346, 455);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnSubmit.Location = new System.Drawing.Point(134, 455);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 43);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.label1.Location = new System.Drawing.Point(171, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "Update Particulars ";
            // 
            // tbSQ1
            // 
            this.tbSQ1.BackColor = System.Drawing.Color.Gray;
            this.tbSQ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSQ1.Location = new System.Drawing.Point(298, 287);
            this.tbSQ1.Margin = new System.Windows.Forms.Padding(2);
            this.tbSQ1.Name = "tbSQ1";
            this.tbSQ1.Size = new System.Drawing.Size(197, 20);
            this.tbSQ1.TabIndex = 16;
            // 
            // tbSQ2
            // 
            this.tbSQ2.BackColor = System.Drawing.Color.Gray;
            this.tbSQ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSQ2.Location = new System.Drawing.Point(298, 376);
            this.tbSQ2.Margin = new System.Windows.Forms.Padding(2);
            this.tbSQ2.Name = "tbSQ2";
            this.tbSQ2.Size = new System.Drawing.Size(197, 20);
            this.tbSQ2.TabIndex = 19;
            // 
            // combSQ2
            // 
            this.combSQ2.BackColor = System.Drawing.Color.Gray;
            this.combSQ2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combSQ2.FormattingEnabled = true;
            this.combSQ2.Items.AddRange(new object[] {
            "What is your father\'s name?",
            "What is your sibling\'s name(any)?",
            "Are you a pet owner?",
            "What is your favourite teacher\'s name?"});
            this.combSQ2.Location = new System.Drawing.Point(298, 337);
            this.combSQ2.Margin = new System.Windows.Forms.Padding(2);
            this.combSQ2.Name = "combSQ2";
            this.combSQ2.Size = new System.Drawing.Size(197, 21);
            this.combSQ2.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.label2.Location = new System.Drawing.Point(131, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Security Question 2:";
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblCardID.Location = new System.Drawing.Point(131, 203);
            this.lblCardID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(68, 17);
            this.lblCardID.TabIndex = 20;
            this.lblCardID.Text = "Card ID:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblEmail.Location = new System.Drawing.Point(131, 157);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 21;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblName.Location = new System.Drawing.Point(131, 111);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 17);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Name:";
            // 
            // CustUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(592, 577);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.tbSQ2);
            this.Controls.Add(this.combSQ2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSQ1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.combSQ1);
            this.Controls.Add(this.lblSecurityQn);
            this.Controls.Add(this.tbuCardID);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustUpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbuCardID;
        private System.Windows.Forms.Label lblSecurityQn;
        private System.Windows.Forms.ComboBox combSQ1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSQ1;
        private System.Windows.Forms.TextBox tbSQ2;
        private System.Windows.Forms.ComboBox combSQ2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
    }
}