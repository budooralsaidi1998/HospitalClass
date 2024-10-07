

using System.Xml.Linq;

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

            TimeSpan startTime = new TimeSpan(9, 0, 0);
            for (int i = 0; i < period.TotalHours; i++)
            {
                Appointment newAppointment = new Appointment(null, appointmentDay, startTime.Add(new TimeSpan(i, 0, 0)));
                AvailableAppointments[doctor].Add(newAppointment);
                Console.WriteLine($"Available appointment added for {doctor.Name} at {startTime.Add(new TimeSpan(i, 0, 0))}.");
            }
           
        }


        public void DisplayAvailableAppointments()
        {
            if (AvailableAppointments.Count == 0)
            {
                Console.WriteLine("No available appointments at the moment.");
                return;
            }
            foreach (var doctorAppointments in AvailableAppointments)
            {
                Doctor doctor = doctorAppointments.Key;
                List<Appointment> appointments = doctorAppointments.Value;
                Console.WriteLine($"\nDoctor: Dr. {doctor.Name} (ID: {doctor.DoctorID})");
                Console.WriteLine("Available Appointments:");
                foreach (var appointment in appointments)
                {
                    Console.WriteLine($"- {appointment.AppointmentDate:MMMM dd, yyyy - h:mm tt}");
                }
            }
        }


        public void BookAppointment(Patient patient, Doctor doctor, DateTime appointmentDay, TimeSpan appointmentTime)
        {
            var appointment = AvailableAppointments[doctor].Find(a => a.AppointmentDate == appointmentDay && a.AppointmentTime == appointmentTime && !a.IsBooked);
            if (appointment != null)
            {
                appointment.patient = patient;
                appointment.ScheduleAppointment( appointmentDay, appointmentTime);
            }
            else
            {
                Console.WriteLine("Appointment is not available.");
            }
        }

    }


    }

