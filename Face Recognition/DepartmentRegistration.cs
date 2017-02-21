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
    public partial class DepartmentRegistration : Form
    {
        DBConnection d = new DBConnection();
        SqlCommand cmd = new SqlCommand();
        
        public DepartmentRegistration()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtdeptname.Text = "";
            txtdesc.Text = "";
            btnsave.Enabled = true;

        }

        public void bind()
        {
            DataTable dt = new DataTable();
            dt = d.gettable("select * from dept");
            if (dt.Rows.Count > 0)
            {
                dgviewdept.DataSource = dt;
                dgviewdept.Columns[0].Visible = false;
                FormatGrid();
            }
            else
            {
                dgviewdept.DataSource = "";
            }
            
        }



        private void FormatGrid()
        {
           

            dgviewdept.Columns[1].HeaderText = "DepartMent Name";
            dgviewdept.Columns[1].Width = 150;
            dgviewdept.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewdept.Columns[1].ReadOnly = true;

            dgviewdept.Columns[2].HeaderText = "Details";
            dgviewdept.Columns[2].Width = 210;
            dgviewdept.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewdept.Columns[2].ReadOnly = true;

           
        }

        public void clear()
        {
            txtdeptname.Text = "";
            txtdesc.Text = "";
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string qry = "insert into dept(dept_name,descp) values ('" + txtdeptname.Text + "','" + txtdesc.Text + "')";
            d.ins_up_del(qry);
        }

      

        private void btnsave_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtdeptname.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Name of Department! ", "Information", MessageBoxButtons.OK);
                txtdeptname.Focus();

            }
            if (txtdesc.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Description Of Department! ", "Information", MessageBoxButtons.OK);
                txtdesc.Focus();

            }
            
        }

        private void DepartmentRegistration_Load(object sender, EventArgs e)
        {
            btndelete.Enabled = false;
            btnedit.Enabled = false;
            bind();
        }

        private void dgviewdept_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btndelete.Enabled = true;
            btnedit.Enabled = true;
            btnsave.Enabled = false;
            txtdeptname.Text = dgviewdept.CurrentRow.Cells[1].Value.ToString();
            txtdesc.Text = dgviewdept.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string dn = d.selone("SELECT dept_id FROM dept WHERE dept_name='" + txtdeptname.Text + "'");
            string qry = "UPDATE dept SET dept_name='" + txtdeptname.Text + "',descp='" + txtdesc.Text + "'WHERE dept_id='" + dn + "'";
            d.ins_up_del(qry);
            clear();
            fill(dgviewdept, "SELECT * FROM dept");

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            string dn = d.selone("SELECT dept_id FROM dept WHERE dept_name='" + txtdeptname.Text + "'");
            string qry = "DELETE FROM dept WHERE dept_id='" + dn + "'";
            d.ins_up_del(qry);
            clear();
            fill(dgviewdept, "SELECT * FROM dept");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void fill(DataGridView dg, string qry)
        {
            DataTable dt = d.gettable(qry);
            if (dt.Rows.Count > 0)
            {
                dg.DataSource = dt;
            }

        }
    }
}
