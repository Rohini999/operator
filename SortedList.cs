using System;
using System.Collections;
namespace  ProgramFile
{
    class SortedList
{
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SortedList1 my_slist1 = new SortedList1();
            my_slist1.Add(1.02, "Ram");
            my_slist1.Add(1.07, "Rohini");
            my_slist1.Add(1.04, "Mona");
            my_slist1.Add(1.01, "Neha");

            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();
            SortedList1 my_slist2 = new SortedList1() {
                                  { "b.01", 1 },
                                  { "b.02",2 },
                                  { "b.03", 3 },
                                  { "b.04", 4 }};

            foreach (DictionaryEntry pair in my_slist2)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
        }

    }
}
