
namespace HospitalClassINhernite
{
    public class Appointment
    {

       public Patient patient;
        public Doctor doctor;
        public DateTime ?AppointmentDate;

        public Appointment(Patient patient, Doctor doctor,DateTime dateappo)
        {
            this.patient = patient;
            this.doctor = doctor;
            AppointmentDate=dateappo;

        }

        public void ScheduleAppointment(DateTime dateappo)
        {
            AppointmentDate = dateappo;
        }


        public void CancelAppointment()
        {
            AppointmentDate = null;
        }


        public void GetAppointmentDetails()
        {
            Console.WriteLine($"Appointment scheduled for {patient.Name} with {doctor.Name} on {AppointmentDate}");
        }




    }
}
