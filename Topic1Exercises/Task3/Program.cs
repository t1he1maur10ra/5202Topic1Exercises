using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class ProgramTask3
    {
        public static void Main()
        {
            //Take the inputs from the user and store them
            Console.WriteLine("Please enter a number");
            double num1 = double.Parse(Console.ReadLine());//using doubles incase input isnt whole
            Console.WriteLine("Please enter another number");
            double num2 = double.Parse(Console.ReadLine());

            //Multiple and display the result
            Console.WriteLine("{0} x {1} = {2}", num1, num2, (num1 * num2));
        }
    }
}
