namespace Face_Recognition
{
    partial class Analysis
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
            this.vistaButton1 = new Face_Recognition.VistaButton();
            this.Faces_Found_Panel = new System.Windows.Forms.Panel();
            this.image_PICBX = new System.Windows.Forms.PictureBox();
            this.btnedit = new Face_Recognition.VistaButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnfupload = new Face_Recognition.VistaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // vistaButton1
            // 
            this.vistaButton1.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton1.BaseColor = System.Drawing.Color.SlateGray;
            this.vistaButton1.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.vistaButton1.ButtonText = "Analysis";
            this.vistaButton1.Location = new System.Drawing.Point(154, 105);
            this.vistaButton1.Name = "vistaButton1";
            this.vistaButton1.Size = new System.Drawing.Size(100, 32);
            this.vistaButton1.TabIndex = 27;
            this.vistaButton1.Click += new System.EventHandler(this.vistaButton1_Click);
            // 
            // Faces_Found_Panel
            // 
            this.Faces_Found_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Faces_Found_Panel.AutoScroll = true;
            this.Faces_Found_Panel.BackColor = System.Drawing.Color.White;
            this.Faces_Found_Panel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Faces_Found_Panel.Location = new System.Drawing.Point(375, 19);
            this.Faces_Found_Panel.Name = "Faces_Found_Panel";
            this.Faces_Found_Panel.Size = new System.Drawing.Size(188, 180);
            this.Faces_Found_Panel.TabIndex = 29;
            this.Faces_Found_Panel.Visible = false;
            this.Faces_Found_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Faces_Found_Panel_Paint);
            // 
            // image_PICBX
            // 
            this.image_PICBX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.image_PICBX.Location = new System.Drawing.Point(18, 3);
            this.image_PICBX.Name = "image_PICBX";
            this.image_PICBX.Size = new System.Drawing.Size(322, 225);
            this.image_PICBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_PICBX.TabIndex = 28;
            this.image_PICBX.TabStop = false;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Transparent;
            this.btnedit.BaseColor = System.Drawing.Color.SlateGray;
            this.btnedit.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnedit.ButtonText = "View";
            this.btnedit.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnedit.Image = global::Face_Recognition.Properties.Resources.search_64;
            this.btnedit.Location = new System.Drawing.Point(214, 219);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 32);
            this.btnedit.TabIndex = 30;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnfupload);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.vistaButton1);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 201);
            this.panel1.TabIndex = 32;
            // 
            // btnfupload
            // 
            this.btnfupload.BackColor = System.Drawing.Color.Transparent;
            this.btnfupload.BaseColor = System.Drawing.Color.SlateGray;
            this.btnfupload.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnfupload.ButtonText = "File Upload";
            this.btnfupload.Location = new System.Drawing.Point(186, 42);
            this.btnfupload.Name = "btnfupload";
            this.btnfupload.Size = new System.Drawing.Size(114, 32);
            this.btnfupload.TabIndex = 29;
            this.btnfupload.Click += new System.EventHandler(this.btnfupload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(375, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.image_PICBX);
            this.panel2.Controls.Add(this.Faces_Found_Panel);
            this.panel2.Location = new System.Drawing.Point(14, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 231);
            this.panel2.TabIndex = 33;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(781, 501);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnedit);
            this.Name = "Analysis";
            this.Text = "Analysis";
            this.Load += new System.EventHandler(this.Analysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_PICBX)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VistaButton vistaButton1;
        private System.Windows.Forms.Panel Faces_Found_Panel;
        private System.Windows.Forms.PictureBox image_PICBX;
        private VistaButton btnedit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private VistaButton btnfupload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
    }
}