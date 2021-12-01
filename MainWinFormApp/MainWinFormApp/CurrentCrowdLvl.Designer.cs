namespace MainWinFormApp
{
    partial class frmCurrentCrowd
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
            this.lblCurrentCrowd = new System.Windows.Forms.Label();
            this.lbDataComms = new System.Windows.Forms.ListBox();
            this.lbCurCrowdCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCurrentCrowd
            // 
            this.lblCurrentCrowd.AutoSize = true;
            this.lblCurrentCrowd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCrowd.Location = new System.Drawing.Point(18, 162);
            this.lblCurrentCrowd.Name = "lblCurrentCrowd";
            this.lblCurrentCrowd.Size = new System.Drawing.Size(290, 46);
            this.lblCurrentCrowd.TabIndex = 1;
            this.lblCurrentCrowd.Text = "Current Crowd:";
            // 
            // lbDataComms
            // 
            this.lbDataComms.FormattingEnabled = true;
            this.lbDataComms.ItemHeight = 20;
            this.lbDataComms.Location = new System.Drawing.Point(328, 378);
            this.lbDataComms.Name = "lbDataComms";
            this.lbDataComms.Size = new System.Drawing.Size(682, 304);
            this.lbDataComms.TabIndex = 2;
            // 
            // lbCurCrowdCount
            // 
            this.lbCurCrowdCount.AutoSize = true;
            this.lbCurCrowdCount.Location = new System.Drawing.Point(363, 183);
            this.lbCurCrowdCount.Name = "lbCurCrowdCount";
            this.lbCurCrowdCount.Size = new System.Drawing.Size(18, 20);
            this.lbCurCrowdCount.TabIndex = 3;
            this.lbCurCrowdCount.Text = "0";
            // 
            // frmCurrentCrowd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 768);
            this.Controls.Add(this.lbCurCrowdCount);
            this.Controls.Add(this.lbDataComms);
            this.Controls.Add(this.lblCurrentCrowd);
            this.Name = "frmCurrentCrowd";
            this.Text = "CurrentCrowdLvl";
            this.Load += new System.EventHandler(this.frmCurrentCrowd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCurrentCrowd;
        private System.Windows.Forms.ListBox lbDataComms;
        private System.Windows.Forms.Label lbCurCrowdCount;
    }
}