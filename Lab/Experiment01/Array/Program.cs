using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] myNum = { 10, 20, 30, 40 };
            Console.WriteLine(cars[0]);
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);
            Console.WriteLine(myNum[1]);

            //loops through array
            Console.WriteLine("Loops through Array :");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            //multiimentional array
            Console.WriteLine("multiimentional array :");
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);
        }
    }
}
