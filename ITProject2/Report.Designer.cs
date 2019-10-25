namespace ITProject2
{
    partial class Report
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReportClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSiteReport = new System.Windows.Forms.Button();
            this.btnOrchardrep = new System.Windows.Forms.Button();
            this.btnHarvestRep = new System.Windows.Forms.Button();
            this.bnBeekeeperRep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Select reports:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReportClose
            // 
            this.btnReportClose.Location = new System.Drawing.Point(343, 351);
            this.btnReportClose.Name = "btnReportClose";
            this.btnReportClose.Size = new System.Drawing.Size(75, 23);
            this.btnReportClose.TabIndex = 2;
            this.btnReportClose.Text = "&CLOSE";
            this.btnReportClose.UseVisualStyleBackColor = true;
            this.btnReportClose.Click += new System.EventHandler(this.btnReportClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ITProject2.Properties.Resources.report_icon_13332_Windows;
            this.pictureBox1.Location = new System.Drawing.Point(47, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSiteReport
            // 
            this.btnSiteReport.Location = new System.Drawing.Point(134, 181);
            this.btnSiteReport.Name = "btnSiteReport";
            this.btnSiteReport.Size = new System.Drawing.Size(179, 23);
            this.btnSiteReport.TabIndex = 4;
            this.btnSiteReport.Text = "Site Owner Masterlist ";
            this.btnSiteReport.UseVisualStyleBackColor = true;
            this.btnSiteReport.Click += new System.EventHandler(this.btnSiteReport_Click);
            // 
            // btnOrchardrep
            // 
            this.btnOrchardrep.Location = new System.Drawing.Point(134, 222);
            this.btnOrchardrep.Name = "btnOrchardrep";
            this.btnOrchardrep.Size = new System.Drawing.Size(179, 23);
            this.btnOrchardrep.TabIndex = 5;
            this.btnOrchardrep.Text = "Orchard Owner Masterlist";
            this.btnOrchardrep.UseVisualStyleBackColor = true;
            this.btnOrchardrep.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHarvestRep
            // 
            this.btnHarvestRep.Location = new System.Drawing.Point(134, 303);
            this.btnHarvestRep.Name = "btnHarvestRep";
            this.btnHarvestRep.Size = new System.Drawing.Size(179, 23);
            this.btnHarvestRep.TabIndex = 6;
            this.btnHarvestRep.Text = "Harvest Report";
            this.btnHarvestRep.UseVisualStyleBackColor = true;
            this.btnHarvestRep.Click += new System.EventHandler(this.btnHarvestRep_Click);
            // 
            // bnBeekeeperRep
            // 
            this.bnBeekeeperRep.Location = new System.Drawing.Point(134, 264);
            this.bnBeekeeperRep.Name = "bnBeekeeperRep";
            this.bnBeekeeperRep.Size = new System.Drawing.Size(179, 23);
            this.bnBeekeeperRep.TabIndex = 7;
            this.bnBeekeeperRep.Text = "Beekeeper Masterlist";
            this.bnBeekeeperRep.UseVisualStyleBackColor = true;
            this.bnBeekeeperRep.Click += new System.EventHandler(this.bnBeekeeperRep_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 397);
            this.Controls.Add(this.bnBeekeeperRep);
            this.Controls.Add(this.btnHarvestRep);
            this.Controls.Add(this.btnOrchardrep);
            this.Controls.Add(this.btnSiteReport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReportClose);
            this.Controls.Add(this.label1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReportClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSiteReport;
        private System.Windows.Forms.Button btnOrchardrep;
        private System.Windows.Forms.Button btnHarvestRep;
        private System.Windows.Forms.Button bnBeekeeperRep;
    }
}