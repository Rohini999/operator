using System; 
namespace ProgramFile
    {
        class Complex
    {



        int real, img;



        // Defining the constructor 

        public Complex()

        {

            real = 0;

            img = 0;

        }



        // SetValue method sets  

        // value of real and img 

        public void SetValue(int r, int i)

        {

            real = r;

            img = i;

        }



        // DisplayValue displays  

        // values of real and img 

        public void DisplayValue()

        {

            Console.WriteLine("Real = " + real);

            Console.WriteLine("Imaginary = " + img);

        }



        // Defining the destructor 

        // for class Complex 

        ~Complex()

        {

            Console.WriteLine("Destructor was called");

        }



    }




    // Driver Class 

    class Destrutor
    {



        // Main Method 

        static void Main(string[] args)

        {



            // Creating an instance of class  

            // Complex C invokes constructor 

            Complex C = new Complex();



            // Calling SetValue method using 


            C.SetValue(2, 3);



            // Displaying values of real 

            // and imaginary parts 

            C.DisplayValue();



            // Instance is no longer needed 

            // Destructor will be called 



        }  



    } 



}
