using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        
        static double Divide(double x, double y)
        {
            try
            {
                if (y < 0)
                {
                    throw new ArgumentOutOfRangeException("Total possible number of points cannot be less than zero (0)");
                }
                else
                {
                    Console.WriteLine(x / y);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                y = 0
                Console.WriteLine(e);
            }
        }
        /*
        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
        }
        */

        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            Console.WriteLine("Please enter student's # of points: ");
            double studentGrade = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter total possible points: ");
            double totalPoints = Double.Parse(Console.ReadLine());

            Console.WriteLine(Divide(studentGrade, totalPoints));




            /*

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            */
        }
    }
}
