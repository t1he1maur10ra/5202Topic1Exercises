using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class ProgramTask8
    {
        public static void Main()
        {
            Console.WriteLine("Please enter your mark: ");
            double mark = double.Parse(Console.ReadLine());
            if (mark >= 50)
                Console.WriteLine("You passed.");
            else
                Console.WriteLine("You failed");
        }
    }
}
