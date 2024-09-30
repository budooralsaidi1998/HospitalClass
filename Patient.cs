

namespace HospitalClassINhernite
{
    public class Patient:Person
    {
        List<Doctor>doctors = new List<Doctor>();
        public int PatientID;
        public string Ailment;
        public string AssignedDoctor;
        public int Room = 0;
        
        public Patient(int pationid,string name, int age, string Gender,string ailmenrt,string assigndoctor):base(name, age, Gender)
        {
            PatientID = pationid;
            Ailment = ailmenrt;
            //id of doctor
            AssignedDoctor = assigndoctor;
           
            

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
