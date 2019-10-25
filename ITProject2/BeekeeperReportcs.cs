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
    public partial class BeekeeperReportcs : MetroFramework.Forms.MetroForm
    {
        public BeekeeperReportcs()
        {
            InitializeComponent();
        }

        private void BeekeeperReportcs_Load(object sender, EventArgs e)
        {
            IT_Project_DatabaseEntities db = new IT_Project_DatabaseEntities();
            CrystalBeekeeperReport cr = new CrystalBeekeeperReport();
            cr.SetDataSource(db.GetBeekeeperMasterlist().ToList());
            crystalBeekeeperReportViewer.ReportSource = cr;
        }

        private void BeekeeperReportcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Report frm = new Report();
            frm.Visible = true;
        }
    }
}
