using OOP_LB4_4th_task.Solution;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_LB4_4th_task._4th
{
    class CommonCalcualtor:Calculator
    {
        public static void GetSolution()
        {
            Console.WriteLine(new string('-', 40));
            Console.Write(
                    "Выберите номер системы счисления:\n" +
                    "1.Десятичная\n" +
                    "2.Двоичная\n--> ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 40));
            switch (n)
            {
                case 1:
                    Denary();
                    break;
                case 2:
                    Binary();
                    break;
                default:
                    return;
            }
        }
    }
}
