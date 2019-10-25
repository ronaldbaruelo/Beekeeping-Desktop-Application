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
    public partial class Beekeeper : MetroFramework.Forms.MetroForm
    {
        IT_Project_DatabaseEntities test2;
        public Beekeeper()
        {
            InitializeComponent();
        }

        private void Beekeeper_Load(object sender, EventArgs e)
        {
            test2 = new IT_Project_DatabaseEntities();
            beekeeperTableBindingSource.DataSource = test2.BeekeeperTables.ToList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtBeeID.Text = " ";

                txtBeeFirst.Text = " ";
                txtBeeLast.Text = " ";
                txtBeePosition.Text = " ";
                txtBeeaddress.Text = " ";
                txtBeephone.Text = " ";
                txtBeeContactName.Text = " ";
                
                txtBeeID.Focus();
                BeekeeperTable s = new BeekeeperTable();
                test2.BeekeeperTables.Add(s);
                beekeeperTableBindingSource.Add(s);
                beekeeperTableBindingSource.MoveLast();


            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "You Username or password is incorrect!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                beekeeperTableBindingSource.EndEdit();
                test2.SaveChangesAsync();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                beekeeperTableBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtBeeID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            beekeeperTableBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in test2.ChangeTracker.Entries())
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

        private void txtBeeSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtBeeSearch.Text))
                {
                    BeeGrid.DataSource = beekeeperTableBindingSource;

                }
                else
                {
                    var query = from o in beekeeperTableBindingSource.DataSource as List<BeekeeperTable>
                                where o.ID == System.Convert.ToInt32(txtBeeSearch.Text) ||  o.Firstname.Contains(txtBeeSearch.Text) ||
                                o.Lastname.Contains(txtBeeSearch.Text) || o.Phone.Contains(txtBeeSearch.Text)
                                select o;
                    BeeGrid.DataSource = query.ToList();
                }
            }
        }

        private void BeeGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are ypu sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    test2.BeekeeperTables.Remove(beekeeperTableBindingSource.Current as BeekeeperTable);
                    beekeeperTableBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Main frm = new frm_Main();
            frm.Visible = true;
        }
    }
}
