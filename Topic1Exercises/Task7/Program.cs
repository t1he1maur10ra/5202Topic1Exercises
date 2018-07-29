using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class ProgramTask7
    {
        public static void Main()
        {
            //Take the users inut and tore them
            Console.WriteLine("Please enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());

            //check to see if num1 is the largest
            if (num1 > num2 && num1 > num3)
                Console.WriteLine($"{num1} is the largest number.");
            //else check to see if num2 is the largest
            else if(num2 > num1 && num2 > num3)
                Console.WriteLine($"{num2} is the largest number.");
            //otherwise num3 is the largest
            else 
                Console.WriteLine($"{num3} is the largest number.");
        }
    }
}
