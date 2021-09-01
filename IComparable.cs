
using System;

namespace ProgramFile
{
    class IComparable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Color[] colors = new Color[]
   {
        new Color()
        {
            Name = "Red"
        }, new Color()
        {
            Name = "Green"
        }, new Color()
        {
            Name = "Pink"
        }
   };
            Array.Sort(Color);
            Array.ForEach(Color, x => Console.WriteLine(x.Name));
        }


        public class Color : IComparable
        {
            public string Name
            {
                get;
                set;
            }
            public int MaxSpeed
            {
                get;
                set;
            }
            public int CompareTo(object obj)
            {
                if (!(obj is Color))
                {
                    throw new ArgumentException("Compared Object is not of Color");
                }
                Color car = obj as Color;
                return Name.CompareTo(Color.Name);
            }
        }
    }

}