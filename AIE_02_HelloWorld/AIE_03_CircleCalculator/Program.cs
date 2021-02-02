using System;

namespace AIE_03_CircleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 6;
            double circumference = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;


            Console.WriteLine("The circumference of the circle = " + circumference);
            Console.WriteLine("The area of the cirlc = " + area);
        }
    }
}
