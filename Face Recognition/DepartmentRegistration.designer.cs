namespace  Face_Recognition
{
    partial class DepartmentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentRegistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgviewdept = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.txtdeptname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new Face_Recognition.VistaButton();
            this.btnnew = new Face_Recognition.VistaButton();
            this.btnsave = new Face_Recognition.VistaButton();
            this.btnedit = new Face_Recognition.VistaButton();
            this.btndelete = new Face_Recognition.VistaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewdept)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.dgviewdept);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtdesc);
            this.panel1.Controls.Add(this.txtdeptname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 359);
            this.panel1.TabIndex = 0;
            // 
            // dgviewdept
            // 
            this.dgviewdept.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgviewdept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewdept.Location = new System.Drawing.Point(437, 17);
            this.dgviewdept.Name = "dgviewdept";
            this.dgviewdept.Size = new System.Drawing.Size(340, 327);
            this.dgviewdept.TabIndex = 6;
            this.dgviewdept.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewdept_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(144, 67);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(201, 84);
            this.txtdesc.TabIndex = 2;
            // 
            // txtdeptname
            // 
            this.txtdeptname.Location = new System.Drawing.Point(144, 26);
            this.txtdeptname.Name = "txtdeptname";
            this.txtdeptname.Size = new System.Drawing.Size(201, 23);
            this.txtdeptname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Department Name";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BaseColor = System.Drawing.Color.SlateGray;
            this.btnexit.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnexit.ButtonText = "Exit";
            this.btnexit.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnexit.Image = global::Face_Recognition.Properties.Resources.Exit_button;
            this.btnexit.Location = new System.Drawing.Point(726, 390);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 32);
            this.btnexit.TabIndex = 12;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Transparent;
            this.btnnew.BaseColor = System.Drawing.Color.SlateGray;
            this.btnnew.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnnew.ButtonText = "New";
            this.btnnew.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnnew.Image = global::Face_Recognition.Properties.Resources.label_new_blue;
            this.btnnew.Location = new System.Drawing.Point(302, 390);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(100, 32);
            this.btnnew.TabIndex = 8;
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
            this.btnsave.Location = new System.Drawing.Point(408, 390);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 32);
            this.btnsave.TabIndex = 9;
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
            this.btnedit.Location = new System.Drawing.Point(514, 390);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 32);
            this.btnedit.TabIndex = 10;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.BaseColor = System.Drawing.Color.SlateGray;
            this.btndelete.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btndelete.ButtonText = "Delete";
            this.btndelete.GlowColor = System.Drawing.Color.SteelBlue;
            this.btndelete.Image = global::Face_Recognition.Properties.Resources.Delete_icon;
            this.btndelete.Location = new System.Drawing.Point(620, 390);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 32);
            this.btndelete.TabIndex = 11;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // DepartmentRegistration
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
            this.Name = "DepartmentRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepartmentRegistration";
            this.Load += new System.EventHandler(this.DepartmentRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewdept)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgviewdept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox txtdeptname;
        private System.Windows.Forms.Label label1;
        private VistaButton btnnew;
        private VistaButton btnsave;
        private VistaButton btnedit;
        private VistaButton btndelete;
        private VistaButton btnexit;
    }
}