using System;
using OOP_LB4_4th_task._4th;

namespace OOP_LB4_4th_task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new string('*', 30));
            Console.WriteLine($"Ключи:\nCommon версия: {ApplicationLicense.common}\nPro версия: {ApplicationLicense.pro}");
            Console.WriteLine(new string('*', 30));

            Console.Write("Здравствуйте, это программа-калькулятор двоичной, восьмеричной, десятичной и шестнадцатеричной системы счисления\n\n" +
                "В Пробной (trial) версии доступны операции только с десятичной системой\n" +
                "В Обычной (common) версии доступны операции с десятичной и двоичной системами счисления\n" +
                "В Платной (pro) версии доступны операции с десятичной, двоичной, восьмеричной и шестнадцатеричной системами счисления\n\n" +
                "Введите ключ доступа, если у вас его нет, то вы сможете пользоватся Пробной (trial) версией\n--> ");

            string code = Console.ReadLine();

            if (code != ApplicationLicense.common && code != ApplicationLicense.pro)
            {
                ApplicationLicense.AllowTrial();
            }else if (code == ApplicationLicense.common)
            {
                ApplicationLicense.AllowCommon();
            }
            else
            {
                ApplicationLicense.AllowPro();
            }

        }
    }
}
