using System;
namespace ProgramFile

{
    public class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a, b;
            float c;
            int choice;

            Console.WriteLine(" CALCULATOR  ");
            Console.WriteLine("CALCULATION ");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Substraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");
            Console.WriteLine("5. EXIT ");

            Console.WriteLine("\nENTER YOUR FIRST NUMBER:- ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER YOUR SECOND NUMBER:- ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nENTER YOUR CHOICE:- ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine("Result Is :- " + c);
                    break;
                case 2:
                    c = a - b;
                    Console.WriteLine("Result Is :- " + c);
                    break;
                case 3:
                    c = a * b;
                    Console.WriteLine("Result Is :- " + c);
                    break;
                case 4:
                    c = a / b;
                    Console.WriteLine("Result Is :- " + c);
                    break;
                case 5:
                    Environment.Exit(5);
                    break;
            }
            Console.ReadLine();
        }
    }

}