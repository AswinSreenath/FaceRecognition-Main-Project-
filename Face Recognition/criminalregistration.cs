using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Drawing.Imaging;
using System.Xml;
using System.Threading;

using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using System.IO;


namespace  Face_Recognition
{
    public partial class criminalregistration : Form
    {
        static string id;
        static string fp,facename;
        DBConnection d = new DBConnection();
        SqlCommand cmd = new SqlCommand();
        //Images for finding face
        Image<Bgr, Byte> currentFrame;
        Image<Gray, byte> result = null;
        Image<Gray, byte> gray_frame = null;
        static string newpath ,filepath;
        HaarCascade Face;
         bool RECORD = false;
         //Saving Jpg
         List<Image<Gray, byte>> ImagestoWrite = new List<Image<Gray, byte>>();
         EncoderParameters ENC_Parameters = new EncoderParameters(1);
         EncoderParameter ENC = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100);
         ImageCodecInfo Image_Encoder_JPG;


         List<string> NamestoWrite = new List<string>();
         List<string> NamesforFile = new List<string>();
         XmlDocument docu = new XmlDocument();


        // public Image<TColor, TDepth> Resize(int width, int height, INTER interpolationType);
        public criminalregistration()
        {
            InitializeComponent();
        }

        private void btnfileupload_Click(object sender, EventArgs e)
        {
           
           
            if(txtname.Text.Length!=0)
            {
                openFileDialog1.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
                if ((openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
                {
                    filepath = openFileDialog1.FileName;
                    Image img = Image.FromFile(filepath);
                    txtfilepath.Text = filepath;

                     currentFrame = new Image<Bgr, byte>(@filepath); //Read the files as an 8-bit Bgr image  

                   

                    //Convert it to Grayscale
                    if (currentFrame != null)
                    {
                       
                        gray_frame = currentFrame.Convert<Gray, Byte>();

                        //Face Detector
                      // MCvAvgComp[][] facesDetected = gray_frame.DetectHaarCascade(Face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));

                       // //Action for each element detected
                       //foreach (MCvAvgComp face_found in facesDetected[0])
                       //{
                       //    //result = currentFrame.Convert<Gray, byte>().Resize(100,100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                           // result._EqualizeHist();
                           // pic_photo.Image = result.ToBitmap();

                           result = currentFrame.Copy(gray_frame).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                           result._EqualizeHist();
                           pic_photo.Image = result.ToBitmap();
                           //draw the face detected in the 0th (gray) channel with blue color
                          // currentFrame.Draw(gray_frame, new Bgr(Color.Red), 2);
                       } 


                      
                       // pic_photo.Image = currentFrame.ToBitmap();
                 


                } 
            }
            else
            {
                MessageBox.Show("Enter Name");
                txtname.Focus();
            }


        }




      
         
           


        public void clear()
        {
            pic_photo.Image = null;
            txtfilepath.Text = "";
            txtname.Text = "";
            txtpdetails.Text = "";
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void bind()
        {
            DataTable dt = new DataTable();
            dt = d.gettable("select * from criminal");
            if (dt.Rows.Count > 0)
            {
                dgviewcriminal.DataSource = dt;
                dgviewcriminal.Columns[0].Visible = false;
                FormatGrid();
            }
            else
            {
                dgviewcriminal.DataSource = "";
            }
            
        }

        private void FormatGrid()
        {


            dgviewcriminal.Columns[1].HeaderText = "Name Of Criminal";
            dgviewcriminal.Columns[1].Width = 150;
            dgviewcriminal.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewcriminal.Columns[1].ReadOnly = true;


            dgviewcriminal.Columns[2].HeaderText = "Date Of Birth";
            dgviewcriminal.Columns[2].Width = 210;
            dgviewcriminal.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewcriminal.Columns[2].ReadOnly = true;

            dgviewcriminal.Columns[3].HeaderText = "Personal Details";
            dgviewcriminal.Columns[3].Width = 210;
            dgviewcriminal.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewcriminal.Columns[3].ReadOnly = true;

            dgviewcriminal.Columns[4].HeaderText = "Photo";
            dgviewcriminal.Columns[4].Width = 210;
            dgviewcriminal.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgviewcriminal.Columns[4].ReadOnly = true;

           


        }


        public void xmlwrite(string id)
        {
            if (File.Exists(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml"))
            {
                //File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", NAME_PERSON.Text + "\n\r");
                bool loading = true;
                while (loading)
                {
                    try
                    {
                        docu.Load(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml");
                        loading = false;
                    }
                    catch
                    {
                        docu = null;
                        docu = new XmlDocument();
                        Thread.Sleep(10);
                    }
                }

                //Get the root element
                XmlElement root = docu.DocumentElement;

                XmlElement face_D = docu.CreateElement("FACE");
                XmlElement name_D = docu.CreateElement("NAME");
                XmlElement file_D = docu.CreateElement("FILE");
                XmlElement id_D = docu.CreateElement("ID");

                //Add the values for each nodes
                //name.Value = textBoxName.Text;
                //age.InnerText = textBoxAge.Text;
                //gender.InnerText = textBoxGender.Text;
                name_D.InnerText = txtname.Text;
                file_D.InnerText = facename;
                id_D.InnerText = id;
                //Construct the Person element
                //person.Attributes.Append(name);
                face_D.AppendChild(name_D);
                face_D.AppendChild(file_D);
                face_D.AppendChild(id_D);

                //Add the New person element to the end of the root element
                root.AppendChild(face_D);

                //Save the document
                docu.Save(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml");
                //XmlElement child_element = docu.CreateElement("FACE");
                //docu.AppendChild(child_element);
                //docu.Save("TrainedLabels.xml");
            }
            else
            {
                FileStream FS_Face = File.OpenWrite(Application.StartupPath + "/TrainedFaces/TrainedLabels.xml");
                using (XmlWriter writer = XmlWriter.Create(FS_Face))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("Faces_For_Training");

                    writer.WriteStartElement("FACE");
                    writer.WriteElementString("NAME", txtname.Text);
                    writer.WriteElementString("FILE", facename);
                    writer.WriteElementString("ID", id);
                    writer.WriteEndElement();

                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                }
                FS_Face.Close();
            }
        }











        private string save_training_data(Image face_data)
        {
            try
            {
                Random rand = new Random();
                bool file_create = true;
                string filepath;
                 facename = "face_" + txtname.Text + "_" + rand.Next().ToString() + ".jpg";
                while (file_create)
                {

                    if (!File.Exists(Application.StartupPath + "/TrainedFaces/facename"))
                    {
                        file_create = false;
                    }
                    else
                    {
                        facename = "face_" + txtname.Text + "_" + rand.Next().ToString() + ".jpg";
                    }
                }


                if (Directory.Exists(Application.StartupPath + "/TrainedFaces/"))
                {
                    filepath=Application.StartupPath + "/TrainedFaces/" + facename;
                    face_data.Save(Application.StartupPath + "/TrainedFaces/" + facename, ImageFormat.Jpeg);
                }
                else
                {
                    filepath=Application.StartupPath + "/TrainedFaces/" + facename;
                    Directory.CreateDirectory(Application.StartupPath + "/TrainedFaces/");
                    face_data.Save(Application.StartupPath + "/TrainedFaces/" + facename, ImageFormat.Jpeg);
                }
                

                return filepath.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string qry = "INSERT INTO criminal(c_name,c_personal,c_dob,c_photo) VALUES ('" + txtname.Text + "','" + txtpdetails.Text + "','" + datepick.Text + "','" + txtfilepath.Text + "')";
            d.ins_up_del(qry);
            clear();
            fill(dgviewcriminal, "SELECT criminal_id AS ID,c_name AS Name,c_dob AS DOB,c_personal AS Details FROM criminal");     
        }

        private void dgviewcriminal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgviewcriminal.CurrentRow.Cells[0].Value.ToString();
            string qy = "select * from criminal where criminal_id=" + id;
            DataTable dt = d.gettable(qy);
            txtname.Text = dt.Rows[0]["c_name"].ToString();
            txtpdetails.Text = dt.Rows[0]["c_personal"].ToString();
            datepick.Text = dt.Rows[0]["c_dob"].ToString();
            txtfilepath.Text = dt.Rows[0]["c_photo"].ToString();
            Image img = Image.FromFile(txtfilepath.Text);
            pic_photo.Image = new Bitmap(img, pic_photo.Width, pic_photo.Height);
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string qry = "UPDATE criminal SET c_name='" + txtname.Text + "',c_personal='" + txtpdetails.Text + "',c_dob='" + datepick.Text + "',c_photo='" + txtfilepath.Text + "'WHERE criminal_id=" + id;
            d.ins_up_del(qry);
            clear();
            fill(dgviewcriminal, "SELECT criminal_id AS ID,c_name AS Name,c_dob AS DOB,c_personal AS Details FROM criminal");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string q = d.selone("SELECT criminal_id FROM criminal WHERE c_name='" + txtname.Text + "'");
            string qry = "DELETE FROM criminal WHERE criminal_id='" + q + "'";
            d.ins_up_del(qry);
            clear();
            fill(dgviewcriminal, "SELECT criminal_id AS ID,c_name AS Name,c_dob AS DOB,c_personal AS Details FROM criminal");
        }

        private void criminalregistration_Load(object sender, EventArgs e)
        {
            bind();
            btndelete.Enabled = true;
            btnedit.Enabled = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtpdetails.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Name of Department! ", "Information", MessageBoxButtons.OK);
                txtpdetails.Focus();

            }
            if (txtname.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Name of Department! ", "Information", MessageBoxButtons.OK);
                txtname.Focus();

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

        private void dgviewcriminal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
