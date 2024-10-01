
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

       public void DisplayAssignedClinics(Doctor doctor)
        {
            Console.WriteLine("Assigned Clinics:");

            foreach (var clinic in AssignedClinics)
            {
                Console.WriteLine(clinic.ClinicName);
            }
        }

        //learn new thing "to shortdatestring"
        //
        public void AssignToClinic(Clinic clinic, DateTime day, TimeSpan period)
        {
            if (!AssignedClinics.Contains(clinic))
            {
                AssignedClinics.Add(clinic);
            }
            clinic.AddAvailableAppointment(this, day, period);
            Console.WriteLine($"Doctor {Name} assigned to {clinic.ClinicName} on {day.ToShortDateString()}.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" doctor id : {DoctorID } , Specialization : {sp} ");

        }
    }
}
