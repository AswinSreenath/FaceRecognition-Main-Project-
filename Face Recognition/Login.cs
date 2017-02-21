using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace  Face_Recognition
{
    public partial class Login : Form
    {
        DBConnection db = new DBConnection();

        public Login()
        {
            InitializeComponent();
        }

        private void vistaButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = db.gettable("select * from admin_login where uname='" + txtuname.Text + "' and pwd='" + txtpwd.Text + "'");
               if (dt.Rows.Count > 0)
            {
                this.Hide();
                AdminHomePage adh = new AdminHomePage();
                adh.Show();

            }
            else
            {
                DataTable dts = new DataTable();
                dts = db.gettable("select * from staff where s_login='" + txtuname.Text + "' and s_pwd='" + txtpwd.Text + "'");
                if (dts.Rows.Count > 0)
                {
                    if (dts.Rows[0]["priv"].ToString() != "0")
                    {
                        this.Hide();
                        db.userid = dts.Rows[0]["staff_id"].ToString();
                        StaffHomePage sh = new StaffHomePage();
                        sh.Show();
                    }
                    else
                    {
                        txtpwd.Text = "";
                        txtuname.Text = "";
                        MessageBox.Show("Invalid Login");
                    }

                }
                else
                {
                    txtpwd.Text = "";
                    txtuname.Text = "";
                    MessageBox.Show("Invalid Login");
                }
            }

        }

        private void vistaButton2_Click(object sender, EventArgs e)
        {
            txtuname.Text = "";
            txtpwd.Text = "";
        }
    }
}
