namespace ITProject2
{
    partial class BeekeeperReportcs
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
            this.crystalBeekeeperReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalBeekeeperReport1 = new ITProject2.CrystalBeekeeperReport();
            this.SuspendLayout();
            // 
            // crystalBeekeeperReportViewer
            // 
            this.crystalBeekeeperReportViewer.ActiveViewIndex = 0;
            this.crystalBeekeeperReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalBeekeeperReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalBeekeeperReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalBeekeeperReportViewer.Location = new System.Drawing.Point(20, 60);
            this.crystalBeekeeperReportViewer.Name = "crystalBeekeeperReportViewer";
            this.crystalBeekeeperReportViewer.ReportSource = this.CrystalBeekeeperReport1;
            this.crystalBeekeeperReportViewer.Size = new System.Drawing.Size(1051, 697);
            this.crystalBeekeeperReportViewer.TabIndex = 0;
            // 
            // BeekeeperReportcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 777);
            this.Controls.Add(this.crystalBeekeeperReportViewer);
            this.Name = "BeekeeperReportcs";
            this.Text = "Beekeeper Masterlist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BeekeeperReportcs_FormClosed);
            this.Load += new System.EventHandler(this.BeekeeperReportcs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalBeekeeperReportViewer;
        private CrystalBeekeeperReport CrystalBeekeeperReport1;
    }
}