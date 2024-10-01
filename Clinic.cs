using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}
