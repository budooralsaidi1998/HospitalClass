
using System.Globalization;
using System.Reflection;

namespace HospitalClassINhernite
{
    public class Doctor:Person
    {


      

        public int DoctorID;
        public enum Specialization { Cardiology, Neurology, Dermatology };
        public  Specialization sp;

       public static List<Patient> Doctorlist = new List<Patient>();

        public static List<Clinic> AssignedClinics = new List<Clinic>();
        public Doctor(int did , string name,int age , Gender Gender, Specialization spec) :base(name, age, Gender)
        {
            DoctorID = did;
            sp = spec;
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
            Console.WriteLine($" doctor id : {DoctorID } , Specialization : {sp} ");

        }
    }
}
