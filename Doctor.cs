
using System.Globalization;
using System.Reflection;

namespace HospitalClassINhernite
{
    public class Doctor:Person
    {


      

        public int DoctorID;
        public string Specialization;
       public static List<Patient> Doctorlist = new List<Patient>();


        public Doctor(int did , string name,int age , string Gender,string spec):base(name, age, Gender)
        {
            DoctorID = did;
            Specialization = spec;
        }

        public void AddPatient()
        {

            Doctorlist.Add(new Patient((101,"John Doe", 30, "Gender.Male", "Heart Disease", "doctor1")));
        }
        public void RemovePatient()
        {
            Console.WriteLine(" enter patient id to remove:");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < Doctorlist.Count; i++)
            {
                if (Doctorlist[i].PatientID == id)
                {
                    Doctorlist.RemoveAt(i);
                }
            }
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" doctor id : {DoctorID } , Specialization : {Specialization} ");

        }
    }
}
