using System;

namespace ProgramFile
{
    class 2ndMaxNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] array = { 12, 15, 5, 7, 9, 98, 3, 83, 55 };
            Array.Sort(array);
            Array.Reverse(array);
            Console.WriteLine("Second max Value In Array " + array[1]);

            foreach (var result in array)
            {
                Console.Write(result + " ");
            }
        }
    }

}