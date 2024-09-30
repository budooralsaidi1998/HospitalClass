

namespace HospitalClassINhernite
{
    public class Patient:Person
    {
        public int PatientID;
        public string Ailment;
        public string AssignedDoctor;
        public int Room = 0;
        public Patient(string name, int age, string Gender,int pationid,string ailmenrt,string assigndoctor, int room):base(name, age, Gender)
        {
            PatientID = pationid;
            Ailment = ailmenrt;
            AssignedDoctor = assigndoctor;
            Room = room;
            

        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($" pation id : {PatientID} , aliment : {Ailment} ");

        }

        public void Discharge()
        {
            if (AssignedDoctor != null)
            {
                Console.WriteLine($" this patient id discharge from room {Room}");
            }
        }

    }
}
