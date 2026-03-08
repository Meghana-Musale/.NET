using System;

class Calculator
{
    // Declare delegate
    public delegate double Operation(double a, double b);

    // Methods
    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Division by zero not allowed");
            return 0;
        }
        return a / b;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("Choose operation (+, -, *, /): ");
        char choice = Convert.ToChar(Console.ReadLine()!);

        Operation op;

        switch (choice)
        {
            case '+':
                op = Add;
                break;

            case '-':
                op = Subtract;
                break;

            case '*':
                op = Multiply;
                break;

            case '/':
                op = Divide;
                break;

            default:
                Console.WriteLine("Invalid operation");
                return;
        }

        double result = op(num1, num2);
        Console.WriteLine("Result = " + result);
    }
}