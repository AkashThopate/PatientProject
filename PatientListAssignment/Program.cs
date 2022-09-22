using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientListAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PathientCLIView view = new PathientCLIView();
            bool status = true;
            while (status != false)
            {
                int choice = view.Menu();
                switch (choice)
                {
                    case 1:
                        view.AddPatientView();

                        break;
                    case 2:
                        view.updatePatientview();
                        break;
                    case 3:
                        view.deletePatientView();
                        break;
                    case 4:
                        view.FindPatientView();
                        break;
                    case 5:
                        view.patientSummary();
                        break;
                    case 6:
                        view.GetPatientByNameView();
                        break;
                    case 7:
                        view.GetPatientByGenderView();
                        break;
                    default:
                        status = false;
                        break;

                }
            }
                Console.ReadLine();
        }
    }
}
