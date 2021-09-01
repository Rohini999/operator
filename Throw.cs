using System;
namespace ProgramFile

{
    class throw_statement
    {
        static void Main(string[] args) 
        {
            int num1, num2, result;
            Console.WriteLine("Enter First Number"); 
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number"); 
            num2 = Convert.ToInt32(Console.ReadLine());
            try { 
                if (num2 == 0)
                {
                    throw new Exception("Can't Divide by Zero Exception\n\n");
                }
                result = num1 / num2; 
                Console.WriteLine("{0} / {1} = {2}", num1, num2, result); 
            } 
            catch (Exception e) 
            {
                Console.WriteLine("e;Error : " +e.ToString());
            }
            Console.ReadLine();
        }
    }
}