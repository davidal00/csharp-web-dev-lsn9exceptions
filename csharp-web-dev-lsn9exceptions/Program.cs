using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Unable to divide by zero!");
            }
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (fileName == "" || fileName == null)
            {
                throw new ArgumentNullException("Filename can't be empty or null.");
            }
            if (fileName.EndsWith(".cs"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            try
            {
                Console.WriteLine(Divide(10, 2));
                Console.WriteLine(Divide(10, 0));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair <string, string> student in students)

            {

                try
                {
                    Console.WriteLine(student.Key + " has " + CheckFileExtension(student.Value));
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(student.Key + " has 0, " + e.Message);
                }

            }
        }
    }
}
