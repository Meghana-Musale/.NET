using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Meghana ";
            string str2 = "Musale";
            Console.WriteLine(str1);//simple string 
            Console.WriteLine(str1.ToUpper());//string methods
            Console.WriteLine(str2.ToLower());
            Console.WriteLine(str1 + str2);//string concat
            Console.WriteLine(string.Concat(str1, str2));
            string name = $"My full name is: {str1} {str2}";//string interpolation

            Console.WriteLine(name);
        }
    }
}
