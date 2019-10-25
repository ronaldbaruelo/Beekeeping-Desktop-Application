using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITProject2
{
    public partial class Harvest : MetroFramework.Forms.MetroForm
    {
        IT_Project_DatabaseEntities test3;

        public Harvest()
        {
            InitializeComponent();
        }

        private void Harvest_Load(object sender, EventArgs e)
        {
            test3 = new IT_Project_DatabaseEntities();
            harvestTableBindingSource.DataSource = test3.HarvestTables.ToList();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {

                txtHarvestID.Text = " ";
                txtHarvestMaf.Text = " ";
                txtHarvestSitename.Text = " ";
                txtharvestSiteID.Focus();
                HarvestTable s = new HarvestTable();
                test3.HarvestTables.Add(s);
                harvestTableBindingSource.Add(s);
                harvestTableBindingSource.MoveLast();


            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "You Username or password is incorrect!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtHarvestname_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void txtHarvestBeekeeper_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                harvestTableBindingSource.EndEdit();
                test3.SaveChangesAsync();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                harvestTableBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtHarvestID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            harvestTableBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in test3.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Deleted:
                        entry.Reload();
                        break;

                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Main frm = new frm_Main();
            frm.Visible = true;
        }

        private void txtHarvestSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtHarvestSearch.Text))
                {
                    metroGrid1.DataSource = harvestTableBindingSource;

                }
                else
                {
                    var query = from o in harvestTableBindingSource.DataSource as List<HarvestTable>
                                where o.SiteID == System.Convert.ToInt32(txtHarvestSearch.Text) || o.MafID == System.Convert.ToInt32(txtharvestSiteID.Text) || o.Sitename.Contains(txtHarvestSearch.Text) ||
                                o.Type.Contains(txtHarvestSearch.Text) || o.weight == System.Convert.ToInt32(txtHarvestSearch.Text)
                                select o;
                    metroGrid1.DataSource = query.ToList();
                }
            }
        }

        private void metroGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are ypu sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    test3.HarvestTables.Remove(harvestTableBindingSource.Current as HarvestTable);
                    harvestTableBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
