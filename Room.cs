

namespace HospitalClassINhernite
{
    public class Room
    {
        public static List<Patient> roomlist = new List<Patient>();
        public int RoomNumber;
        public string RoomType;
        public bool IsOccupied = true;

        public Room(int roomNumber, string roomType, bool isOccupied)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            IsOccupied = isOccupied;
        }


        public void OccupyRoom()
        {
            for (int i = 0; i < roomlist.Count; i++)
            {
                if (roomlist[i].Room == RoomNumber)
                {
                    Console.WriteLine($"Room {RoomNumber} is occupied: {IsOccupied}");
                }
                else
                {
                    Console.WriteLine($"Room {RoomNumber} is occupied: {!IsOccupied}");
                }
            }
               
        }
        public void VacateRoom()
        {
            for (int i = 0; i < roomlist.Count; i++)
            {
                if (roomlist[i].Room == null)
                
                {
                    Console.WriteLine($"Room {RoomNumber} is available");
                }
            }

        }
    }
}