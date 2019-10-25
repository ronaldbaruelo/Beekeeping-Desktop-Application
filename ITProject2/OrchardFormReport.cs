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
    public partial class OrchardFormReport : MetroFramework.Forms.MetroForm
    {
        public OrchardFormReport()
        {
            InitializeComponent();
        }

        private void OrchardFormReport_Load(object sender, EventArgs e)
        {
            IT_Project_DatabaseEntities db = new IT_Project_DatabaseEntities();
            OrchardReport cr = new OrchardReport();
            cr.SetDataSource(db.GetOrchardOwner().ToList());
            CrystalOrchardViewer.ReportSource = cr;
        }

        private void crystalReportViewerOrchard_Load(object sender, EventArgs e)
        {

        }

        private void OrchardReport1_InitReport(object sender, EventArgs e)
        {

        }

        private void CrystalOrchardViewer_Load(object sender, EventArgs e)
        {

        }

        private void OrchardFormReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            Report frm = new Report();
            frm.Visible = true;
        }
    }
}
