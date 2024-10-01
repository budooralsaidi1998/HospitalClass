
namespace HospitalClassINhernite
{
    public  class OutPatient:Patient
    {
       public  Clinic ClinicAssigned;
     
            
    
        public OutPatient(int pationid, string name, int age, Gender gender, string ailmenrt,Doctor assigndoctor,Clinic clinicAssigned):base(pationid, name, age, gender, ailmenrt, assigndoctor)
        {
            ClinicAssigned = clinicAssigned;
       
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Upcoming Appointments:");
            foreach (var appointment in ClinicAssigned.AvailableAppointments)
            {
                foreach (var item in appointment.Value)
                {
                    if (item.AppointmentDate > DateTime.Now)
                    {
                        Console.WriteLine($"Date: {item.AppointmentDate}, Time: {item.AppointmentTime}, IsBooked: {item.IsBooked}");
                    }
                }
            }
        }
    }

}
