using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITProject2
{
    public partial class SiteFormReport : MetroFramework.Forms.MetroForm

    {
       
        public SiteFormReport()
        {
            InitializeComponent();
           
        }

        private void frmSiteReport_Load(object sender, EventArgs e)
        {
                IT_Project_DatabaseEntities db = new IT_Project_DatabaseEntities();
                CrystalReportSite cr = new CrystalReportSite();
                cr.SetDataSource(db.GetSiteOwner().ToList());
                crystalReportViewer1.ReportSource = cr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void SiteFormReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Report frm = new Report();
            frm.Visible = true;
        }
    }
}
