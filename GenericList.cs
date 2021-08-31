using System;
using System.Collections.Generic;
namespace ProgramFile
{
    class GenericList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<string> myList = new List<string>();
            myList.Add("Rohini");
            myList.Add("Amol");
            myList.Add("Abhi");


            foreach (string s in myList)
                Console.Write(s.ToString() + " ");


            myList.Sort();
            Console.WriteLine("\n After Sorting");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");


            myList.Remove("Rohini");
            Console.WriteLine("\nRemoving Rohini");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");


            myList.Insert(2, "Jadhav");
            Console.WriteLine("\nInserting samu at index position 2");
            foreach (string s in myList)
                Console.Write(s.ToString() + " ");
        }
    }
}