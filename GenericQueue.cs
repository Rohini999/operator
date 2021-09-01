
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    namespace ProgramFile
    {
        public class GenericQueue
        {
            public static void main(string[] args)
            {
                Queue<String> student = new Queue<String>();
                //adding item in queue
                student.Enqueue("rohini");
                student.Enqueue("jadhav");
                student.Enqueue("ram");
                student.Enqueue("amol");
                student.Enqueue("aarti");
                print(student);
                //removing item
                Console.WriteLine("\nremoving {0} from list. \nnew list is : ", student.Dequeue());
                 print(student);
                //copy array item to queue
                String[] city = { "maharashtra", "parli", "tower raod" };
                Queue<String> citylist = new Queue<String>(city);
                Console.WriteLine("\nprinting city list");
                Console.WriteLine(citylist);
                //count items in queue
                //console.writeline("count{0}", citylist.count);
            }
            public static void print(Queue<string> q)
            {
                foreach (string s in q)
                {
                    Console.Write(s.ToString() + " | ");
                }
            }
        }
    }


