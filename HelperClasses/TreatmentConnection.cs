﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalClinicManagement.LessImportantClasses
{
    internal class TreatmentConnection
    {
        public void AddPatient(string query)
        {
            Connection connection = new Connection();
            SqlConnection conn = connection.GetConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void DeletePatient(string query)
        {
            Connection connection = new Connection();
            SqlConnection conn = connection.GetConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdatePatient(string query)
        {
            Connection connection = new Connection();
            SqlConnection conn = connection.GetConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            conn.Open();
            command.CommandText = query;
            command.ExecuteNonQuery();
            conn.Close();
        }

        public DataSet ShowPatient(string query)
        {
            Connection connection = new Connection();
            SqlConnection conn = connection.GetConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }
    }
}
