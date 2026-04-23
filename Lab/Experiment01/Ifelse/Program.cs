using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifelse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            
            //short - hand if-else
            int time1 = 20;
            string result = (time1 < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}
