namespace MainWinFormApp
{
    partial class frmforgetpw
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
            this.lblForgetpw = new System.Windows.Forms.Label();
            this.lblNewpw = new System.Windows.Forms.Label();
            this.lblcfmpw = new System.Windows.Forms.Label();
            this.tbNewpw = new System.Windows.Forms.TextBox();
            this.tbCfmpw = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.lblForgetEmail = new System.Windows.Forms.Label();
            this.tbForgetEmail = new System.Windows.Forms.TextBox();
            this.tbSecQn2Ans = new System.Windows.Forms.TextBox();
            this.tbSecQn1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSecQn2 = new System.Windows.Forms.TextBox();
            this.tbSecQn1Ans = new System.Windows.Forms.TextBox();
            this.btnGetSecQn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForgetpw
            // 
            this.lblForgetpw.AutoSize = true;
            this.lblForgetpw.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblForgetpw.Location = new System.Drawing.Point(125, 38);
            this.lblForgetpw.Name = "lblForgetpw";
            this.lblForgetpw.Size = new System.Drawing.Size(250, 36);
            this.lblForgetpw.TabIndex = 0;
            this.lblForgetpw.Text = "Forget Password";
            this.lblForgetpw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblForgetpw.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNewpw
            // 
            this.lblNewpw.AutoSize = true;
            this.lblNewpw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblNewpw.Location = new System.Drawing.Point(93, 364);
            this.lblNewpw.Name = "lblNewpw";
            this.lblNewpw.Size = new System.Drawing.Size(117, 17);
            this.lblNewpw.TabIndex = 1;
            this.lblNewpw.Text = "New Password:";
            // 
            // lblcfmpw
            // 
            this.lblcfmpw.AutoSize = true;
            this.lblcfmpw.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcfmpw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblcfmpw.Location = new System.Drawing.Point(93, 409);
            this.lblcfmpw.Name = "lblcfmpw";
            this.lblcfmpw.Size = new System.Drawing.Size(145, 17);
            this.lblcfmpw.TabIndex = 2;
            this.lblcfmpw.Text = "Confirm Password:";
            // 
            // tbNewpw
            // 
            this.tbNewpw.BackColor = System.Drawing.Color.Gray;
            this.tbNewpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewpw.Location = new System.Drawing.Point(255, 361);
            this.tbNewpw.Name = "tbNewpw";
            this.tbNewpw.PasswordChar = '*';
            this.tbNewpw.Size = new System.Drawing.Size(224, 20);
            this.tbNewpw.TabIndex = 3;
            // 
            // tbCfmpw
            // 
            this.tbCfmpw.BackColor = System.Drawing.Color.Gray;
            this.tbCfmpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCfmpw.Location = new System.Drawing.Point(255, 406);
            this.tbCfmpw.Name = "tbCfmpw";
            this.tbCfmpw.PasswordChar = '*';
            this.tbCfmpw.Size = new System.Drawing.Size(224, 20);
            this.tbCfmpw.TabIndex = 4;
            // 
            // btnsubmit
            // 
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnsubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnsubmit.Location = new System.Drawing.Point(375, 455);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(104, 43);
            this.btnsubmit.TabIndex = 5;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // lblForgetEmail
            // 
            this.lblForgetEmail.AutoSize = true;
            this.lblForgetEmail.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgetEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.lblForgetEmail.Location = new System.Drawing.Point(93, 93);
            this.lblForgetEmail.Name = "lblForgetEmail";
            this.lblForgetEmail.Size = new System.Drawing.Size(51, 17);
            this.lblForgetEmail.TabIndex = 6;
            this.lblForgetEmail.Text = "Email:";
            // 
            // tbForgetEmail
            // 
            this.tbForgetEmail.BackColor = System.Drawing.Color.Gray;
            this.tbForgetEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbForgetEmail.Location = new System.Drawing.Point(255, 90);
            this.tbForgetEmail.Name = "tbForgetEmail";
            this.tbForgetEmail.Size = new System.Drawing.Size(224, 20);
            this.tbForgetEmail.TabIndex = 7;
            // 
            // tbSecQn2Ans
            // 
            this.tbSecQn2Ans.BackColor = System.Drawing.Color.Gray;
            this.tbSecQn2Ans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSecQn2Ans.Location = new System.Drawing.Point(255, 316);
            this.tbSecQn2Ans.Name = "tbSecQn2Ans";
            this.tbSecQn2Ans.Size = new System.Drawing.Size(224, 20);
            this.tbSecQn2Ans.TabIndex = 11;
            // 
            // tbSecQn1
            // 
            this.tbSecQn1.BackColor = System.Drawing.Color.Gray;
            this.tbSecQn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSecQn1.Location = new System.Drawing.Point(255, 207);
            this.tbSecQn1.Name = "tbSecQn1";
            this.tbSecQn1.ReadOnly = true;
            this.tbSecQn1.Size = new System.Drawing.Size(224, 20);
            this.tbSecQn1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.label1.Location = new System.Drawing.Point(93, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Securtiy Question 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.label2.Location = new System.Drawing.Point(93, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Security Question 1:";
            // 
            // tbSecQn2
            // 
            this.tbSecQn2.BackColor = System.Drawing.Color.Gray;
            this.tbSecQn2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSecQn2.Location = new System.Drawing.Point(255, 284);
            this.tbSecQn2.Name = "tbSecQn2";
            this.tbSecQn2.ReadOnly = true;
            this.tbSecQn2.Size = new System.Drawing.Size(224, 20);
            this.tbSecQn2.TabIndex = 12;
            // 
            // tbSecQn1Ans
            // 
            this.tbSecQn1Ans.BackColor = System.Drawing.Color.Gray;
            this.tbSecQn1Ans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSecQn1Ans.Location = new System.Drawing.Point(255, 242);
            this.tbSecQn1Ans.Name = "tbSecQn1Ans";
            this.tbSecQn1Ans.Size = new System.Drawing.Size(224, 20);
            this.tbSecQn1Ans.TabIndex = 13;
            // 
            // btnGetSecQn
            // 
            this.btnGetSecQn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetSecQn.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnGetSecQn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnGetSecQn.Location = new System.Drawing.Point(96, 129);
            this.btnGetSecQn.Name = "btnGetSecQn";
            this.btnGetSecQn.Size = new System.Drawing.Size(383, 50);
            this.btnGetSecQn.TabIndex = 14;
            this.btnGetSecQn.Text = "Retrieve Sec Qn";
            this.btnGetSecQn.UseVisualStyleBackColor = true;
            this.btnGetSecQn.Click += new System.EventHandler(this.btnGetSecQn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(146)))), ((int)(((byte)(13)))));
            this.btnCancel.Location = new System.Drawing.Point(96, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 43);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmforgetpw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(519, 571);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetSecQn);
            this.Controls.Add(this.tbSecQn1Ans);
            this.Controls.Add(this.tbSecQn2);
            this.Controls.Add(this.tbSecQn2Ans);
            this.Controls.Add(this.tbSecQn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbForgetEmail);
            this.Controls.Add(this.lblForgetEmail);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.tbCfmpw);
            this.Controls.Add(this.tbNewpw);
            this.Controls.Add(this.lblcfmpw);
            this.Controls.Add(this.lblNewpw);
            this.Controls.Add(this.lblForgetpw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmforgetpw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgetpw;
        private System.Windows.Forms.Label lblNewpw;
        private System.Windows.Forms.Label lblcfmpw;
        private System.Windows.Forms.TextBox tbNewpw;
        private System.Windows.Forms.TextBox tbCfmpw;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.Label lblForgetEmail;
        private System.Windows.Forms.TextBox tbForgetEmail;
        private System.Windows.Forms.TextBox tbSecQn2Ans;
        private System.Windows.Forms.TextBox tbSecQn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSecQn2;
        private System.Windows.Forms.TextBox tbSecQn1Ans;
        private System.Windows.Forms.Button btnGetSecQn;
        private System.Windows.Forms.Button btnCancel;
    }
}

