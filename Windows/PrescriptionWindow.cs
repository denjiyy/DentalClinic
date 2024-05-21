using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalClinicManagement.LessImportantClasses;

namespace DentalClinicManagement
{
    public partial class PrescriptionWindow : Form
    {
        public PrescriptionWindow()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();

        private void FillPatient()
        {
            SqlConnection connection = conn.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT DISTINCT Patient FROM AppointmentTable", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Patient", typeof(string));
            dataTable.Load(reader);
            TreatmentPatientCombobox.DisplayMember = "Patient";
            TreatmentPatientCombobox.ValueMember = "Patient";
            TreatmentPatientCombobox.DataSource = dataTable;
            connection.Close();
        }
        private void FillTreatment()
        {
            SqlConnection connection = conn.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select TreatmentName from TreatmentTable", connection);
            SqlDataReader reader;
            reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Patient", typeof(string));
            dataTable.Load(reader);
            TreatmentPatientCombobox.ValueMember = "Patient";
            TreatmentPatientCombobox.DataSource = dataTable;
            connection.Close();

        }
        private void GetTreatment()
        {
            SqlConnection connection = conn.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from AppointmentTable where Patient='" + TreatmentPatientCombobox.SelectedValue?.ToString() + "'", connection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                PrescriptionTreatmentTextBox.Text = row["Treatment"].ToString();
            }
            connection.Close();
        }
        private void GetPrice()
        {
            SqlConnection connection = conn.GetConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TreatmentTable where TreatmentName='" + PrescriptionTreatmentCostTextBox.Text + "'", connection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                PrescriptionTreatmentCostTextBox.Text = row["TreatmentCost"].ToString();
            }
            connection.Close();
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void PrescriptionWindow_Load(object sender, EventArgs e)
        {
            FillPatient();
            Populate();
        }

        private void TreatmentPatientCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTreatment();
        }

        private void PrescriptionTreatmentTextBox_TextChanged(object sender, EventArgs e)
        {
            GetPrice();
        }
        void Populate()
        {
            PatientFunctions patient = new PatientFunctions();
            string query = "select * from PrescriptionTable";

            DataSet dataSet = patient.ShowPatient(query);
            PrescriptionDGV.DataSource = dataSet.Tables[0];
        }
        private void SaveButtonAppointment_Click(object sender, EventArgs e)
        {
            string query = "insert into PrescriptionTable (PatientName, TreatmentName, TreatmentCost, Medicine, MedicineQuantity) values('" + TreatmentPatientCombobox.SelectedValue?.ToString() + "','" + PrescriptionTreatmentTextBox.Text + "','" + PrescriptionTreatmentCostTextBox.Text + "','" + TreatmentMedicineTextBox.Text + "','" + TreatmentQuantityTextBox.Text + "')";
            PatientFunctions patient = new PatientFunctions();
            try
            {
                patient.AddPatient(query);
                MessageBox.Show("Treatment Successfully Added");
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int key = 0;
        private void PrescriptionDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TreatmentPatientCombobox.SelectedValue = PrescriptionDGV.SelectedRows[0].Cells[1].Value.ToString();
            PrescriptionTreatmentTextBox.Text = PrescriptionDGV.SelectedRows[0].Cells[2].Value.ToString();
            PrescriptionTreatmentCostTextBox.Text = PrescriptionDGV.SelectedRows[0].Cells[3].Value.ToString();
            TreatmentMedicineTextBox.Text = PrescriptionDGV.SelectedRows[0].Cells[4].Value.ToString();
            TreatmentQuantityTextBox.Text = PrescriptionDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (PrescriptionTreatmentTextBox.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(PrescriptionDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteButtonPrescription_Click(object sender, EventArgs e)
        {
            PatientFunctions patient = new PatientFunctions();
            if (key == 0)
            {
                MessageBox.Show("Select the Prescription");
            }
            else
            {
                try
                {
                    string query = "Delete from PrescriptionTable where PrescriptionID=" + key + "";
                    patient.DeletePatient(query);
                    MessageBox.Show("Prescription Successfully Deleted");
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        void Filter()
        {
            PatientFunctions patient = new PatientFunctions();
            string query = "select * from PrescriptionTable where PatientName like '%" + FilterByPatientTextBox.Text + "%'";
            DataSet dataSet = patient.ShowPatient(query);
            PrescriptionDGV.DataSource = dataSet.Tables[0];
        }
        private void FilterByPatientTextBox_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        Bitmap bitmap;
        private void PrescriptionPrintButton_Click(object sender, EventArgs e)
        {
            // Get the DataGridView's height
            int height = PrescriptionDGV.Height;
            // Double the height to show more rows in print preview
            PrescriptionDGV.Height = PrescriptionDGV.RowCount * PrescriptionDGV.RowTemplate.Height * 2;
            // Create a Bitmap object of the DataGridView
            bitmap = new Bitmap(PrescriptionDGV.Width, PrescriptionDGV.Height);
            PrescriptionDGV.DrawToBitmap(bitmap, new Rectangle(0, 10, PrescriptionDGV.Width, PrescriptionDGV.Height));
            // Reset the DataGridView's height
            PrescriptionDGV.Height = height;
            // Show the print preview dialog
            printPreviewDialog1.ShowDialog();

            // Save the data to an XML file
            string fileName = "PrescriptionData.xml";
            DataTable dataTable = new DataTable("PrescriptionDataTable"); // Set the DataTable name to "PrescriptionDataTable"
            foreach (DataGridViewColumn column in PrescriptionDGV.Columns)
            {
                dataTable.Columns.Add(column.HeaderText, typeof(string));
            }
            foreach (DataGridViewRow row in PrescriptionDGV.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dataRow[cell.ColumnIndex] = cell.Value;
                }
                dataTable.Rows.Add(dataRow);
            }

            dataTable.WriteXml(fileName);
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (bitmap != null)
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PatientWindow patient = new PatientWindow();
            patient.Show();
            this.Hide();
        }

        private void label11_Click_1(object sender, EventArgs e)
        {
            /*AppointmentsWindow appointment = new AppointmentsWindow();
            appointment.Show();
            this.Hide();*/
        }

        private void label6_Click(object sender, EventArgs e)
        {
            TreatmentWindow treatment = new TreatmentWindow();
            treatment.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            DashBoardWindow dashBoard = new DashBoardWindow();
            dashBoard.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            LoginWindow login = new LoginWindow();
            login.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            CheckupWindow checkup = new();
            checkup.Show();
            this.Hide();
        }

        private void TreatmentMedicineTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
