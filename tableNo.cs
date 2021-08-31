using System;

namespace ProgramFile
{
    class tableNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num, product;
            Console.Write("Enter the Number to Print its  Table: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Table For {0}: ", num);
            for (int i = 1; i <= 10; i++)
            {
                product = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, product);
            }
            Console.ReadKey();
        }
    }
}