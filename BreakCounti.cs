
using System;

namespace ProgramFile
{
    class BreakCounti
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            con obj1 = new con();
            obj1.con1();


            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}

class con
{
    public void con1()

    {

        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
            {
                continue;
            }
            Console.WriteLine(i);
        }
    }

}
