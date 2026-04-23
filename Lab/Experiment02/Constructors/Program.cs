using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class MyClass
    {
        public int num;
        public MyClass() 
        {
            num = 10;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass();
            Console.WriteLine("Number is :"+ m1.num);
        }
    }
}
