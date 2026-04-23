using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //implicit casting
            Console.WriteLine("Implicit casting :");
            int myInt = 9;
            double myDouble = myInt;       

            Console.WriteLine(myInt);      
            Console.WriteLine(myDouble);

            //explicit casting
            Console.WriteLine("Explicit Casting :");
            double myDouble1 = 9.78;
            int myInt1 = (int)myDouble1;  

            Console.WriteLine(myDouble1);  
            Console.WriteLine(myInt1);

            //type conversion methods 
            Console.WriteLine("Type Conversion Methos :");
            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool1 = true;

            Console.WriteLine(Convert.ToString(myInt2));    
            Console.WriteLine(Convert.ToDouble(myInt2));    
            Console.WriteLine(Convert.ToInt32(myDouble2));  
            Console.WriteLine(Convert.ToString(myBool1));
        }
    }
}
