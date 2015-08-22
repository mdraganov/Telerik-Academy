//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class CheckPointLocation
{
    static void Main()
    {
        Console.Write("Enter x coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Sqrt(x * x + y * y) <= 2);
    }
}

