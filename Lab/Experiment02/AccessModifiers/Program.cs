using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Car
    {
        //public  modifier
        public string carName = "BMW";
    }
    internal class Program
    {
        //private modifier
        private string name = "Meghana Musale";
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine(p1.name);
            Car c1 = new Car();
            Console.WriteLine(c1.carName);

        }
    }
}
/*four types of access modifiers 
1. public : the code is accessible for all classes
2. private : The code is only accessible within the same class
3. protected : The code is accessible within the same class , or in a class that is inherited from that class.
4. internal : The code is only accessible within its own assembly but not from another assembly 
 
Why Access Modifiers?
To control the visibility of class members (the security level of each individual class and class member).

To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users.
This is done by declaring fields as private. You will learn more about this in the next chapter.
 
note : By default, all members of a class are private if you don't specify an access modifier:

 
*/