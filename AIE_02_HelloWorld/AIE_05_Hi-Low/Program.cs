using System;

namespace AIE_05_Hi_Low
{
    class Program
    {
        static void Main(string[] args)
        {

            

            string sNumber = Console.ReadLine();
            int number = int.Parse(sNumber);

            

            if (number > 50)
            {
                Console.WriteLine("Bigger than 50");
            }

            else if (number < 50)
            {
                Console.WriteLine("Smaller than 50");
            }
            else
            {
                Console.WriteLine("SAME");
            }


            
        }
    }
}
