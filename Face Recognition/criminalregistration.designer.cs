namespace  Face_Recognition
{
    partial class criminalregistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(criminalregistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.pic_photo = new System.Windows.Forms.PictureBox();
            this.btnfileupload = new System.Windows.Forms.Button();
            this.txtfilepath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datepick = new System.Windows.Forms.DateTimePicker();
            this.txtpdetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgviewcriminal = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnnew = new Face_Recognition.VistaButton();
            this.btnsave = new Face_Recognition.VistaButton();
            this.btnedit = new Face_Recognition.VistaButton();
            this.btndelete = new Face_Recognition.VistaButton();
            this.btnexit = new Face_Recognition.VistaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewcriminal)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.pic_photo);
            this.panel1.Controls.Add(this.btnfileupload);
            this.panel1.Controls.Add(this.txtfilepath);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.datepick);
            this.panel1.Controls.Add(this.txtpdetails);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgviewcriminal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 360);
            this.panel1.TabIndex = 2;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblid.Location = new System.Drawing.Point(501, 342);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(31, 16);
            this.lblid.TabIndex = 15;
            this.lblid.Text = "lblid";
            this.lblid.Visible = false;
            // 
            // pic_photo
            // 
            this.pic_photo.Location = new System.Drawing.Point(159, 3);
            this.pic_photo.Name = "pic_photo";
            this.pic_photo.Size = new System.Drawing.Size(179, 124);
            this.pic_photo.TabIndex = 14;
            this.pic_photo.TabStop = false;
            // 
            // btnfileupload
            // 
            this.btnfileupload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnfileupload.Location = new System.Drawing.Point(265, 309);
            this.btnfileupload.Name = "btnfileupload";
            this.btnfileupload.Size = new System.Drawing.Size(102, 24);
            this.btnfileupload.TabIndex = 13;
            this.btnfileupload.Text = "File Upload";
            this.btnfileupload.UseVisualStyleBackColor = true;
            this.btnfileupload.Click += new System.EventHandler(this.btnfileupload_Click);
            // 
            // txtfilepath
            // 
            this.txtfilepath.Location = new System.Drawing.Point(155, 309);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(113, 23);
            this.txtfilepath.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Photo:";
            // 
            // datepick
            // 
            this.datepick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datepick.Location = new System.Drawing.Point(159, 185);
            this.datepick.Name = "datepick";
            this.datepick.Size = new System.Drawing.Size(179, 23);
            this.datepick.TabIndex = 10;
            // 
            // txtpdetails
            // 
            this.txtpdetails.Location = new System.Drawing.Point(159, 224);
            this.txtpdetails.Multiline = true;
            this.txtpdetails.Name = "txtpdetails";
            this.txtpdetails.Size = new System.Drawing.Size(179, 79);
            this.txtpdetails.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(29, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Personal Details:";
            // 
            // dgviewcriminal
            // 
            this.dgviewcriminal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgviewcriminal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewcriminal.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgviewcriminal.Location = new System.Drawing.Point(462, 9);
            this.dgviewcriminal.Name = "dgviewcriminal";
            this.dgviewcriminal.Size = new System.Drawing.Size(331, 330);
            this.dgviewcriminal.TabIndex = 6;
            this.dgviewcriminal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewcriminal_CellClick);
            this.dgviewcriminal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewcriminal_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Of Birth:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(159, 133);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(179, 23);
            this.txtname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Transparent;
            this.btnnew.BaseColor = System.Drawing.Color.SlateGray;
            this.btnnew.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnnew.ButtonText = "New";
            this.btnnew.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnnew.Image = ((System.Drawing.Image)(resources.GetObject("btnnew.Image")));
            this.btnnew.Location = new System.Drawing.Point(301, 389);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(100, 32);
            this.btnnew.TabIndex = 18;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BaseColor = System.Drawing.Color.SlateGray;
            this.btnsave.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnsave.ButtonText = "Save";
            this.btnsave.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.Location = new System.Drawing.Point(407, 389);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 32);
            this.btnsave.TabIndex = 19;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnsave_MouseDown);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Transparent;
            this.btnedit.BaseColor = System.Drawing.Color.SlateGray;
            this.btnedit.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnedit.ButtonText = "Edit";
            this.btnedit.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnedit.Image = ((System.Drawing.Image)(resources.GetObject("btnedit.Image")));
            this.btnedit.Location = new System.Drawing.Point(513, 389);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 32);
            this.btnedit.TabIndex = 20;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.BaseColor = System.Drawing.Color.SlateGray;
            this.btndelete.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btndelete.ButtonText = "Delete";
            this.btndelete.GlowColor = System.Drawing.Color.SteelBlue;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.Location = new System.Drawing.Point(619, 389);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 32);
            this.btndelete.TabIndex = 21;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BaseColor = System.Drawing.Color.SlateGray;
            this.btnexit.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnexit.ButtonText = "Exit";
            this.btnexit.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(725, 389);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 32);
            this.btnexit.TabIndex = 22;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // criminalregistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(852, 433);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "criminalregistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "criminalregistration";
            this.Load += new System.EventHandler(this.criminalregistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewcriminal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnfileupload;
        private System.Windows.Forms.TextBox txtfilepath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datepick;
        private System.Windows.Forms.TextBox txtpdetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgviewcriminal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_photo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private VistaButton btnnew;
        private VistaButton btnsave;
        private VistaButton btnedit;
        private VistaButton btndelete;
        private VistaButton btnexit;
        private System.Windows.Forms.Label lblid;
    }
}