using OOP_LB4._1st;
using OOP_LB4._2nd;
using OOP_LB4._3rd;
using System.Diagnostics;

namespace OOP_LB4_1_3_task
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-е Задание
            Debug.WriteLine(new string('-', 30));
            Debug.WriteLine("1-е Задание:");

            Human human = new Human("Ivan", "Yakovich", "Male", 28);
            Debug.WriteLine($"This is class {human.GetType().Name}");
            human.Info();

            Employee employee = new Employee("Taras", "Krupko", "Male", 18, "Director", 18785);
            Debug.WriteLine($"This is class {employee.GetType().Name}");
            employee.Info();

            Human human1 = (Human)employee;
            Debug.WriteLine($"This is class {human1.GetType().Name}");
            human1.Info();

            Employee employee1 = (Employee)human1;
            Debug.WriteLine($"This is class {employee1.GetType().Name}");
            employee1.Info();
            Debug.WriteLine(new string('-', 30));
            #endregion

            #region 2-е Задание
            Debug.WriteLine("2-е Задание:");

            A a1 = new A(
                new B(21, -14, "F"), new B(14.1550, 14, "V"), new B(154, -489, "Q"));
            a1.GetXY();

            A a2 = new A(
                new B(14, 14.22, "G"), new B(47, 854, "L"));
            a2.GetXY();

            B_1 b_1 = new B_1(154, 44, "ASE");
            B_2 b_2 = new B_2(14, 4, "SE");
            B_3 b_3 = new B_3(4, 484, "AE");

            A a3 = new A(b_1, b_2, b_3);
            a3.GetXY();
            Debug.WriteLine(new string('-', 30));
            #endregion

            #region 3-е Задание
            Debug.WriteLine("3-е Задание:\n");

            Unit unit = new Unit("Dog", "Earth");
            unit.ShowInfo();

            Hero hero = new Hero("William", "Ship", 1200, "Sword", 15);
            hero.ShowInfo();

            Enemy enemy = new Enemy("Dragon", "Mountain", 20000, "Fire", 50);
            enemy.ShowInfo();

            Debug.WriteLine(new string('-', 30));
            #endregion
        }
    }
}

