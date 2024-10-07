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
        public InPatient(string name, int pationid, Gender gender, int age, string ailmenrt, DateTime admissionDate, Room rooms, Doctor AssignedDoctors,Room assignroom) :base( pationid, name, age,  gender,  ailmenrt, AssignedDoctors)
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
            AssignedRoom.VacateRoom();
            AssignedRoom = null;
            Console.WriteLine($"success discharge the patient from {room.RoomNumber}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" pation id : {PatientID} , aliment : {Ailment} ,Room Number:{room.RoomNumber},Assign doctor : {AssignedDoctor.Name}");
             

        }
















    }
}
