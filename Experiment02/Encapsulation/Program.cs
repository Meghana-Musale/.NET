using System;

namespace Encapsulation
{
    class Person
    {
        // Initializing with string.Empty fixes the CS8618 warning
        private string name = string.Empty; 

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            
            // Setting the value via the property (Encapsulation)
            myObj.Name = "Meghana";
            
            // Getting the value via the property
            Console.WriteLine(myObj.Name);
        }
    }
}
/*
Encapsulation 
-The meaning of Encapsulation, is to make sure that "sensitive" data is 
 hidden from users. To achieve this, you must:
    - declare fields/variables as private
    - provide public get and set methods, through properties, to access and update the value of
      a private field


Why Encapsulation?
- Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
- Fields can be made read-only (if you only use the get method), or write-only (if you only use the set method)
- Flexible: the programmer can change one part of the code without affecting other parts
- Increased security of data

 
*/