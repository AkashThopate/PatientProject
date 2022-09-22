using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientListAssignment
{
    public class Patient
    {
        private int PatientID;
        private string PatientName;
        private string PatientGender;
        private string PatientMobile;
        private int PatientWeight;
        private int PatientHeight;
        private string Disease;
        public Patient()
        {

        }
        public Patient(int patientID, string patientName, string patientGender, string patientMobile, int patientWeight, int patientHeight, string disease)
        {
            PatientID = patientID;
            PatientName = patientName;
            PatientGender = patientGender;
            PatientMobile = patientMobile;
            PatientWeight = patientWeight;
            PatientHeight = patientHeight;
            Disease = disease;
        }

    public int patietnid
        {
            get { return PatientID; }
            set { PatientID = value; }
        }
        public string patientname
        {
            get { return PatientName; }
            set { PatientName = value; }
        }
        public string patientgender
        {
            set { PatientGender = value; }
            get { return PatientGender; }
        }
        public string patientmobile
        {
            set { PatientMobile = value; }
            get { return PatientMobile; }
        }
        public int patientweight
        {
            get { return PatientWeight; }
            set { PatientWeight = value; }

        }
        public int patientheight
        {
            get { return PatientHeight; }
            set { PatientHeight = value; }
        }
        public string disease
        {
            set { Disease = value; }
            get { return Disease; }
        }
        public override string ToString()
        {
            return $"Patient ID : {PatientID}\nPatient Name : {PatientName}\nPatient Gender : {PatientGender}\n" +
                $"Patient Mobile : {PatientMobile}\nPatient Weight : {PatientWeight}\nPatient Height : {PatientHeight}\nPatient Diseas : {Disease}";
        }
    }
}
