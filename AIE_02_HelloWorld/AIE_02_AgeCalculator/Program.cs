using System;

namespace AIE_02_AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            uint currentYear = 2021;
            uint birthYear = 2000;

            uint age = currentYear - birthYear;

            Console.WriteLine("You are: " + age + " years old");

            DateTime CurrentYear = new DateTime(2021, 1, 1);
            DateTime BirthYear = new DateTime(2000, 1, 1);
            var Age = CurrentYear - BirthYear;
            var ageInHours = age.Days;

            Console.WriteLine("You are: " + ageInHours + " hours old");


        }
    }
}
