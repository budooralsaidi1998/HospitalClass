

namespace HospitalClassINhernite
{
    public  class Person
    {

        public string Name;
        public int Age;
        public string gender;

        public Person(string name, int age, string Gender)
        {
            Name = name;
            Age = age;
            if (Gender == "femal")
            {
             
                gender = Gender;
            }
            else
            {
                gender = Gender;
            }



        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name} , Age : {Age} , Gender : {gender}");
        }







    }
}
