namespace DentalClinicManagement
{
    partial class SelectDentist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDentist));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dentistCombobox = new ComboBox();
            Allergies = new TextBox();
            label15 = new Label();
            label2 = new Label();
            SaveButton = new Button();
            Cancel = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 115);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 75);
            label1.Name = "label1";
            label1.Size = new Size(266, 40);
            label1.TabIndex = 1;
            label1.Text = "Choose Dentist";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dentistCombobox
            // 
            dentistCombobox.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            dentistCombobox.FormattingEnabled = true;
            dentistCombobox.Location = new Point(12, 190);
            dentistCombobox.Name = "dentistCombobox";
            dentistCombobox.Size = new Size(774, 41);
            dentistCombobox.TabIndex = 3;
            dentistCombobox.SelectedIndexChanged += dentistCombobox_SelectedIndexChanged;
            // 
            // Allergies
            // 
            Allergies.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Allergies.Location = new Point(12, 320);
            Allergies.Name = "Allergies";
            Allergies.Size = new Size(774, 41);
            Allergies.TabIndex = 4;
            Allergies.TextChanged += Allergies_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.DodgerBlue;
            label15.Location = new Point(12, 147);
            label15.Name = "label15";
            label15.Size = new Size(266, 40);
            label15.TabIndex = 15;
            label15.Text = "Choose Dentist";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.DodgerBlue;
            label2.Location = new Point(12, 277);
            label2.Name = "label2";
            label2.Size = new Size(323, 40);
            label2.TabIndex = 16;
            label2.Text = "Enter Your Allergies";
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(258, 421);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(277, 66);
            SaveButton.TabIndex = 17;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // Cancel
            // 
            Cancel.ActiveLinkColor = Color.Black;
            Cancel.AutoSize = true;
            Cancel.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Cancel.LinkColor = Color.Black;
            Cancel.Location = new Point(340, 490);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(116, 34);
            Cancel.TabIndex = 18;
            Cancel.TabStop = true;
            Cancel.Text = "Cancel";
            Cancel.LinkClicked += Cancel_LinkClicked;
            // 
            // SelectDentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(798, 532);
            Controls.Add(Cancel);
            Controls.Add(SaveButton);
            Controls.Add(label2);
            Controls.Add(label15);
            Controls.Add(Allergies);
            Controls.Add(dentistCombobox);
            Controls.Add(panel1);
            Name = "SelectDentist";
            Text = "SelectDentist";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox dentistCombobox;
        private TextBox Allergies;
        private Label label15;
        private Label label2;
        private Button SaveButton;
        private LinkLabel Cancel;
    }
}