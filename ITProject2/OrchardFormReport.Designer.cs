namespace ITProject2
{
    partial class OrchardFormReport
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
            this.CrystalOrchardViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.OrchardReport1 = new ITProject2.OrchardReport();
            this.SuspendLayout();
            // 
            // CrystalOrchardViewer
            // 
            this.CrystalOrchardViewer.ActiveViewIndex = -1;
            this.CrystalOrchardViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrystalOrchardViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CrystalOrchardViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CrystalOrchardViewer.Location = new System.Drawing.Point(20, 60);
            this.CrystalOrchardViewer.Name = "CrystalOrchardViewer";
            this.CrystalOrchardViewer.Size = new System.Drawing.Size(1056, 715);
            this.CrystalOrchardViewer.TabIndex = 0;
            this.CrystalOrchardViewer.Load += new System.EventHandler(this.CrystalOrchardViewer_Load);
            // 
            // OrchardReport1
            // 
            this.OrchardReport1.InitReport += new System.EventHandler(this.OrchardReport1_InitReport);
            // 
            // OrchardFormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 795);
            this.Controls.Add(this.CrystalOrchardViewer);
            this.Name = "OrchardFormReport";
            this.Text = "OrchardFormReport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrchardFormReport_FormClosed);
            this.Load += new System.EventHandler(this.OrchardFormReport_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalOrchardViewer;
        private OrchardReport OrchardReport1;
    }
}