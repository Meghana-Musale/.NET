/* Question 6 : What is LINQ Queris? 
    1. Defination :
        - LINQ is used to retrieve, filter, sort, and manipulate data from collections like lists, arrays, databases, XML, etc.

 */

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = {1,2,3,4,5,6,7,8};

        var evenNumbers = from n in numbers
                          where n % 2 == 0
                          select n;

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}