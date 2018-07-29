using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class ProgramTask4
    {
        public static void Main()
        {
            //Take the user inputs fgor the first and last names and store them.
            Console.WriteLine("Please enter your first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Please enter your last name: ");
            string lname = Console.ReadLine();

            //Display the response using the stored fname and lname variables
            Console.WriteLine($"Hello, nice to meet you {fname} {lname}");
        }
    }
}
