using System;

class Program
{
    // Delegate declaration
    public delegate void Operation();

    static void Main()
    {
        Operation op;

        // Lambda expressions
        op = () => Console.WriteLine("Addition Method Called");
        op += () => Console.WriteLine("Subtraction Method Called");
        op += () => Console.WriteLine("Multiplication Method Called");

        // Call delegate
        op();
    }
}