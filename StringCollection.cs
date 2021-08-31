using System;
using System.Collections;
using System.Collections.Specialized;
namespace ProgramFile
{
    class StringCollection
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String_Collections");
            DemoStringCollection obj = new DemoStringCollection();
            obj.PrintStringCollection();


        }
    }

    class DemoStringCollection
    {
        public void PrintStringCollection()
        {
            System.Collections.Specialized.StringCollection sc = new System.Collections.Specialized.StringCollection();
            Console.WriteLine("Befor Adding Elements in String Count");
            Console.WriteLine(sc.Count);

            // Adding elements in StringCollection
            sc.Add("C#");
            sc.Add("C++");
            sc.Add("Python");
            sc.Add("Java");
            sc.Add("SQL");


            Console.WriteLine("After Adding Element in String Count");
            Console.WriteLine(sc.Count);
        }
    }
}

