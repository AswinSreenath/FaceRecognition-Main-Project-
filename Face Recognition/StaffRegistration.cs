using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace  Face_Recognition
{
    public partial class StaffRegistration : Form
    {
        DBConnection d = new DBConnection();
        SqlCommand cmd = new SqlCommand();
        public StaffRegistration()
        {
            InitializeComponent();
        }

        public void clear()
        {
            cmbprivilege.SelectedIndex = 0;
            txtaddr.Text = "";
            txtemail.Text = "";
            txtname.Text = "";
            txtphno.Text = "";
            txtpwd.Text = "";
            txtuname.Text = "";
            btndelete.Enabled = false;
            btnedit.Enabled = false;

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            clear();
            btnsave.Enabled = true;

        }



        private void FormatGrid()
        {


            dgviewstaff.Columns[1].HeaderText = "UserName";
            dgviewstaff.Columns[1].Width = 150;
            dgviewstaff.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewstaff.Columns[1].ReadOnly = true;

           
            dgviewstaff.Columns[3].HeaderText = "Name";
            dgviewstaff.Columns[3].Width = 210;
            dgviewstaff.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewstaff.Columns[3].ReadOnly = true;

            dgviewstaff.Columns[4].HeaderText = "Phone Number";
            dgviewstaff.Columns[4].Width = 210;
            dgviewstaff.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewstaff.Columns[4].ReadOnly = true;

            dgviewstaff.Columns[5].HeaderText = "Email";
            dgviewstaff.Columns[5].Width = 210;
            dgviewstaff.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewstaff.Columns[5].ReadOnly = true;

            dgviewstaff.Columns[6].HeaderText = "Date Of Registration";
            dgviewstaff.Columns[6].Width = 210;
            dgviewstaff.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewstaff.Columns[6].ReadOnly = true;


        }

        public void bind()
        {
            DataTable dt = new DataTable();
            dt = d.gettable("select * from staff");
            if (dt.Rows.Count > 0)
            {
                dgviewstaff.DataSource = dt;
                FormatGrid();
                dgviewstaff.Columns[0].Visible = false;
                dgviewstaff.Columns[2].Visible = false;
                dgviewstaff.Columns[7].Visible = false;


            }
            else
            {
                dgviewstaff.DataSource = "";
            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            string qry = "insert into staff(s_name,s_add,s_ph,s_email,priv,date_reg,s_login,s_pwd) values ('" + txtname.Text + "','" + txtaddr.Text + "','" + txtphno.Text + "','" + txtemail.Text + "','" + cmbprivilege.Text + "','" + DateTime.Today.ToString() + "','" + txtuname.Text + "','" + txtpwd.Text + "')";
            d.ins_up_del(qry);
            fill(dgviewstaff, "select * from staff");
        }


        public void check()
        {
            if (txtname.Text.Length == 0)
            {
                MessageBox.Show("Please Enter  Name! ", "Information", MessageBoxButtons.OK);
                txtname.Focus();

            }

            if (cmbprivilege.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select  privileges ! ", "Information", MessageBoxButtons.OK);
                cmbprivilege.Focus();

            }

            if (txtaddr.Text.Length == 0)
            {

                MessageBox.Show("Please Enter Address! ", "Information", MessageBoxButtons.OK);
                txtaddr.Focus();
            }

            if (txtemail.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Email! ", "Information", MessageBoxButtons.OK);
                txtemail.Focus();
            }

            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (txtemail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtemail.Text))
                {
                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.SelectAll();

                }
            }

            System.Text.RegularExpressions.Regex rPhone = new System.Text.RegularExpressions.Regex("[0-9]{10,11}");
            if (txtphno.Text.Length > 0)
            {
                if (!rPhone.IsMatch(txtphno.Text))
                {
                    MessageBox.Show("Phone Number must be Maximum 10 Digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtphno.SelectAll();

                }
            }
            else
            {
                MessageBox.Show("Please Enter Phone No! ", "Information", MessageBoxButtons.OK);
                txtphno.Focus();
            }

        }


        private void btnsave_MouseDown(object sender, MouseEventArgs e)
        {
            check();
        }

        private void txtphno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) == false)
            {
                e.Handled = true;
                MessageBox.Show("Enter only numbers");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffRegistration_Load(object sender, EventArgs e)
        {
            bind();
            btndelete.Enabled = false;
            btnedit.Enabled = false;
            cmbprivilege.SelectedIndex = 0;
          
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string sn = d.selone("SELECT staff_id FROM staff WHERE s_name='" + txtname.Text + "'");
            string qry = "UPDATE staff SET s_name='" + txtname.Text + "',s_add='" + txtaddr.Text + "',s_ph='" + txtphno.Text + "',s_email='" + txtemail.Text + "',priv='" + cmbprivilege.Text + "',s_login='" + txtuname.Text + "',s_pwd='" + txtpwd.Text + "' WHERE staff_id='" + sn + "'";
            d.ins_up_del(qry);
            clear();
            fill(dgviewstaff, "SELECT * FROM staff");

            
        }

        private void dgviewstaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string sn = d.selone("SELECT staff_id FROM staff WHERE s_name='" + txtname.Text + "'");
             string qry = "DELETE FROM staff WHERE staff_id='" + sn + "'";
            d.ins_up_del(qry);
            clear();
            fill(dgviewstaff, "SELECT * FROM staff");

           
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnedit_MouseDown(object sender, MouseEventArgs e)
        {
            check();
        }

        private void btndelete_MouseDown(object sender, MouseEventArgs e)
        {
          
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {
            int c = d.check_column("select count(*) from staff where s_login='" + txtuname.Text + "'");
            if (c == 0)
            {

            }
            else
            {
                MessageBox.Show("UserName Already Exists");
            }
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbprivilege_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void fill(DataGridView dg, string qry)
        {
            DataTable dt = d.gettable(qry);
            if (dt.Rows.Count > 0)
            {
                dg.DataSource = dt;
            }

        }

        private void dgviewstaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string dg = dgviewstaff.CurrentRow.Cells[0].Value.ToString();
            string qy = "select * from staff where staff_id=" + dg;
            DataTable dt = d.gettable(qy);
            txtname.Text = dt.Rows[0]["s_name"].ToString();
            txtaddr.Text = dt.Rows[0]["s_add"].ToString();
            txtphno.Text = dt.Rows[0]["s_ph"].ToString();
            txtemail.Text = dt.Rows[0]["s_email"].ToString();
            cmbprivilege.Text = dt.Rows[0]["priv"].ToString();
            txtuname.Text = dt.Rows[0]["s_login"].ToString();
            txtpwd.Text = dt.Rows[0]["s_name"].ToString();
        }
    }
}
