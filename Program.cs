//using System;
//namespace TestConsoleApplication11

using System;

namespace ProgramFile
{
    class program
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



//{
//    class program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Enter the action to be performed");
//        Console.WriteLine("Press 1 for Addition");
//        Console.WriteLine("Press 2 for Subtraction");
//        Console.WriteLine("Press 3 for Multiplication");
//        Console.WriteLine("Press 4 for Division \n");
//        int action = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter 1st input");
//        int input_1 = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine("Enter 2nd input");
//        int input_2 = Convert.ToInt32(Console.ReadLine());
//        int result = 0;
//        switch (action)
//        {
//            case 1:
//                {
//                    result = Addition(input_1, input_2);
//                    break;
//                }
//            case 2:
//                {
//                    result = Subtraction(input_1, input_2);
//                    break;
//                }
//            case 3:
//                {
//                    result = Multiplication(input_1, input_2);
//                    break;
//                }
//            case 4:
//                {
//                    result = Division(input_1, input_2);
//                    break;
//                }
//            default:
//                Console.WriteLine("Wrong action! try again");
//                break;
//        }
//        Console.WriteLine("The result is {0}", result);
//        Console.ReadKey();
//    }
//    //Addition  
//    public static int Addition(int input_1, int input_2)
//    {
//        int result = input_1 + input_2;
//        return result;
//    }
//    //Substractionn  
//    public static int Subtraction(int input_1, int input_2)
//    {
//        int result = input_1 + input_2;
//        return result;
//    }
//    //Multiplication  
//    public static int Multiplication(int input_1, int input_2)
//    {
//        int result = input_1 + input_2;
//        return result;
//    }
//    //Division  
//    public static int Division(int input_1, int input_2)
//    {
//        int result = input_1 + input_2;
//        return result;
//    }
//}
//}


