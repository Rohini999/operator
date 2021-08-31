
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace ProgramFile
{
    class Room : ICloneable
    {
        int width;

        public Room(int width)
        {
            this.width = width;
        }

        public object Clone()
        {
            return new Room(this.width);
        }

        public override string ToString()
        {
            return string.Format("Width of Room = {0}", this.width);
        }
    }


    class Cloneable
    {
        static void Main()
        {
            Room roomOne = new Room(1999);
            Room roomTwo = roomOne.Clone() as Room;

            Console.WriteLine("{0}mm", roomOne);
            Console.WriteLine("{0}mm", roomTwo);



        }
    }
}