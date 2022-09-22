using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientListAssignment
{
   
    public class PatientManager
    {
       
        private List<Patient> patients;
        public PatientManager()
        {
            patients = new List<Patient>();
        }
        public void AddPatient(Patient p)

        {
            patients.Add(p);
        }
        public int GetPositin(int pid)
        {
            int index = 0;
            foreach(Patient p in patients)
            {
                if(pid == p.patietnid)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
        public Patient FindPateint(int pid)
        {
            int position = GetPositin(pid);
            if(position == -1)
            {
                return null;
            }
            else
            {
                return patients[position];
            }
        }
        public bool DeletePatient(int pid)
        {
            int position = GetPositin(pid);
            if( position == -1)
            {
                return false;
            }
            else
            {
                patients.RemoveAt(position);
                return true;
            }
        }
        public List<Patient> GetAllPatients()
        {
            return patients;
        }
        public List<Patient> GetPatientByName(string name)
        {
            List<Patient> pt = new List<Patient>();
            foreach (var p in patients)
            {
                if (p.patientname == name)
                {
                    pt.Add(p);
                    
                }
            }
            return pt;
        }

            public List<Patient> GetPatientByGender(string gender)
            {
                List<Patient> pt = new List<Patient>();
                foreach (var p in patients)
                {
                    if (p.patientgender==gender)
                    {
                        pt.Add(p);
                        
                    }
                }
            return pt;
        }
        public int GenerateId()
        {
            int m = 0;
            foreach(Patient p in patients)
            {
                if (p.patietnid > m)
                {
                    m = p.patietnid;
                }
               
            }
            return m + 1;
        }
        public bool updatePatient(int pid, Patient p)
        {
            int position = GetPositin(pid);
            if(position== -1)
            {
                return false;

            }
            else
            {
                patients[position] = p;
                return true;
            }
        }
     }
}
