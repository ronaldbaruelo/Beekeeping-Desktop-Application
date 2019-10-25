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
    public partial class Orchardcs : MetroFramework.Forms.MetroForm
    {
        IT_Project_DatabaseEntities test1;

        public Orchardcs()
        {
            InitializeComponent();
        }

        private void Orchardcs_Load(object sender, EventArgs e)
        {
            test1 = new IT_Project_DatabaseEntities();
            orchardTableBindingSource.DataSource = test1.OrchardTables.ToList();
        }

        private void btnOrchardNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtOrchardID.Text = " ";
                txtOrchardFirst.Text = " ";
                txtOrchardLast.Text = " ";
                txtOrchardname.Text = " ";
                txtOrchardaddress.Text = " ";
                txtOrchardphone.Text = " ";
                txtOrchardID.Focus();
                OrchardTable s1 = new OrchardTable();
                test1.OrchardTables.Add(s1);
                orchardTableBindingSource.Add(s1);
                orchardTableBindingSource.MoveLast();


            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "You Username or password is incorrect!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnOrchardSave_Click(object sender, EventArgs e)
        {
            try
            {
                orchardTableBindingSource.EndEdit();
                test1.SaveChangesAsync();
                MetroFramework.MetroMessageBox.Show(this, "Message Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                orchardTableBindingSource.ResetBindings(false);
            }
        }

        private void btnOrhardEdit_Click(object sender, EventArgs e)
        {
            txtOrchardID.Focus();
        }

        private void btnOrchardDelete_Click(object sender, EventArgs e)
        {
            orchardTableBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in test1.ChangeTracker.Entries())
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

        private void txtOrchardSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtOrchardSearch.Text))
                {
                    OrchardGrid.DataSource = orchardTableBindingSource;

                }
                else
                {
                    var query = from o in orchardTableBindingSource.DataSource as List<OrchardTable>
                                where o.OrchardID == System.Convert.ToInt32(txtOrchardSearch.Text) || o.Orchardname.Contains(txtOrchardSearch.Text) ||
                                o.Firstname.Contains(txtOrchardSearch.Text) || o.Lastname.Contains(txtOrchardSearch.Text) || o.Phone.Contains(txtOrchardSearch.Text) || o.Address.Contains(txtOrchardSearch.Text)
                                select o;
                    OrchardGrid.DataSource = query.ToList();
                }
            }
        }

        private void OrchardGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are ypu sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    test1.OrchardTables.Remove(orchardTableBindingSource.Current as OrchardTable);
                    orchardTableBindingSource.RemoveCurrent();
                }
            }
        }

        private void OrchardGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnOrchardClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Main frm = new frm_Main();
            frm.Visible = true;
        }
    }
}
