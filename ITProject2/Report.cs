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
    public partial class Report : MetroFramework.Forms.MetroForm
    {

       

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSiteReport_Click(object sender, EventArgs e)
        {
            SiteFormReport frm = new SiteFormReport();
            frm.Visible = true;
            this.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrchardFormReport frm = new OrchardFormReport();
            frm.Visible = true;
            this.Visible = false;
        }

        private void bnBeekeeperRep_Click(object sender, EventArgs e)
        {
            BeekeeperReportcs frm = new BeekeeperReportcs();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnHarvestRep_Click(object sender, EventArgs e)
        {
            HarvestFormReport frm = new HarvestFormReport();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnReportClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Main frm = new frm_Main();
            frm.Visible = true;
        }
    }
}
