namespace ITProject2
{
    partial class HarvestFormReport
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
            this.crystalReportHarvestViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalHarvestReport11 = new ITProject2.CrystalHarvestReport1();
            this.SuspendLayout();
            // 
            // crystalReportHarvestViewer
            // 
            this.crystalReportHarvestViewer.ActiveViewIndex = 0;
            this.crystalReportHarvestViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportHarvestViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportHarvestViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportHarvestViewer.Location = new System.Drawing.Point(20, 60);
            this.crystalReportHarvestViewer.Name = "crystalReportHarvestViewer";
            this.crystalReportHarvestViewer.ReportSource = this.CrystalHarvestReport11;
            this.crystalReportHarvestViewer.Size = new System.Drawing.Size(1103, 642);
            this.crystalReportHarvestViewer.TabIndex = 0;
            // 
            // HarvestFormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 722);
            this.Controls.Add(this.crystalReportHarvestViewer);
            this.Name = "HarvestFormReport";
            this.Text = "Harvest Report";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HarvestFormReport_FormClosed);
            this.Load += new System.EventHandler(this.HarvestForm_Report_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportHarvestViewer;
        private CrystalHarvestReport1 CrystalHarvestReport11;
    }
}