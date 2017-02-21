namespace  Face_Recognition
{
    partial class CrimeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrimeDetails));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.cmbcriminals = new System.Windows.Forms.ComboBox();
            this.cmbdept = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgviewcrime = new System.Windows.Forms.DataGridView();
            this.btnexit = new Face_Recognition.VistaButton();
            this.btnnew = new Face_Recognition.VistaButton();
            this.btnsave = new Face_Recognition.VistaButton();
            this.btnedit = new Face_Recognition.VistaButton();
            this.btndelete = new Face_Recognition.VistaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewcrime)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.txtaddr);
            this.panel1.Controls.Add(this.cmbcriminals);
            this.panel1.Controls.Add(this.cmbdept);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgviewcrime);
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 359);
            this.panel1.TabIndex = 2;
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(150, 142);
            this.txtaddr.Multiline = true;
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(172, 75);
            this.txtaddr.TabIndex = 19;
            // 
            // cmbcriminals
            // 
            this.cmbcriminals.FormattingEnabled = true;
            this.cmbcriminals.Items.AddRange(new object[] {
            "Select",
            "0",
            "1",
            "2"});
            this.cmbcriminals.Location = new System.Drawing.Point(150, 41);
            this.cmbcriminals.Name = "cmbcriminals";
            this.cmbcriminals.Size = new System.Drawing.Size(172, 24);
            this.cmbcriminals.TabIndex = 18;
            // 
            // cmbdept
            // 
            this.cmbdept.FormattingEnabled = true;
            this.cmbdept.Items.AddRange(new object[] {
            "Select",
            "0",
            "1",
            "2"});
            this.cmbdept.Location = new System.Drawing.Point(150, 93);
            this.cmbdept.Name = "cmbdept";
            this.cmbdept.Size = new System.Drawing.Size(172, 24);
            this.cmbdept.TabIndex = 17;
            this.cmbdept.SelectedIndexChanged += new System.EventHandler(this.cmbdept_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(31, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Department:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(31, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Crime Details:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(31, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Criminals:";
            // 
            // dgviewcrime
            // 
            this.dgviewcrime.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgviewcrime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewcrime.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dgviewcrime.Location = new System.Drawing.Point(415, 3);
            this.dgviewcrime.Name = "dgviewcrime";
            this.dgviewcrime.Size = new System.Drawing.Size(362, 341);
            this.dgviewcrime.TabIndex = 6;
            this.dgviewcrime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewcrime_CellClick);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BaseColor = System.Drawing.Color.SlateGray;
            this.btnexit.ButtonColor = System.Drawing.Color.LightSlateGray;
            this.btnexit.ButtonText = "Exit";
            this.btnexit.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnexit.Image = global::Face_Recognition.Properties.Resources.Exit_button;
            this.btnexit.Location = new System.Drawing.Point(727, 389);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 32);
            this.btnexit.TabIndex = 17;
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
            this.btnnew.Location = new System.Drawing.Point(303, 389);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(100, 32);
            this.btnnew.TabIndex = 13;
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
            this.btnsave.Location = new System.Drawing.Point(409, 389);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 32);
            this.btnsave.TabIndex = 14;
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
            this.btnedit.Location = new System.Drawing.Point(515, 389);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(100, 32);
            this.btnedit.TabIndex = 15;
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
            this.btndelete.Location = new System.Drawing.Point(621, 389);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 32);
            this.btndelete.TabIndex = 16;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // CrimeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(852, 433);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CrimeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrimeDetails";
            this.Load += new System.EventHandler(this.CrimeDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewcrime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbcriminals;
        private System.Windows.Forms.ComboBox cmbdept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgviewcrime;
        private System.Windows.Forms.TextBox txtaddr;
        private VistaButton btnnew;
        private VistaButton btnsave;
        private VistaButton btnedit;
        private VistaButton btndelete;
        private VistaButton btnexit;
    }
}