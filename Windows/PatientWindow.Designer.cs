namespace DentalClinicManagement
{
    partial class PatientWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientWindow));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label7 = new Label();
            pictureBox5 = new PictureBox();
            label9 = new Label();
            pictureBox7 = new PictureBox();
            label8 = new Label();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            panel2 = new Panel();
            BirthdateText = new DateTimePicker();
            EditButton = new Button();
            DeleteButton = new Button();
            GenderBox = new ComboBox();
            AllergiesText = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label13 = new Label();
            label14 = new Label();
            PhoneText = new TextBox();
            AddressText = new TextBox();
            label12 = new Label();
            NameText = new TextBox();
            SaveButtonTreatment = new Button();
            label11 = new Label();
            PatientDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label15 = new Label();
            FilterByPatientTextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 771);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(80, 436);
            label7.Name = "label7";
            label7.Size = new Size(141, 34);
            label7.TabIndex = 20;
            label7.Text = "Checkup";
            label7.Click += label7_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(12, 414);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 56);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(82, 725);
            label9.Name = "label9";
            label9.Size = new Size(110, 34);
            label9.TabIndex = 16;
            label9.Text = "Logout";
            label9.Click += label9_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 703);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(61, 56);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(80, 663);
            label8.Name = "label8";
            label8.Size = new Size(166, 34);
            label8.TabIndex = 14;
            label8.Text = "Dashboard";
            label8.Click += label8_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 641);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(61, 56);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(80, 367);
            label6.Name = "label6";
            label6.Size = new Size(173, 34);
            label6.TabIndex = 10;
            label6.Text = "Prescription";
            label6.Click += label6_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(12, 345);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 56);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(79, 296);
            label5.Name = "label5";
            label5.Size = new Size(152, 34);
            label5.TabIndex = 8;
            label5.Text = "Treatment";
            label5.Click += label5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 274);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(79, 221);
            label4.Name = "label4";
            label4.Size = new Size(197, 34);
            label4.TabIndex = 6;
            label4.Text = "Appointment";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 199);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(137, 89);
            label3.Name = "label3";
            label3.Size = new Size(113, 34);
            label3.TabIndex = 4;
            label3.Text = "Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(137, 49);
            label2.Name = "label2";
            label2.Size = new Size(108, 40);
            label2.TabIndex = 3;
            label2.Text = "Clinic";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(137, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 40);
            label1.TabIndex = 2;
            label1.Text = "Dental";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.White;
            label10.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.DodgerBlue;
            label10.Location = new Point(347, 9);
            label10.Name = "label10";
            label10.Size = new Size(134, 40);
            label10.TabIndex = 7;
            label10.Text = "Patient";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(BirthdateText);
            panel2.Controls.Add(EditButton);
            panel2.Controls.Add(DeleteButton);
            panel2.Controls.Add(GenderBox);
            panel2.Controls.Add(AllergiesText);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(PhoneText);
            panel2.Controls.Add(AddressText);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(NameText);
            panel2.Controls.Add(SaveButtonTreatment);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(347, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(1146, 322);
            panel2.TabIndex = 6;
            // 
            // BirthdateText
            // 
            BirthdateText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            BirthdateText.Format = DateTimePickerFormat.Short;
            BirthdateText.Location = new Point(836, 18);
            BirthdateText.Name = "BirthdateText";
            BirthdateText.Size = new Size(295, 41);
            BirthdateText.TabIndex = 26;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(187, 244);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(243, 66);
            EditButton.TabIndex = 25;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(685, 244);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(243, 66);
            DeleteButton.TabIndex = 24;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // GenderBox
            // 
            GenderBox.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            GenderBox.FormattingEnabled = true;
            GenderBox.Items.AddRange(new object[] { "Male", "Female" });
            GenderBox.Location = new Point(837, 77);
            GenderBox.Name = "GenderBox";
            GenderBox.Size = new Size(295, 41);
            GenderBox.TabIndex = 23;
            // 
            // AllergiesText
            // 
            AllergiesText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AllergiesText.Location = new Point(837, 128);
            AllergiesText.Multiline = true;
            AllergiesText.Name = "AllergiesText";
            AllergiesText.Size = new Size(295, 107);
            AllergiesText.TabIndex = 22;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.DodgerBlue;
            label17.Location = new Point(682, 131);
            label17.Name = "label17";
            label17.Size = new Size(149, 40);
            label17.TabIndex = 21;
            label17.Text = "Allergies";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.DodgerBlue;
            label16.Location = new Point(685, 77);
            label16.Name = "label16";
            label16.Size = new Size(145, 40);
            label16.TabIndex = 20;
            label16.Text = "Gender";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.DodgerBlue;
            label13.Location = new Point(610, 18);
            label13.Name = "label13";
            label13.Size = new Size(220, 40);
            label13.TabIndex = 19;
            label13.Text = "Date of Birth";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.DodgerBlue;
            label14.Location = new Point(12, 75);
            label14.Name = "label14";
            label14.Size = new Size(123, 40);
            label14.TabIndex = 18;
            label14.Text = "Phone";
            // 
            // PhoneText
            // 
            PhoneText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneText.Location = new Point(135, 78);
            PhoneText.Name = "PhoneText";
            PhoneText.Size = new Size(295, 41);
            PhoneText.TabIndex = 17;
            PhoneText.TextChanged += textBox1_TextChanged;
            // 
            // AddressText
            // 
            AddressText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            AddressText.Location = new Point(162, 125);
            AddressText.Multiline = true;
            AddressText.Name = "AddressText";
            AddressText.Size = new Size(268, 110);
            AddressText.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.DodgerBlue;
            label12.Location = new Point(12, 131);
            label12.Name = "label12";
            label12.Size = new Size(144, 40);
            label12.TabIndex = 15;
            label12.Text = "Address";
            // 
            // NameText
            // 
            NameText.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            NameText.Location = new Point(135, 17);
            NameText.Name = "NameText";
            NameText.Size = new Size(295, 41);
            NameText.TabIndex = 13;
            NameText.TextChanged += NameText_TextChanged;
            // 
            // SaveButtonTreatment
            // 
            SaveButtonTreatment.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButtonTreatment.Location = new Point(436, 244);
            SaveButtonTreatment.Name = "SaveButtonTreatment";
            SaveButtonTreatment.Size = new Size(243, 66);
            SaveButtonTreatment.TabIndex = 11;
            SaveButtonTreatment.Text = "Save";
            SaveButtonTreatment.UseVisualStyleBackColor = true;
            SaveButtonTreatment.Click += SaveButtonTreatment_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DodgerBlue;
            label11.Location = new Point(12, 18);
            label11.Name = "label11";
            label11.Size = new Size(117, 40);
            label11.TabIndex = 4;
            label11.Text = "Name";
            // 
            // PatientDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            PatientDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            PatientDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            PatientDGV.ColumnHeadersHeight = 4;
            PatientDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            PatientDGV.DefaultCellStyle = dataGridViewCellStyle3;
            PatientDGV.GridColor = Color.FromArgb(231, 229, 255);
            PatientDGV.Location = new Point(347, 446);
            PatientDGV.Name = "PatientDGV";
            PatientDGV.RowHeadersVisible = false;
            PatientDGV.RowHeadersWidth = 51;
            PatientDGV.RowTemplate.Height = 29;
            PatientDGV.Size = new Size(1146, 313);
            PatientDGV.TabIndex = 14;
            PatientDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            PatientDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            PatientDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            PatientDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            PatientDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            PatientDGV.ThemeStyle.BackColor = Color.White;
            PatientDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            PatientDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            PatientDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            PatientDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PatientDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            PatientDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            PatientDGV.ThemeStyle.HeaderStyle.Height = 4;
            PatientDGV.ThemeStyle.ReadOnly = false;
            PatientDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            PatientDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PatientDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PatientDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            PatientDGV.ThemeStyle.RowsStyle.Height = 29;
            PatientDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            PatientDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            PatientDGV.CellContentClick += PatientDGV_CellContentClick;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.DodgerBlue;
            label15.Location = new Point(783, 377);
            label15.Name = "label15";
            label15.Size = new Size(226, 34);
            label15.TabIndex = 13;
            label15.Text = "Filter by Patient";
            // 
            // FilterByPatientTextBox
            // 
            FilterByPatientTextBox.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FilterByPatientTextBox.Location = new Point(742, 414);
            FilterByPatientTextBox.Name = "FilterByPatientTextBox";
            FilterByPatientTextBox.Size = new Size(310, 26);
            FilterByPatientTextBox.TabIndex = 12;
            FilterByPatientTextBox.TextChanged += FilterByPatientTextBox_TextChanged;
            // 
            // PatientWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1505, 771);
            Controls.Add(PatientDGV);
            Controls.Add(label15);
            Controls.Add(FilterByPatientTextBox);
            Controls.Add(label10);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PatientWindow";
            Text = "Patient";
            Load += PatientWindow_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private PictureBox pictureBox7;
        private Label label8;
        private PictureBox pictureBox6;
        private Label label6;
        private PictureBox pictureBox4;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label10;
        private Panel panel2;
        private TextBox AddressText;
        private Label label12;
        private TextBox NameText;
        private Button SaveButtonTreatment;
        private Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView PatientDGV;
        private Label label15;
        private TextBox FilterByPatientTextBox;
        private Label label14;
        private TextBox PhoneText;
        private TextBox AllergiesText;
        private Label label17;
        private Label label16;
        private Label label13;
        private ComboBox GenderBox;
        private Button EditButton;
        private Button DeleteButton;
        private DateTimePicker BirthdateText;
        private Label label7;
        private PictureBox pictureBox5;
    }
}