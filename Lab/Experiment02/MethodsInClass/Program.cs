using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsInClass
{
    public class MyClass
    {
        // Fix CS8618: Initialize with empty strings
        public string fname = string.Empty;
        public string sname = string.Empty;
        public int age;

        public void function()
        {
            Console.WriteLine("Function is executed..");
        }
    }

    internal class Program
    {
        string name = "Meghana Musale";
        
        // Removed 'int age = 20;' here because it was never used, 
        // which caused the CS0414 warning.
        
        public void fun1()
        {
            Console.WriteLine("Fun1 is executed..");
        }

        public void fun2()
        {
            Console.WriteLine("Fun2 is executed..");
        }

        static void Main(string[] args)
        {
            Program p1 = new Program();
            MyClass m1 = new MyClass();

            p1.fun1();
            Console.WriteLine(p1.name);
            p1.fun2();
            
            Console.WriteLine();
            
            m1.function();
            m1.fname = "Shravani ";
            Console.WriteLine(m1.fname);
            m1.sname = "Magdum";
            Console.WriteLine(m1.sname);
            m1.age = 20;
            Console.WriteLine(m1.age);
        }
    }
}