using System.Diagnostics;

namespace OOP_LB4._1st
{
    class Employee : Human
    {
        public Employee() : base() { }
        public Employee(string Name, string LastName, string Gender, int Age, string Post, double Salary)
            : base(Name, LastName, Gender, Age)
        {
            this.Post = Post;
            this.Salary = Salary;
        }

        public string Post { get; set; }
        public double Salary { get; set; }

        public void Info()
        {
            Debug.WriteLine(
                $"Name: {Name}\n" +
                $"LastName: {LastName}\n" +
                $"Gender: {Gender}\n" +
                $"Age: {Age}\n" +
                $"Post: {Post}\n" +
                $"Salary: {Salary}\n");
        }
    }
}
