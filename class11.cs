       
using System;
//Grade program//
namespace ProgramFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double Bio, phy, che, Eng, m1;

            string nm;
            string[] studentId = { "STU01", "STU02", "STU03", "STU04", "STU05" };
            int[] marks = { 76, 83, 92, 65, 34 };

            Console.Write("\n\n");
            Console.Write("Calculate the grade,   to take marks of five subjects:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the Name of the Student :");
            nm = Console.ReadLine();

            Console.Write("Input  the marks of Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Computer Application : ");
            ca = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of m1 : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  m2 : ");
            che = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Finds the grade for each student");
            for (int i = 0; i < studentId.Length; i++)
            {
                if (marks[i] > 90)
                {
                    Console.WriteLine(studentId[i] + " Grade: " + "A");
                }
                else if (marks[i] > 80)
                {
                    Console.WriteLine(studentId[i] + " Grade: " + "B");
                }
                else if (marks[i] > 70)
                {
                    Console.WriteLine(studentId[i] + " Grade: " + "C");
                }
                else if (marks[i] > 50)
                {
                    Console.WriteLine(studentId[i] + " Grade: " + "D");
                }
                else
                {
                    Console.WriteLine(studentId[i] + " Grade: " + "FAIL");
                }
            }
            Console.ReadKey();


        }
    }
}



























//namespace program

//{

//    class program1

//    {

//        static void Main(string[] args)

//        {

//            int num1, num2, num3, num4, num5, num6, total;

//            float percentage;

//            char option;

//            Console.WriteLine("enter the marks of all subjects: ");

//            Console.Write("enter the subject1 marks: ");

//            num1 = Convert.ToInt32(Console.ReadLine());

//            Console.Write("enter the subject2 marks: ");

//            num2 = Convert.ToInt32(Console.ReadLine());

//            Console.Write("enter the subject3 marks: ");

//            num3 = Convert.ToInt32(Console.ReadLine());

//            Console.Write("enter the subject4 marks: ");

//            num4 = Convert.ToInt32(Console.ReadLine());

//            Console.Write("enter the subject5 marks: ");

//            num5 = Convert.ToInt32(Console.ReadLine());

//            Console.Write("enter the subject6 marks: ");

//            num6 = Convert.ToInt32(Console.ReadLine());

//            total = num1 + num2 + num3 + num4 + num5 + num6;

//            percentage = total / 6;

//            if (percentage > 75)

//            {

//                option = '1';

//            }

//            else if (percentage > 60)

//            {

//                option = '2';

//            }

//            else if (percentage > 50)

//            {

//                option = '3';

//            }

//            else if (percentage >= 35)

//            {

//                option = '4';

//            }

//            else

//            {

//                option = '5';

//            }

//            Console.WriteLine("the result of student with grade:");

//            Console.WriteLine("subject1 marks: { 0}", num1);

//            Console.WriteLine("subject1 marks: { 0}", num2);

//            Console.WriteLine("subject1 marks: { 0}", num3);

//            Console.WriteLine("subject1 marks: { 0}", num4);

//            Console.WriteLine("subject1 marks: { 0}", num5);

//            Console.WriteLine("subject1 marks: { 0}", num6);

//            Console.WriteLine("total marks: { 0}", total);

//            Console.WriteLine("percentage: { 0}", percentage);

//            switch (option)

//            {

//                case '1':

//                    Console.WriteLine("grade: first class with distinction");

//                    break;

//                case '2':

//                    Console.WriteLine("grade: first class");

//                    break;

//                case '3':

//                    Console.WriteLine("grade: second class");

//                    break;

//                case '4':

//                    Console.WriteLine("grade: third class");

//                    break;

//                case '5':

//                    Console.WriteLine("f a i l");

//                    break;

//                default:

//                    Console.WriteLine("invalid grade");

//                    break;

//            }

//            Console.ReadLine();

//        }

//    }

//}


//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//namespace calculator 
//{      public class Class1 
//    {
//       // public int sum(int n1, int n2)  
//        {             
//            return (n1 + n2);    
//        }          
//        public int sub(int n1, int n2)  
//        {         
//            return (n1 + n2);     
//        }
//        public int mul(int n1, int n2)    
//        {
//            return (n1 + n2);     
//        }
//    } 
//} 


