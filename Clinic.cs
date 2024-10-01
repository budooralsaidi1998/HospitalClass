

namespace HospitalClassINhernite
{
    public class Clinic
    {

        public int ClinicID;
        public string ClinicName;
        public enum Specialization { Cardiology, Neurology, Dermatology };

        public Specialization spClinic;

        public static List<Room> rooms = new List<Room>();

        public Dictionary<Doctor, List<Appointment>> AvailableAppointments= new Dictionary<Doctor, List<Appointment>>();
 
        public Clinic(int IdClinic,string clinicname,Specialization spp)
        {
            ClinicID = IdClinic;
            ClinicName = clinicname;
            spClinic = spp;
        }

        public void AddRoom(Room room)
        {
            if (!rooms.Contains(room))
            {
                rooms.Add(room);
            }
        }
        public void AddAvailableAppointment(Doctor doctor, DateTime appointmentDay, TimeSpan period)
       
        {
            if (!AvailableAppointments.ContainsKey(doctor))
            {

                AvailableAppointments[doctor]= new List<Appointment>();

            }

            for (int i = 0; i < 8; i++) // Generates 8 one-hour slots
            {
                var appointmentTime = period.Add(TimeSpan.FromHours(i));
                var appointment = new Appointment(null,appointmentDay, appointmentTime);
                AvailableAppointments[doctor].Add(appointment);
            }
            Console.WriteLine($"Available appointments added for Dr. {doctor.Name} on {appointmentDay.ToShortDateString()}.");
        }



        public void BookAppointment(Patient patient, Doctor doctor, DateTime appointmentDay, TimeSpan appointmentTime)
        {
            var appointment = AvailableAppointments[doctor].Find(a => a.AppointmentDate == appointmentDay && a.AppointmentTime == appointmentTime && !a.IsBooked);
            if (appointment != null)
            {
                appointment.patient = patient;
                //appointment.ScheduleAppointment();
            }
            else
            {
                Console.WriteLine("Appointment is not available.");
            }
        }

    }


    }
}
