using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using DentalClinicManagement.Classes;

namespace DentalClinicManagement.LessImportantClasses
{
    public class PatientRecordLoader
    {
        private readonly string? _filePath;

        public PatientRecordLoader(string? filePath)
        {
            _filePath = filePath;
        }
        public void Save(List<Patient> patientRecords)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Patient>));
            using FileStream? stream = _filePath != null ? new FileStream(_filePath, FileMode.Create) : null;
            if (stream != null)
            {
                serializer.Serialize(stream, patientRecords);
                stream.Close();
            }
        }

        public List<Patient> Load()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Patient>));
            using FileStream? stream = _filePath != null ? new FileStream(_filePath, FileMode.Open) : null;
            if (stream == null)
            {
                return new List<Patient>();
            }
            List<Patient>? records = (List<Patient>?)serializer.Deserialize(stream);
            return records ?? new List<Patient>();
        }
    }
}
