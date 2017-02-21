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
    public partial class CrimeDetails : Form
    {
        DBConnection d = new DBConnection();
        SqlCommand cmd = new SqlCommand();
        public CrimeDetails()
        {
            InitializeComponent();
        }

        private void cmbdept_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void fillcombo()
        {
            DataTable dt = new DataTable();
            dt = d.gettable("select * from criminal");
            DataRow drcl;
            drcl = dt.NewRow();
            drcl.ItemArray = new object[] { 0, "--Select an item--" };
            dt.Rows.InsertAt(drcl, 0);                       
            cmbcriminals.DataSource = dt;
            cmbcriminals.DisplayMember = "c_name";
            cmbcriminals.ValueMember = "criminal_id";

            DataTable dtdept = new DataTable();
            dtdept = d.gettable("select * from dept");
            DataRow drdept;
            drdept = dtdept.NewRow();
            drdept.ItemArray = new object[] { 0, "--Select an item--" };
            dtdept.Rows.InsertAt(drdept, 0);  
            cmbdept.DataSource = dtdept;
            cmbdept.DisplayMember = "dept_name";
            cmbdept.ValueMember = "dept_id";


           
        }

        private void CrimeDetails_Load(object sender, EventArgs e)
        {
            fillcombo();
            bind();
            
           
            
        }

        public void clear()
        {
            cmbcriminals.SelectedIndex = 0;
            cmbdept.SelectedIndex = 0;
            txtaddr.Text = "";
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            clear();
            btndelete.Enabled = false;
            btnedit.Enabled = false;
            btnsave.Enabled = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormatGrid()
        {


            dgviewcrime.Columns[5].HeaderText = "Name Of Criminal";
            dgviewcrime.Columns[5].Width = 150;
            dgviewcrime.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewcrime.Columns[5].ReadOnly = true;


            dgviewcrime.Columns[10].HeaderText = "Department";
            dgviewcrime.Columns[10].Width = 210;
            dgviewcrime.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewcrime.Columns[10].ReadOnly = true;

            dgviewcrime.Columns[3].HeaderText = "Personal Details";
            dgviewcrime.Columns[3].Width = 210;
            dgviewcrime.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewcrime.Columns[3].ReadOnly = true;

          


        }
        public void bind()
        {
            DataTable dtfill = new DataTable();
            dtfill = d.gettable("select * from crime_details as cd inner join criminal as c on c.criminal_id=cd.criminal_id inner join dept as d on d.dept_id=cd.dept_id");
            if (dtfill.Rows.Count > 0)
            {

                dgviewcrime.DataSource = dtfill;
                FormatGrid();
                dgviewcrime.Columns[0].Visible = false;
                dgviewcrime.Columns[1].Visible = false;
                dgviewcrime.Columns[2].Visible = false;
                dgviewcrime.Columns[4].Visible = false;
                dgviewcrime.Columns[6].Visible = false;
                dgviewcrime.Columns[7].Visible = false;
                dgviewcrime.Columns[8].Visible = false;
                dgviewcrime.Columns[9].Visible = false;
                dgviewcrime.Columns[11].Visible = false; 

            }
            else
            {
                dgviewcrime.DataSource = "";
            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            string qry1 = d.selone("SELECT criminal_id FROM criminal WHERE c_name='" + cmbcriminals.Text + "'");
            string qry2 = d.selone("SELECT dept_id FROM dept WHERE dept_name='" + cmbdept.Text + "'");
            string qry = "INSERT INTO crime_details(criminal_id,dept_id,crime_details) VALUES ('" + qry1 + "','" + qry2 + "','" + txtaddr.Text + "')";
            d.ins_up_del(qry);
            clear(); 
        }


        private void dgviewcrime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string qry1 = d.selone("SELECT criminal_id FROM criminal WHERE c_name='" + cmbcriminals.Text + "'");
            string qry = "UPDATE crime_details SET crime_details='" + txtaddr.Text + "' WHERE criminal_id=" + qry1;
            d.ins_up_del(qry);
            clear();
            fill(dgviewcrime, "SELECT criminal_id AS ID,c_name AS Name,c_dob AS DOB,c_personal AS Details FROM criminal");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string q = d.selone("SELECT criminal_id FROM criminal WHERE c_name='" + cmbcriminals.Text + "'");
            string qry = "DELETE FROM crime_details WHERE criminal_id='" + q + "'";
            d.ins_up_del(qry);
            clear();
        }

        private void btnsave_MouseDown(object sender, MouseEventArgs e)
        {
            if (cmbdept.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Department! ", "Information", MessageBoxButtons.OK);

            }
            if (cmbcriminals.SelectedIndex == 0)
            {
                MessageBox.Show("PleaseSelect Criminal Name! ", "Information", MessageBoxButtons.OK);

            }
            if (txtaddr.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Address! ", "Information", MessageBoxButtons.OK);
                txtaddr.Focus();
            }
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
