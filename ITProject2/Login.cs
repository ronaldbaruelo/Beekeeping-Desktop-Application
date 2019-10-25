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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtusername.Focus();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtusername.Focus();
                return;
            }
            try
            {
                using (IT_Project_DatabaseEntities db = new IT_Project_DatabaseEntities())
                {
                    var query = from u in db.users
                                where u.username == txtusername.Text && u.password == txtpassword.Text
                                select u;

                    if (query.SingleOrDefault() != null)
                    {
                        this.Hide();
                        frm_Main frm = new frm_Main();
                        frm.ShowDialog();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "You Username or password is incorrect!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

