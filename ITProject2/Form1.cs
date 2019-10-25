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
    public partial class frm_Main : MetroFramework.Forms.MetroForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTile1.Text = "Site Owner Information";
           
            metroTile4.Text = "Beekeeper Information";
            metroTile4.BackColor = Color.ForestGreen;
            metroTile1.BackColor = Color.MediumAquamarine;
            metroTile2.BackColor = Color.Violet;
            metroTile3.BackColor = Color.SteelBlue;
            metroTile6.BackColor = Color.GreenYellow;

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frmSite frm = new frmSite();
            frm.Visible = true;
            this.Visible = false;
           
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Orchardcs frm = new Orchardcs();
            frm.Visible = true;
            this.Visible = false;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Beekeeper frm = new Beekeeper();
            frm.Visible = true;
            this.Visible = false;
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Harvest frm = new Harvest();
            frm.Visible = true;
            this.Visible = false;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Report frm = new Report();
            frm.Visible = true;
            this.Visible = false;
        }
    }
}
