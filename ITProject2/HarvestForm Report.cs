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
    public partial class HarvestFormReport : MetroFramework.Forms.MetroForm
    {
        public HarvestFormReport()
        {
            InitializeComponent();
        }

        private void HarvestForm_Report_Load(object sender, EventArgs e)
        {
            IT_Project_DatabaseEntities db = new IT_Project_DatabaseEntities();
            CrystalHarvestReport1 cr = new CrystalHarvestReport1();
            cr.SetDataSource(db.HarvestTables.ToList());
            crystalReportHarvestViewer.ReportSource = cr;
        }

        private void HarvestFormReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Report frm = new Report();
            frm.Visible = true;
        }
    }
}
