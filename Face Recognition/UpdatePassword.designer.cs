namespace Face_Recognition
{
    partial class UpdatePassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnexit = new Face_Recognition.VistaButton();
            this.btnupdate = new Face_Recognition.VistaButton();
            this.txtrpwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnpwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtopwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.txtrpwd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtnpwd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtopwd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 258);
            this.panel1.TabIndex = 0;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BaseColor = System.Drawing.Color.Teal;
            this.btnexit.ButtonColor = System.Drawing.Color.SkyBlue;
            this.btnexit.ButtonText = "Exit";
            this.btnexit.GlowColor = System.Drawing.Color.SteelBlue;
            this.btnexit.Image = global::Face_Recognition.Properties.Resources.Exit_button;
            this.btnexit.Location = new System.Drawing.Point(221, 174);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(115, 32);
            this.btnexit.TabIndex = 29;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Transparent;
            this.btnupdate.BaseColor = System.Drawing.Color.Teal;
            this.btnupdate.ButtonColor = System.Drawing.Color.SkyBlue;
            this.btnupdate.ButtonText = "Update Password";
            this.btnupdate.Location = new System.Drawing.Point(39, 174);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(125, 32);
            this.btnupdate.TabIndex = 28;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtrpwd
            // 
            this.txtrpwd.Location = new System.Drawing.Point(142, 126);
            this.txtrpwd.Name = "txtrpwd";
            this.txtrpwd.PasswordChar = '*';
            this.txtrpwd.Size = new System.Drawing.Size(179, 20);
            this.txtrpwd.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Retype  Password:";
            // 
            // txtnpwd
            // 
            this.txtnpwd.Location = new System.Drawing.Point(142, 80);
            this.txtnpwd.Name = "txtnpwd";
            this.txtnpwd.PasswordChar = '*';
            this.txtnpwd.Size = new System.Drawing.Size(179, 20);
            this.txtnpwd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New Password:";
            // 
            // txtopwd
            // 
            this.txtopwd.Location = new System.Drawing.Point(142, 26);
            this.txtopwd.Name = "txtopwd";
            this.txtopwd.PasswordChar = '*';
            this.txtopwd.Size = new System.Drawing.Size(179, 20);
            this.txtopwd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old Password:";
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(472, 347);
            this.Controls.Add(this.panel1);
            this.Name = "UpdatePassword";
            this.Text = "UpdatePassword";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtrpwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnpwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtopwd;
        private System.Windows.Forms.Label label1;
        private VistaButton btnupdate;
        private VistaButton btnexit;

    }
}