using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class ProgramTask5
    {
        public static void Main()
        {
            //Create the variable to hold user input
            int num1;
            bool check = false;

            //use loop to ensure correct input
            do
            {
                Console.WriteLine("Please enter a number from 1 to 12");
                if (int.TryParse(Console.ReadLine(), out num1))
                {
                    //use a loop to produce the output
                    for(int i=0; i<=12; i++)
                    {
                        Console.WriteLine("{0} x {1} = {2}", num1, i, (num1 * i));
                    }
                    //break out of the loop as desired result has been achieved
                    check = true;
                }
                //Provide an error msg to the user and prompt to try again
                else
                {
                    Console.WriteLine("Something went wrong, please press enter to try again...");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (!check);
        }
    }
}
