using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes
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

            Console.WriteLine(myNum.GetType());
            Console.WriteLine(myDoubleNum.GetType());
            Console.WriteLine(myLetter.GetType());
            Console.WriteLine(myBool.GetType());
            Console.WriteLine(myText.GetType());
            
        }
    }
}
