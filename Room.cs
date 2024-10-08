

using static HospitalClassINhernite.Room;

namespace HospitalClassINhernite
{

   
    public class Room: IRoomManagment, IDisplayInfo
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

        public void DisplayInfo()
        {
            Console.WriteLine($"number of room :{RoomNumber} , room type is : {R}");
        }
    }

   
    public class Ward : IRoomManagment
    {
            public int WardNumber { get; private set; }
            public bool IsOccupied { get; private set; }

            public Ward(int wardNumber)
            {
                WardNumber = wardNumber;
            }

            public void OccupyRoom()
            {
                if (IsOccupied)
                {
                    Console.WriteLine("<!> This ward is already occupied :( <!>");
                }
                else
                {
                    IsOccupied = true;
                    Console.WriteLine("Ward has been successfully occupied.");
                }
            }

            public void VacateRoom()
            {
                if (!IsOccupied)
                {
                    Console.WriteLine("<!> This ward is not occupied :( <!>");
                }
                else
                {
                    IsOccupied = false;
                    Console.WriteLine("Ward has been successfully vacated.");
                }
            }

            public bool CheckOccupancy()
            {
                return IsOccupied;
            }

            public void DisplayRoomInfo()
            {
                Console.WriteLine($"Ward Number: {WardNumber}, Is Occupied: {IsOccupied}");
            }
        }
    }
