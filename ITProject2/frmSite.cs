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
    public partial class frmSite : MetroFramework.Forms.MetroForm
    {
        IT_Project_DatabaseEntities test;

        public frmSite()
        {
            InitializeComponent();
        }

        private void frmSite_Load(object sender, EventArgs e)
        {
            test = new IT_Project_DatabaseEntities();
            siteTableBindingSource.DataSource = test.SiteTables.ToList();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtSiteID.Text = " ";
                txtSiteMaf.Text = " ";
                txtSiteFirst.Text = " ";
                txtSiteLast.Text = " ";
                txtSitename.Text = " ";
                txtSiteaddress.Text = " ";
                txtSitephone.Text = " ";
                txtSiteLatitude.Text = " ";
                txtSiteLongtitude.Text = " ";
                txtSiteID.Focus();
                SiteTable s = new SiteTable();
                test.SiteTables.Add(s);
                siteTableBindingSource.Add(s);
                siteTableBindingSource.MoveLast();


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
                siteTableBindingSource.EndEdit();
                test.SaveChangesAsync();
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                siteTableBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtSiteID.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            siteTableBindingSource.ResetBindings(false);
            foreach (DbEntityEntry entry in test.ChangeTracker.Entries())
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

        private void txtSiteSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(txtSiteSearch.Text))
                {
                    metroGrid1.DataSource = siteTableBindingSource;

                }
                else
                {
                    var query = from o in siteTableBindingSource.DataSource as List<SiteTable>
                                where o.SiteID == System.Convert.ToInt32(txtSiteSearch.Text) || o.MafID == System.Convert.ToInt32(txtSiteSearch.Text) || o.Sitename.Contains(txtSiteSearch.Text) ||
                                o.Firstname.Contains(txtSiteSearch.Text) || o.Lastname.Contains(txtSiteSearch.Text) || o.Phone.Contains(txtSiteSearch.Text)
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
                    test.SiteTables.Remove(siteTableBindingSource.Current as SiteTable);
                    siteTableBindingSource.RemoveCurrent();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Main frm = new frm_Main();
            frm.Visible = true;

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                txtSiteID.Text = " ";
                txtSiteMaf.Text = " ";
                txtSiteFirst.Text = " ";
                txtSiteLast.Text = " ";
                txtSitename.Text = " ";
                txtSiteaddress.Text = " ";
                txtSitephone.Text = " ";
                txtSiteLatitude.Text = " ";
                txtSiteLongtitude.Text = " ";
                txtSiteMaf.Focus();
                SiteTable s = new SiteTable();
                test.SiteTables.Add(s);
                siteTableBindingSource.Add(s);
                siteTableBindingSource.MoveLast();


            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this, "You Username or password is incorrect!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSiteID_Click(object sender, EventArgs e)
        {

        }
    }
}