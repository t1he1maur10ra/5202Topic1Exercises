using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class ProgramTask6
    {
        public static void Main()
        {
            //Take in the user inputs and store them in the appropriate variables
            Console.WriteLine("Please enter a number...");
            double input1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number...");
            double input2 = double.Parse(Console.ReadLine());

            //Display the variables current states
            Console.WriteLine("Variable1 = {0}\nVariable2 = {1}\n", input1, input2);

            //Perform the swap
            double temp = input1;
            input1 = input2;
            input2 = temp;

            //Display the swapped variables
            Console.WriteLine("Variable1 = {0}\nVariable2 = {1}\n", input1, input2);
        }
    }
}
