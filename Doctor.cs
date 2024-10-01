
using System.Globalization;
using System.Reflection;

namespace HospitalClassINhernite
{
    public class Doctor:Person
    {


      

        public int DoctorID;
        public string Specialization;
       public static List<Patient> Doctorlist = new List<Patient>();


        public Doctor(int did , string name,int age , Gender Gender,string spec):base(name, age, Gender)
        {
            DoctorID = did;
            Specialization = spec;
        }

        public void AddPatient(Patient patient)
        {

            Doctorlist.Add(patient);
        }

        public void RemovePatient(Patient patient)
        {
            Doctorlist.Remove(patient);
        }



        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" doctor id : {DoctorID } , Specialization : {Specialization} ");

        }
    }
}
