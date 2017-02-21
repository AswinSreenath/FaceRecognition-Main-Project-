namespace  Face_Recognition
{
    partial class StaffRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbprivilege = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgviewstaff = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnew = new Face_Recognition.VistaButton();
            this.btnsave = new Face_Recognition.VistaButton();
            this.btnedit = new Face_Recognition.VistaButton();
            this.btndelete = new Face_Recognition.VistaButton();
            this.btnexit = new Face_Recognition.VistaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewstaff)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.cmbprivilege);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtpwd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtuname);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtphno);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgviewstaff);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtaddr);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 379);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbprivilege
            // 
            this.cmbprivilege.FormattingEnabled = true;
            this.cmbprivilege.Items.AddRange(new object[] {
            "Select",
            "0",
            "1",
            "2"});
            this.cmbprivilege.Location = new System.Drawing.Point(157, 225);
            this.cmbprivilege.Name = "cmbprivilege";
            this.cmbprivilege.Size = new System.Drawing.Size(157, 24);
            this.cmbprivilege.TabIndex = 17;
            this.cmbprivilege.SelectedIndexChanged += new System.EventHandler(this.cmbprivilege_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(38, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Privileges:";
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(157, 315);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(157, 23);
            this.txtpwd.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(38, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password:";
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(157, 271);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(157, 23);
            this.txtuname.TabIndex = 13;
            this.txtuname.TextChanged += new System.EventHandler(this.txtuname_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(38, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "UserName:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(157, 183);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(157, 23);
            this.txtemail.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(38, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // txtphno
            // 
            this.txtphno.Location = new System.Drawing.Point(157, 137);
            this.txtphno.Name = "txtphno";
            this.txtphno.Size = new System.Drawing.Size(157, 23);
            this.txtphno.TabIndex = 9;
            this.txtphno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphno_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(38, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone No:";
            // 
            // dgviewstaff
            // 
            this.dgviewstaff.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgviewstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgviewstaff.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgviewstaff.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgviewstaff.Location = new System.Drawing.Point(378, 15);
            this.dgviewstaff.Name = "dgviewstaff";
            this.dgviewstaff.Size = new System.Drawing.Size(331, 323);
            this.dgviewstaff.TabIndex = 6;
            this.dgviewstaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewstaff_CellClick);
            this.dgviewstaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewstaff_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(157, 70);
            this.txtaddr.Multiline = true;
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(157, 50);
            this.txtaddr.TabIndex = 2;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(157, 26);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(157, 23);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(38, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = " Name:";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Transparent;
            this.btnnew.BaseColor = System.Drawing.Color.SlateGray;
            this.btnnew.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnnew.ButtonText = "New";
            this.btnnew.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnnew.Image = global::Face_Recognition.Properties.Resources.label_new_blue;
            this.btnnew.Location = new System.Drawing.Point(261, 404);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(100, 32);
            this.btnnew.TabIndex = 23;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Transparent;
            this.btnsave.BaseColor = System.Drawing.Color.SlateGray;
            this.btnsave.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnsave.ButtonText = "Save";
            this.btnsave.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnsave.Image = global::Face_Recognition.Properties.Resources.Save1;
            this.btnsave.Location = new System.Drawing.Point(367, 404);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 32);
            this.btnsave.TabIndex = 24;
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
            this.btnedit.Image = global::Face_Recognition.Properties.Resources.file_edit;
            this.btnedit.Location = new System.Drawing.Point(473, 404);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 32);
            this.btnedit.TabIndex = 25;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            this.btnedit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnedit_MouseDown);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.BaseColor = System.Drawing.Color.SlateGray;
            this.btndelete.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btndelete.ButtonText = "Delete";
            this.btndelete.GlowColor = System.Drawing.Color.SteelBlue;
            this.btndelete.Image = global::Face_Recognition.Properties.Resources.Delete_icon;
            this.btndelete.Location = new System.Drawing.Point(579, 404);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 32);
            this.btndelete.TabIndex = 26;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            this.btndelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btndelete_MouseDown);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BaseColor = System.Drawing.Color.SlateGray;
            this.btnexit.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnexit.ButtonText = "Exit";
            this.btnexit.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnexit.Image = global::Face_Recognition.Properties.Resources.Exit_button;
            this.btnexit.Location = new System.Drawing.Point(685, 404);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 32);
            this.btnexit.TabIndex = 27;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // StaffRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(852, 448);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StaffRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffRegistration";
            this.Load += new System.EventHandler(this.StaffRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewstaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtphno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgviewstaff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbprivilege;
        private VistaButton btnnew;
        private VistaButton btnsave;
        private VistaButton btnedit;
        private VistaButton btndelete;
        private VistaButton btnexit;
    }
}