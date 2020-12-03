using System;

namespace OOP_LB4_4th_task._4th
{
    class ApplicationLicense
    {
        public const string common = "AFF14";
        public const string pro = "AFF15";
        public static void AllowTrial()
        {
            Console.WriteLine("\nПробная версия");
            TrialCalculator.GetSolution();
        }
        public static void AllowCommon()
        {
            Console.WriteLine("\nОбычная версия");
            CommonCalcualtor.GetSolution();
        }
        public static void AllowPro()
        {
            Console.WriteLine("\nПлатная версия");
            ProCalculator.GetSolution();
        }
    }
}
