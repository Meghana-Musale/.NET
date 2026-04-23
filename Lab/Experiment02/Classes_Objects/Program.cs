using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    internal class Program
    {
        string name = "Meghana Musale";
        int age = 20;
        static void Main(string[] args)
        {
            //multiple objects 
            Program p1 = new Program();
            Program p2 = new Program();
            Console.WriteLine("Nmae :"+ p1.name);
            Console.WriteLine("Age :"+ p1.age);
            Console.WriteLine(p2.name);
        }
    }
}
