using System;

namespace AIE_06_MaxOfThreeVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number: ");
            string sNumb1 = Console.ReadLine();

            Console.Write("Enter second number: ");
            string sNumb2 = Console.ReadLine();

            Console.Write("Enter third number: ");
            string sNumb3 = Console.ReadLine();

            int num1 = int.Parse(sNumb1);
            int num2 = int.Parse(sNumb2);
            int num3 = int.Parse(sNumb3);

            Console.WriteLine("The biggest number is : ");

            if (num1 >= num2 && num1 >= num3) Console.WriteLine(num1);
            if (num2 >= num1 && num2 >= num3) Console.WriteLine(num2);
            if (num3 >= num2 && num3 >= num1) Console.WriteLine(num3);

            
        }
    }
}
