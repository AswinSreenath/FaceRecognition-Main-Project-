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
    public partial class Form3 : Form
    {
        #region variables
        DBConnection db = new DBConnection();
        Image<Bgr, Byte> currentFrame;
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray_frame = null;
        static string criminalid;
        Capture grabber;

        public HaarCascade Face = new HaarCascade(Application.StartupPath + "/Cascades/haarcascade_frontalface_alt2.xml");//haarcascade_frontalface_alt_tree.xml");

        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);

        int NumLabels;

        //Classifier with default training location
        Classifier_Train Eigen_Recog = new Classifier_Train();
        #endregion
        public Form3()
        {
            InitializeComponent();
        }

        private void stop_capture()
        {
            Application.Idle -= new EventHandler(FrameGrabber_Parrellel);
            if (grabber != null)
            {
                grabber.Dispose();
            }
        }

        public void retrain()
        {
            Eigen_Recog = new Classifier_Train();
            if (Eigen_Recog.IsTrained)
            {
                //message_bar.Text = "Training Data loaded";
            }
            else
            {
               // message_bar.Text = "No training data found, please train program using Train menu option";
            }
        }
        public void initialise_capture()
        {
            try
            {

                grabber = new Capture();
                grabber.QueryFrame();
                //Initialize the FrameGraber event
                Application.Idle += new EventHandler(FrameGrabber_Parrellel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connect Camera");
            }
        }
        int faces_count = 0;
        int faces_panel_Y = 0;
        int faces_panel_X = 0;
    

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
            //btnedit.Visible = true;

           
          



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

        void FrameGrabber_Parrellel(object sender, EventArgs e)
        {
            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

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
                        currentFrame.Draw(face_found.rect, new Bgr(Color.Red), 2);

                        if (Eigen_Recog.IsTrained)
                        {
                            string name = Eigen_Recog.Recognise(result);
                            //Draw the label for each face detected and recognized
                            currentFrame.Draw(name, ref font, new Point(face_found.rect.X - 2, face_found.rect.Y - 2), new Bgr(Color.LightGreen));
                            ADD_Face_Found(result, name);



                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        //do nothing as parrellel loop buggy
                        //No action as the error is useless, it is simply an error in 
                        //no data being there to process and this occurss sporadically 
                    }
                }
                //Show the faces procesed and recognized
               // image_PICBX.Image = currentFrame.ToBitmap();
            }
        }
        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stop_capture();

            //OpenForm
            Training_Form TF = new Training_Form(this);
            TF.Show();
        }

        private void trainingThroughPhotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trainingimages tm = new Trainingimages(this);
            tm.Show();
        }
    }
}
