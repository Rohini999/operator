using System;

namespace ProgramFile
    
{
    class Student
    {
        public string name = "Rohini jadhav";

        public void print()
        {
            Console.WriteLine(" Student class");
        }
    }
    class Student2
    {
        protected string name = "abhi jadhav";
    }


    class Program1 : Student2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student student1 = new Student();
            Console.WriteLine("Name: " + student1.name);
            student1.print();
            Console.ReadLine();

            Program program1 = new Program();
            Console.WriteLine("Name: " + program1.name);
            Console.ReadLine();

        }

    }
}
