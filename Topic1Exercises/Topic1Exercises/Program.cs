using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;
using Task3;
using Task4;
using Task5;

namespace Topic1Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the projects using the using statements
            ProgramTask1.Main();
            ProgramTask2.Main();
            ProgramTask3.Main();
            ProgramTask4.Main();
            ProgramTask5.Main();

            //Call the projects sithout using the using statements
            Task6.ProgramTask6.Main();
            Task7.ProgramTask7.Main();
            Task8.ProgramTask8.Main();
            Task9.ProgramTask9.Main();
        }
    }
}
