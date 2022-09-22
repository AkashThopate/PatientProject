using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PatientListAssignment
{
    public class PathientCLIView
    {
        Patient p;
        PatientManager pm;

        public PathientCLIView()
        {
            pm = new PatientManager();
        }

        public int Menu()
        {
            Console.WriteLine("1.Add Patient");
            Console.WriteLine("2.Edit Patient");
            Console.WriteLine("3.Remove Patient\n4.Find Patient\n5.Get All Patient\n6.Get Patient By Name\n7.GetPatient By Gender\n8.Enter Your Choice");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public void AddPatientView()
        {
            int PatientID;
            string PatientName;
            string PatientGender;
            string PatientMobile;
            int PatientWeight;
            int PatientHeight;
            string Disease;
            PatientID = pm.GenerateId();
            Console.WriteLine($"New patient id is : {PatientID}\nEnter Patient name :");
            PatientName = Console.ReadLine();
            Console.WriteLine("Enter patient gender : ");
            PatientGender = Console.ReadLine();
            Console.WriteLine("Enter patient mobile : ");
            PatientMobile = Console.ReadLine();
            Console.WriteLine("Enter patient weight : ");
            PatientWeight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter patient height : ");
            PatientHeight = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Patient disease : ");
            Disease = Console.ReadLine();

            p = new Patient(PatientID, PatientName, PatientGender, PatientMobile, PatientWeight, PatientHeight, Disease);

            pm.AddPatient(p);

            
    }
        public void updatePatientview()
        {
            int id, weight, height;
            string name, gender, mo_no, disease;
            Console.Write("Please Enter patient id : ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Please Enter patient Name\t:\t");
            name = Console.ReadLine();
            Console.Write("Please Enter patient Gender\t:\t");
            gender = Console.ReadLine();
            Console.Write("Please Enter Customer Mobile Number : ");
            mo_no = Console.ReadLine();
            Console.Write("Please Enter weight : ");
            weight = int.Parse(Console.ReadLine());
            Console.Write("Please Enter Height : ");
            height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter disease : ");
            disease = Console.ReadLine();
            p = new Patient(id, name, gender, mo_no, weight, height, disease);
            if (pm.updatePatient(id, p))
            {
                Console.WriteLine("Patient details updates successfully ");
            }
            else
            {
                Console.WriteLine("Details not found");
            }


        }
        public void FindPatientView()
        {
            Console.WriteLine("Please enter patient ID");
            int id = int.Parse(Console.ReadLine());
            p = pm.FindPateint(id);
            if (p != null)
            {
                Console.WriteLine("Patient details found ");
                Console.WriteLine(p);
            }
            else
            {
                Console.WriteLine("Patient details not found ");
            }
        }
        public void GetPatientByNameView()
        {
            string name;
            Console.WriteLine("Enter Patient name");
            name=Console.ReadLine();
            List<Patient> pat = pm.GetPatientByName(name);
            if (pat != null)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Patient ID\tPatient Name\tPatient Gender\tPatient Mobile\tPatient Weight\tPatient Height\tPatient Disease\t");
                foreach (Patient p in pat)
                {
                    Console.WriteLine($"\t{p.patietnid}\t{p.patientname}\t{p.patientgender}\t{p.patientmobile}\t{p.patientweight}\t{p.patientheight}\t{p.disease}");
                }


                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            }
        }
        public void GetPatientByGenderView()
        {
            string name;
            Console.WriteLine("Enter Patient gender");
            name = Console.ReadLine();
            List<Patient> pat = pm.GetPatientByGender(name);
            if (pat != null)
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("Patient ID\tPatient Name\tPatient Gender\tPatient Mobile\tPatient Weight\tPatient Height\tPatient Disease\t");
                foreach (Patient p in pat)
                {
                    Console.WriteLine($"\t{p.patietnid}\t{p.patientname}\t{p.patientgender}\t{p.patientmobile}\t{p.patientweight}\t{p.patientheight}\t{p.disease}");
                }


                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            }
        }
        public void deletePatientView()
        {
            Console.WriteLine("Enter patient id");
            int id = int.Parse(Console.ReadLine());
            if (pm.DeletePatient(id))
            {
                Console.WriteLine("Patient details deleted successfullt");
            }
            else
            {
                Console.WriteLine("Patient details not found");
            }
        }
        public void patientSummary()
        {
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Patient ID\tPatient Name\tPatient Gender\tPatient Mobile\tPatient Weight\tPatient Height\tPatient Disease\t");
            foreach (Patient p in pm.GetAllPatients())
            {
                Console.WriteLine($"\t{p.patietnid}\t{p.patientname}\t{p.patientgender}\t{p.patientmobile}\t{p.patientweight}\t{p.patientheight}\t{p.disease}");
            }

            
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");

        }
    }
}
