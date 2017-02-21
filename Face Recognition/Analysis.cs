using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV.UI;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

using System.Drawing.Imaging;
using System.IO;
using System.Xml;
using System.Runtime.InteropServices;
using System.Threading;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;


namespace Face_Recognition
{
    public partial class Analysis : Form
    {

        #region variables
        DBConnection db = new DBConnection();
        Image<Bgr, Byte> currentFrame;
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray_frame = null;
        static string criminalid;
        string name;
      //  Capture grabber;

        public HaarCascade Face = new HaarCascade(Application.StartupPath + "/Cascades/haarcascade_frontalface_alt2.xml");//haarcascade_frontalface_alt_tree.xml");

        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
        static string filepathes, filepath;
        int NumLabels;

        //Classifier with default training location
        Classifier_Train Eigen_Recog = new Classifier_Train();
        #endregion


        public Analysis()
        {
            InitializeComponent();
            Faces_Found_Panel.Visible = false;
            //if (Eigen_Recog.IsTrained)
            //{
            //    message_bar.Text = "Training Data loaded";
            //}
            //else
            //{
            //    message_bar.Text = "No training data found, please train program using Train menu option";
            //}
        }

        //ADD Picture box and label to a panel for each face
        int faces_count = 0;
       int faces_panel_Y = 0;
       int faces_panel_X = 0;

        void Clear_Faces_Found()
        {
            this.Faces_Found_Panel.Controls.Clear();
            faces_count = 0;
            faces_panel_Y = 0;
            faces_panel_X = 0;
        }


        private string save_detected_data(Image face_data, string nameperson)
        {
            try
            {
                Random rand = new Random();
                bool file_create = true;
                string filepath, facename;
                facename = "face_" + nameperson + "_" + rand.Next().ToString() + ".jpg";
                while (file_create)
                {

                    if (!File.Exists(Application.StartupPath + "/DetecedFaces/facename"))
                    {
                        file_create = false;
                    }
                    else
                    {
                        facename = "face_" + nameperson + "_" + rand.Next().ToString() + ".jpg";
                    }
                }


                if (Directory.Exists(Application.StartupPath + "/DetecedFaces/"))
                {
                    filepath = Application.StartupPath + "/DetecedFaces/" + facename;
                    face_data.Save(Application.StartupPath + "/DetecedFaces/" + facename, ImageFormat.Jpeg);
                }
                else
                {
                    filepath = Application.StartupPath + "/DetecedFaces/" + facename;
                    Directory.CreateDirectory(Application.StartupPath + "/DetecedFaces/");
                    face_data.Save(Application.StartupPath + "/DetecedFaces/" + facename, ImageFormat.Jpeg);
                }


                return filepath.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }
       void ADD_Face_Found(Image<Gray, Byte> img_found, string name_person)
        {
            PictureBox PI = new PictureBox();
            PI.Location = new Point(faces_panel_X, faces_panel_Y);
            PI.Height = 80;
            PI.Width = 80;
            PI.SizeMode = PictureBoxSizeMode.StretchImage;
            PI.Image = img_found.ToBitmap();
            Label LB = new Label();
            LB.Text = name_person;
            LB.Location = new Point(faces_panel_X, faces_panel_Y + 80);
            LB.Width = 50;
            LB.Height = 15;

            this.Faces_Found_Panel.Controls.Add(PI);
            this.Faces_Found_Panel.Controls.Add(LB);
            //faces_count++;
            btnedit.Visible = true;

            DataTable dt = new DataTable();
            dt = db.gettable("select * from criminal where c_name='" + name_person + "'");
            if (dt.Rows.Count > 0)
            {
                db.criminalid = dt.Rows[0]["criminal_id"].ToString();

                DataTable dts = new DataTable();
                dts = db.gettable("select * from Criminal_Photos where criminal_id=" + dt.Rows[0]["criminal_id"].ToString() + "");
                if (dts.Rows.Count > 0)
                {
                    DataTable dtr = new DataTable();
                    dtr = db.gettable("select * from  Log_details where check_time='" + System.DateTime.Now.ToShortDateString() + "' and staff_id=" + db.userid + " and photo_id=" + dts.Rows[0]["photo_id"] + "");
                    if (dtr.Rows.Count == 0)
                    {
                        string filepath = save_detected_data(PI.Image, name_person);
                        string st = db.ins_up_del("insert into log_details values(" + db.userid + ",'" + System.DateTime.Now.ToShortDateString() + "'," + dts.Rows[0]["photo_id"] + ",'" + filepath + "')");
                        if (st == "true")
                        {
                    
                            btnedit.Visible = true;
                        }
                        else
                        {
                       
                        }
                    }
                }
                else
                {
                 //  MessageBox.Show("No Criminal Details");
                }
            }
            else
            {
           
            }



            //if (faces_count == 2)
            //{

            //    faces_panel_X = 0;
            //    faces_panel_Y += 100;
            //    faces_count = 0;
            //}
            //else faces_panel_X += 85;

            //if (Faces_Found_Panel.Controls.Count > 10)
            //{
            //    Clear_Faces_Found();
            //}

        }


        void FrameGrabber_Standard(object sender, EventArgs e)
        {
            Image InputImg = Image.FromFile(filepathes);   //1-
            Image<Bgr, byte> EmguImage = new Image<Bgr, byte>(new Bitmap(InputImg)); //2-
            //Get the current frame form capture device
            currentFrame = EmguImage.Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            if (currentFrame != null)
            {
                gray_frame = currentFrame.Convert<Gray, Byte>();

                //Face Detector
                MCvAvgComp[][] facesDetected = gray_frame.DetectHaarCascade(Face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(50, 50));

                //Action for each element detected
                foreach (MCvAvgComp face_found in facesDetected[0])
                {
                    result = currentFrame.Copy(face_found.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                    //draw the face detected in the 0th (gray) channel with blue color
                    currentFrame.Draw(face_found.rect, new Bgr(Color.Blue), 2);
                    string name;
                    if (Eigen_Recog.IsTrained)
                    {
                        name = Eigen_Recog.Recognise(result);
                        //Draw the label for each face detected and recognized
                        currentFrame.Draw(name, ref font, new Point(face_found.rect.X - 2, face_found.rect.Y - 2), new Bgr(Color.Red));

                        ADD_Face_Found(result, name);
                    }
                   
                }
                //Show the faces procesed and recognized
                image_PICBX.Image = currentFrame.ToBitmap();
            }
        }



        void FrameGrabber_Parrellel(object sender, EventArgs e)
        {

            Image InputImg = Image.FromFile(filepathes);   //1-
            Image<Bgr, byte> EmguImage = new Image<Bgr, byte>(new Bitmap(InputImg)); //2-
            //Get the current frame form capture device
            currentFrame = EmguImage.Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            //Clear_Faces_Found();

            if (currentFrame != null)
            {
                gray_frame = currentFrame.Convert<Gray, Byte>();

                //Face Detector
                MCvAvgComp[][] facesDetected = gray_frame.DetectHaarCascade(Face, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(50, 50));

                //Action for each element detected
                foreach (MCvAvgComp face_found in facesDetected[0])
                {

                    try
                    {

                        result = currentFrame.Copy(face_found.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                        result._EqualizeHist();
                        //draw the face detected in the 0th (gray) channel with blue color
                        currentFrame.Draw(face_found.rect, new Bgr(Color.Blue), 2);

                        if (Eigen_Recog.IsTrained)
                        {
                            name = Eigen_Recog.Recognise(result);
                            //Draw the label for each face detected and recognized
                            currentFrame.Draw(name, ref font, new Point(face_found.rect.X - 2, face_found.rect.Y - 2), new Bgr(Color.LightGreen));
                            ADD_Face_Found(result, name);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        //do nothing as parrellel loop buggy
                        //No action as the error is useless, it is simply an error
                        //no data being there to process and this occurss sporadically 
                    }
                }
                //Show the faces procesed and recognized
                image_PICBX.Image = currentFrame.ToBitmap();
            }
        }

        private void vistaButton1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            Application.Idle += new EventHandler(FrameGrabber_Parrellel);
        }

        private void btnfupload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if ((openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                filepathes = openFileDialog1.FileName;
                Image img = Image.FromFile(filepathes);
                pictureBox1.Image = img;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            ViewLogDetails vg = new ViewLogDetails(name);
            vg.Show();
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            btnedit.Visible = false;
            panel2.Visible= false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Faces_Found_Panel_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
