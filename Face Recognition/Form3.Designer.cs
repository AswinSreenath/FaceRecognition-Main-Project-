namespace Face_Recognition
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainingThroughPhotoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Faces_Found_Panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainToolStripMenuItem,
            this.trainingThroughPhotoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.trainToolStripMenuItem.Text = "Training Through Camera ";
            this.trainToolStripMenuItem.Click += new System.EventHandler(this.trainToolStripMenuItem_Click);
            // 
            // trainingThroughPhotoToolStripMenuItem
            // 
            this.trainingThroughPhotoToolStripMenuItem.Name = "trainingThroughPhotoToolStripMenuItem";
            this.trainingThroughPhotoToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.trainingThroughPhotoToolStripMenuItem.Text = "Training Through Photo ";
            this.trainingThroughPhotoToolStripMenuItem.Click += new System.EventHandler(this.trainingThroughPhotoToolStripMenuItem_Click);
            // 
            // Faces_Found_Panel
            // 
            this.Faces_Found_Panel.Location = new System.Drawing.Point(12, 40);
            this.Faces_Found_Panel.Name = "Faces_Found_Panel";
            this.Faces_Found_Panel.Size = new System.Drawing.Size(658, 366);
            this.Faces_Found_Panel.TabIndex = 2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(885, 473);
            this.Controls.Add(this.Faces_Found_Panel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainingThroughPhotoToolStripMenuItem;
        private System.Windows.Forms.Panel Faces_Found_Panel;
    }
}