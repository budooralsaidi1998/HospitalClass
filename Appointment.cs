
namespace HospitalClassINhernite
{
    public class Appointment
    {

       public Patient patient;
        public Doctor doctor;
        public DateTime ?AppointmentDate;
        public TimeSpan AppointmentTime;
        public bool IsBooked;

        public Appointment(Patient patient, Doctor doctor,DateTime dateappo,TimeSpan appointmentTime,bool booked)
        {
            this.patient = patient;
            this.doctor = doctor;
            AppointmentDate=dateappo;
            AppointmentTime=appointmentTime;
            AppointmentTime = appointmentTime;
            IsBooked = booked;
        }

        public Appointment(Doctor doctor,DateTime date,TimeSpan time)
        {
            this.doctor = doctor;
            AppointmentDate=date;
            AppointmentTime=time;

        }
        public void ScheduleAppointment(DateTime appointmentDate, TimeSpan appointmentTime)
        {
            //is booked 
            IsBooked = true;
           
            Console.WriteLine($"Appointment scheduled for {patient.Name} on {AppointmentDate} at {AppointmentTime}");
        }


        public void CancelAppointment()
        {
            AppointmentDate = null;
        }


        public void GetAppointmentDetails()
        {
            Console.WriteLine($"Appointment for: {patient.Name}, Date: {AppointmentDate}, Time: {AppointmentTime}, IsBooked: {IsBooked}");
        }




    }
}
