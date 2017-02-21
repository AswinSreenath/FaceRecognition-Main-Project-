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
    public partial class ViewLogDetails : Form
    {
        DBConnection db = new DBConnection();

        public ViewLogDetails()
        {
            InitializeComponent();
        }

        public ViewLogDetails(string name)
        {
            InitializeComponent();
            lblname.Text = name;
        }

        private void ViewLogDetails_Load(object sender, EventArgs e)
        {
            string d=db.selone("SELECT criminal_id FROM criminal WHERE c_name='"+lblname.Text+"'");
            lblpdetails.Text=db.selone("SELECT c_personal FROM criminal WHERE criminal_id='"+d+"'");
            string d2=db.selone("SELECT dept_id FROM crime_details WHERE criminal_id='"+d+"'");
            lblcrimes.Text=db.selone("SELECT dept_name FROM dept WHERE dept_id='"+d2+"'");
            lblpcdetails.Text=db.selone("SELECT crime_details FROM crime_details WHERE criminal_id='"+d+"'");
            label2.Text=db.selone("SELECT c_photo FROM criminal WHERE criminal_id='"+d+"'");
            Image img=Image.FromFile(label2.Text);
            pictureBox1.Image = new Bitmap(img, pictureBox1.Width, pictureBox1.Height);
          /*  DataTable dt = new DataTable();
        //    dt = db.gettable("select  c.criminal_id,c.c_name,c.c_personal,d.dept_name,cd.crime_details,c.c_photo from criminal as c inner join crime_details as cd on c.criminal_id=cd.criminal_id inner join dept as d on d.dept_id=cd.dept_id where c.c_name=" +  + "");
            dt = db.gettable("select  c.criminal_id,c.c_name,c.c_per            if (dt.Rows.Count > 0)
sonal,d.dept_name,cd.crime_details,c.c_photo from criminal as c inner join crime_details as cd on c.criminal_id=cd.criminal_id inner join dept as d on d.dept_id=cd.dept_id where c_name='"+label2.Text+"'");
            {
                lblname.Text = dt.Rows[0]["c_name"].ToString();
                lblpdetails.Text = dt.Rows[0]["c_personal"].ToString();
                lblcrimes.Text = dt.Rows[0]["dept_name"].ToString();
                lblpcdetails.Text = dt.Rows[0]["crime_details"].ToString();
                pictureBox1.Image = Image.FromFile(dt.Rows[0]["c_photo"].ToString());
            }*/
        }
    }
}
