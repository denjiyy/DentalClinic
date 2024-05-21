﻿namespace DentalClinicManagement
{
    partial class LoadingWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingWindow));
            pictureBox1 = new PictureBox();
            Loading = new ProgressBar();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Loading
            // 
            Loading.Location = new Point(12, 309);
            Loading.Name = "Loading";
            Loading.Size = new Size(357, 37);
            Loading.TabIndex = 2;
            Loading.Click += Loading_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(82, 249);
            label1.Name = "label1";
            label1.Size = new Size(226, 40);
            label1.TabIndex = 3;
            label1.Text = "Dental Clinic";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // LoadingWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(381, 413);
            Controls.Add(label1);
            Controls.Add(Loading);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingWindow";
            Text = "LoadingWindow";
            Load += LoadingWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ProgressBar Loading;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}