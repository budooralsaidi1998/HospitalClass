using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalClassINhernite
{
    public class InPatient:Patient
    {

         public Room room;
        public Doctor AssignedDoctor;
        public DateTime AdmissionDate;
        public Room? AssignedRoom { get; set; }
        public InPatient(int pationid, string name, int age, Gender gender, string ailmenrt, DateTime admissionDate, Room rooms, Doctor AssignedDoctors,Room assignroom) :base( pationid, name, age,  gender,  ailmenrt, AssignedDoctors)
        {
            AdmissionDate = admissionDate;
            room = rooms;
            AssignedDoctor = AssignedDoctors;
            AssignedRoom = assignroom;
        }

        public void AssignRoom(Room room)
        {
            room.OccupyRoom();
            AssignedRoom=room;
            Console.WriteLine($"patient id : {PatientID} , Room Number:{room.RoomNumber}");
        }

        public void Discharge(Room room)
        {
            room.VacateRoom();
            AssignedRoom = null;
            Console.WriteLine("success discharge the patient");
        }


















    }
}
