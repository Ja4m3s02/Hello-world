﻿using System;

namespace AIE_09_DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 6;

            int dayWrapped = day % 7;

            if (day == 1) Console.WriteLine("Monday");
            else if (day == 2) Console.WriteLine("Tuesday");
            else if (day == 3) Console.WriteLine("Wednesday");
            else if (day == 4) Console.WriteLine("Thursday");
            else if (day == 5) Console.WriteLine("Friday");
            else if (day == 6) Console.WriteLine("Saturday");
            else if (day == 7) Console.WriteLine("Sunday");
            else Console.WriteLine("NOT A DAY");
        }
    }
}
