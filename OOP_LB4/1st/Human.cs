using System.Diagnostics;

namespace OOP_LB4._1st
{
    class Human
    {
        public Human() { }
        public Human(string Name, string LastName, string Gender, int Age)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Age = Age;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public void Info()
        {
            Debug.WriteLine(
                $"Name: {Name}\n" +
                $"LastName: {LastName}\n" +
                $"Gender: {Gender}\n" +
                $"Age: {Age}\n");
        }
    }
}
