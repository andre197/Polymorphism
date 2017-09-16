
using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(3);
        Rectangle rectangle = new Rectangle(5,2);

        Console.WriteLine(circle.CalculateArea());
        Console.WriteLine(circle.CalculatePerimeter());
        Console.WriteLine(circle.Draw());

        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(rectangle.CalculatePerimeter());
        Console.WriteLine(circle.Draw());
    }
}

