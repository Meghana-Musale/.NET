using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            //multiple variable
            int x = 5, y = 6, z = 50;
            int a, b, c;
            a = b = c = 50;

            Console.WriteLine("Integer :"+ myNum);
            Console.WriteLine("Double :"+ myDoubleNum);
            Console.WriteLine("Char :"+ myLetter);
            Console.WriteLine("Boolean :"+ myBool);
            Console.WriteLine("String :"+ myText);
            Console.WriteLine(x + y + z);
            Console.WriteLine(a + b + c);


        }
    }
}
