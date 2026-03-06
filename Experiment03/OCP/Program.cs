//O :Open Closed Principle (OCP) : Open for extension but closed for modification

using System;

abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double radius = 5;

    public override double Area()
    {
        return 3.14 * radius * radius;
    }
}

class Rectangle : Shape
{
    public double length = 4;
    public double width = 3;

    public override double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main()
    {
        Shape c = new Circle();
        Shape r = new Rectangle();

        Console.WriteLine("Circle Area: " + c.Area());
        Console.WriteLine("Rectangle Area: " + r.Area());
    }
}