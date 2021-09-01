using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ProgramFile
{
    class CreatingTask
    {
        static void HelloConsole()
        {
            Console.WriteLine("Hollooo");

        }
        static void Main(string[] args)
        { //Action delegate
            Action action = delegate
              {
                  Console.WriteLine("Message for stask");
              };
            Task task1 = new Task(action);
            task1.Start();
            Console.WriteLine(task1.Status);
             
            //annomous fun
            Task task2 = new Task(delegate
            {
                HelloConsole();
            });
            task2.Start();

            //lambda exp
            Task task3 = new Task(() => HelloConsole());
                task3.Start();

            Console.ReadKey();
           
        }
    }
}     
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
  