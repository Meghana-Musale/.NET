using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsInClass
{
    public class MyClass
    {
        public string fname;
        public string sname;
        public int age;

        public void function()
        {
            Console.WriteLine("Function is executed..");
        }

    }
    internal class Program
    {
        string name = "Meghana Musale";//field
        int age = 20;//field
        public void fun1()//method 
        {
            Console.WriteLine("Fun1 is executed..");
        }
        public void fun2()//method 
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
