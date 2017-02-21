using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Face_Recognition
{
    public partial class UpdatePassword : Form
    {
        DBConnection db = new DBConnection();
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.gettable("select * from admin_login where pwd='" + txtopwd.Text + "'");
            if (dt.Rows.Count > 0)
            {
                if (txtnpwd.Text == txtrpwd.Text)
                {
                    string s = db.ins_up_del("update admin_login set pwd='" + txtnpwd.Text + "' where  pwd='" + txtopwd.Text + "'");
                    if (s == "true")
                    {
                        MessageBox.Show("Password Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show(s);
                    }
                }
                else
                {
                    MessageBox.Show("Password Doesnot Match");
                }
            }
            else
            {
                MessageBox.Show("Old Password is Incorrect");
            }
        }

        private void btnupdate_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtopwd.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Password! ", "Information", MessageBoxButtons.OK);
                txtopwd.Focus();

            }
            if (txtnpwd.Text.Length == 0)
            {
                MessageBox.Show("Please Enter New Password! ", "Information", MessageBoxButtons.OK);
                txtnpwd.Focus();


            }
            if (txtrpwd.Text.Length == 0)
            {
                MessageBox.Show("Please ReEnter Password! ", "Information", MessageBoxButtons.OK);
                txtrpwd.Focus();

            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
