using System;

namespace AIE_08_DivisbleBy4or6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;
            if (number % 4 ==0)
            {
                Console.WriteLine("Mumber is divisibile by 4");
            }
             if (number % 6 == 0)
            {
                Console.WriteLine("Number is Divisible by 6");

            }

            //if (number % 6 != && number is % 4 != 0)
            //if(!(Number % 6 ==0 || number %4 ==0)
            {
                Console.WriteLine("Number is not divisible by 4 or 6");
            }
                
            }
        }
    
}
