namespace Face_Recognition
{
    partial class Trainingimages
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.image_PICBX = new System.Windows.Forms.PictureBox();
            this.NAME_PERSON = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.face_PICBX = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.vistaButton1 = new Face_Recognition.VistaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vistaButton4 = new Face_Recognition.VistaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BACK_BTN = new Face_Recognition.VistaButton();
            this.ADD_BTN = new Face_Recognition.VistaButton();
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.face_PICBX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // image_PICBX
            // 
            this.image_PICBX.BackColor = System.Drawing.Color.White;
            this.image_PICBX.Location = new System.Drawing.Point(3, 3);
            this.image_PICBX.Name = "image_PICBX";
            this.image_PICBX.Size = new System.Drawing.Size(350, 259);
            this.image_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_PICBX.TabIndex = 4;
            this.image_PICBX.TabStop = false;
            // 
            // NAME_PERSON
            // 
            this.NAME_PERSON.Location = new System.Drawing.Point(420, 209);
            this.NAME_PERSON.Name = "NAME_PERSON";
            this.NAME_PERSON.Size = new System.Drawing.Size(158, 20);
            this.NAME_PERSON.TabIndex = 13;
            this.NAME_PERSON.Text = "PERSON1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(102)))), ((int)(((byte)(115)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(373, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "NAME:";
            // 
            // face_PICBX
            // 
            this.face_PICBX.BackColor = System.Drawing.Color.White;
            this.face_PICBX.Location = new System.Drawing.Point(385, 14);
            this.face_PICBX.Name = "face_PICBX";
            this.face_PICBX.Size = new System.Drawing.Size(181, 179);
            this.face_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.face_PICBX.TabIndex = 10;
            this.face_PICBX.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(112, 20);
            this.textBox1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(385, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // vistaButton1
            // 
            this.vistaButton1.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton1.BaseColor = System.Drawing.Color.SlateGray;
            this.vistaButton1.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.vistaButton1.ButtonText = "Training";
            this.vistaButton1.Location = new System.Drawing.Point(150, 114);
            this.vistaButton1.Name = "vistaButton1";
            this.vistaButton1.Size = new System.Drawing.Size(100, 32);
            this.vistaButton1.TabIndex = 24;
            this.vistaButton1.Click += new System.EventHandler(this.vistaButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.vistaButton4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.vistaButton1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(27, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 201);
            this.panel1.TabIndex = 25;
            // 
            // vistaButton4
            // 
            this.vistaButton4.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton4.BaseColor = System.Drawing.Color.SlateGray;
            this.vistaButton4.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.vistaButton4.ButtonText = "File Upload";
            this.vistaButton4.Location = new System.Drawing.Point(179, 46);
            this.vistaButton4.Name = "vistaButton4";
            this.vistaButton4.Size = new System.Drawing.Size(114, 32);
            this.vistaButton4.TabIndex = 25;
            this.vistaButton4.Click += new System.EventHandler(this.btnfupload_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.BACK_BTN);
            this.panel2.Controls.Add(this.ADD_BTN);
            this.panel2.Controls.Add(this.image_PICBX);
            this.panel2.Controls.Add(this.face_PICBX);
            this.panel2.Controls.Add(this.NAME_PERSON);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(27, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 272);
            this.panel2.TabIndex = 26;
            // 
            // BACK_BTN
            // 
            this.BACK_BTN.BackColor = System.Drawing.Color.Transparent;
            this.BACK_BTN.BaseColor = System.Drawing.Color.SlateGray;
            this.BACK_BTN.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.BACK_BTN.ButtonText = "BACK";
            this.BACK_BTN.Location = new System.Drawing.Point(492, 235);
            this.BACK_BTN.Name = "BACK_BTN";
            this.BACK_BTN.Size = new System.Drawing.Size(100, 32);
            this.BACK_BTN.TabIndex = 26;
            this.BACK_BTN.Click += new System.EventHandler(this.BACK_BTN_Click);
            // 
            // ADD_BTN
            // 
            this.ADD_BTN.BackColor = System.Drawing.Color.Transparent;
            this.ADD_BTN.BaseColor = System.Drawing.Color.SlateGray;
            this.ADD_BTN.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.ADD_BTN.ButtonText = "ADD Image";
            this.ADD_BTN.Location = new System.Drawing.Point(376, 237);
            this.ADD_BTN.Name = "ADD_BTN";
            this.ADD_BTN.Size = new System.Drawing.Size(100, 32);
            this.ADD_BTN.TabIndex = 25;
            this.ADD_BTN.Click += new System.EventHandler(this.ADD_BTN_Click);
            // 
            // Trainingimages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(852, 483);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Trainingimages";
            this.Text = "Trainingimages";
            this.Load += new System.EventHandler(this.Trainingimages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.face_PICBX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox image_PICBX;
        private System.Windows.Forms.TextBox NAME_PERSON;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox face_PICBX;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private VistaButton vistaButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private VistaButton ADD_BTN;
        private VistaButton BACK_BTN;
        private VistaButton vistaButton4;
    }
}