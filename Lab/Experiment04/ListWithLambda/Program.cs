using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>() { 5, 2, 8, 1, 9 };

        Console.WriteLine("Original List:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Sort list using lambda expression
        numbers.Sort((a, b) => a.CompareTo(b));

        Console.WriteLine("Sorted List:");

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}