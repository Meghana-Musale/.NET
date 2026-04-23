using System;

class Program
{
    // Declare delegate
    public delegate void Operation();

    // Methods
    public static void Add()
    {
        Console.WriteLine("Addition Method Called");
    }

    public static void Subtract()
    {
        Console.WriteLine("Subtraction Method Called");
    }

    public static void Multiply()
    {
        Console.WriteLine("Multiplication Method Called");
    }

    static void Main()
    {
        Operation op;

        // Assign method
        op = Add;

        // Add more methods to delegate
        op = op + Subtract;
        op = op + Multiply;

        // Calling delegate
        op();
    }
}