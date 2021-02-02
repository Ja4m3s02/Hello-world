using System;

namespace AIE_09_DayOfWeekLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            day = day.ToLower();
            day = day.Trim();

            day = day.Replace(" ", "");



            if (day == "monday") Console.WriteLine("1");
            else if (day == "tuesday") Console.WriteLine("2");
            else if (day == "wednesday") Console.WriteLine("3");
            else if (day == "thursday") Console.WriteLine("4");
            else if (day == "friday") Console.WriteLine("5");
            else if (day == "saturday") Console.WriteLine("6");
            else if (day == "sunday") Console.WriteLine("7");
            else Console.WriteLine("NOT A DAY!");










        }
    }
}
