using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalClinicManagement.Classes;

namespace DentalClinicManagement
{
    public partial class SelectDentist : Form
    {
        List<Dentist> dentists = new List<Dentist>();

        public SelectDentist()
        {
            InitializeComponent();
            dentists.Add(new Dentist("Dr. John Smith", "Male", 45, "Surgical"));
            dentists.Add(new Dentist("Dr. Jane Doe", "Female", 35, "Pediatric"));
            dentists.Add(new Dentist("Dr. James Lee", "Male", 28, "Orthodonty"));

            if (dentistCombobox != null)
                foreach (Dentist d in dentists)
                    dentistCombobox.Items.Add(d.Name);

            dentistCombobox.DisplayMember = "Name";
        }
        
        private void dentistCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Allergies_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //if (dentists != null)
            //{
            //    int index = dentistCombobox.SelectedIndex;
            //    Dentist dentist = dentists[index];

            //    string allergies = Allergies.Text;

            //    Treatment treatment = new Treatment();

            //    Patient patient = new();
            //    patient.Allergies = allergies;

            //    if (patient.Appointments == null)
            //    {
            //        patient.Appointments = new List<Appointment>();
            //    }

            //    bool allergyIsTreatment = dentist.GetAppointments()
            //        .SelectMany(a => a?.Treatments)
            //        .Any(t => t.Type.Equals(allergies, StringComparison.OrdinalIgnoreCase));

            //    if (allergyIsTreatment)
            //    {
            //        MessageBox.Show($"The allergy {allergies} is already a treatment.");
            //        return;
            //    }
            //    Appointment app = new Appointment(DateTime.Now.AddDays(1));
            //    patient.BookAppointment(app);
            //    dentist.TreatPatient(patient, treatment);

            //    /*AppointmentsWindow appointments = new();
            //    /*appointments.SetDentistName(dentist.Name);*/
            //    /*appointments.Show();
            //    this.Hide();*/
            //}

        }
        private void Cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppointmentsWindow app = new();
            app.Show();
            this.Hide();
        }
    }
}
