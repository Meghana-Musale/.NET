using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While loop
            Console.WriteLine("While loop :");
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            //do-while loop
            Console.WriteLine("do-while loop :");
            int j = 5;
            do
            {
                Console.WriteLine(j);
                j--;
            }while (j > 0);

            //for loop
            Console.WriteLine("For loop :");
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine(k);
            }

            //for each loop
            Console.WriteLine("foreach loop :");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string l in cars)
            {
                Console.WriteLine(l);
            }
        }
    }
}
