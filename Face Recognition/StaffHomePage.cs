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
    public partial class StaffHomePage : Form
    {
        private int childFormNumber = 0;
        DBConnection db = new DBConnection();
        public StaffHomePage()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            criminalregistration crr = new criminalregistration();
            crr.MdiParent = this;
            crr.WindowState = FormWindowState.Maximized;
            crr.Show();
          
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            CrimeDetails cr = new CrimeDetails();
            cr.MdiParent = this;
            cr.WindowState = FormWindowState.Maximized;
            cr.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffHomePage_Load(object sender, EventArgs e)
        {
              DataTable dts = new DataTable();
              dts = db.gettable("select * from staff where staff_id=" + db.userid + "");
              string privilege = dts.Rows[0]["priv"].ToString();
              if (privilege == "1")
              {
                  toolStripLabel1.Visible = false;
                  toolStripLabel2.Visible = false;
              }

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.MdiParent = this;
          
            fr.Show();
        }
    }
}
