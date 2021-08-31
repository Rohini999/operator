using System;

namespace ProgramFile
{
    class ValueDataType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 89;
            short s = 56;
            long l = 264;
            double d = 8.3586745d;
            float f = 3.7330645f;
            decimal dec = 389.5m;
            Console.WriteLine("integer: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + dec);

        }
    }

}