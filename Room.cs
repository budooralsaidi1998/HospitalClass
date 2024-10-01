

using static HospitalClassINhernite.Room;

namespace HospitalClassINhernite
{
    public class Room
    {
        public static List<Patient> roomlist = new List<Patient>();
        public int RoomNumber;
        public enum RoomType { GIPR, OPR }
        public RoomType R { get; set; }
        public bool IsOccupied;

        public Room(int roomNumber, RoomType roomType)
        {
            RoomNumber = roomNumber;
            R = roomType;
            
        }


        public void OccupyRoom()
        {
            if (IsOccupied)
            {
                Console.WriteLine("<!>This room is already booked :( <!>");
            }
            else
            {
                IsOccupied = true;
            }
        }
        public void VacateRoom()
        {
            if (!IsOccupied)
            {
                Console.WriteLine("<!>This room is not occupied :( <!>");
            }
            else
            {
                IsOccupied = false;
            }
        }
        public void DisplayRoomInfo()
        {
            Console.WriteLine($"Room Number : {RoomNumber} ,Room Type : {R} , Is occupied : {IsOccupied} ");
        }
    }
}