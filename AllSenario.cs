
using System;

namespace ProgramFile
{
    class AllSenario
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int marks = 65;
            if (marks >= 80)
            {
                Console.WriteLine("This is in if statement");
            }
            else if (marks >= 60)
            {
                Console.WriteLine(" This is in else if statement");
            }
            else if (marks >= 40)
            {
                Console.WriteLine("This is in else if to statement");
            }
            else
            {
                Console.WriteLine("Student has failed");
            }
            Console.ReadLine();
        }
    }

}