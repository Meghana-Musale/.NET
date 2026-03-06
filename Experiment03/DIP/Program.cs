//D : Dependency Inversion Principle (DIP) : Depend on interfaces, not concrete classes

using System;

interface IDevice
{
    void Start();
}

class Keyboard : IDevice
{
    public void Start()
    {
        Console.WriteLine("Keyboard connected");
    }
}

class Computer
{
    private IDevice device;

    public Computer(IDevice device)
    {
        this.device = device;
    }

    public void Run()
    {
        device.Start();
    }
}

class Program
{
    static void Main()
    {
        IDevice keyboard = new Keyboard();
        Computer pc = new Computer(keyboard);
        pc.Run();
    }
}