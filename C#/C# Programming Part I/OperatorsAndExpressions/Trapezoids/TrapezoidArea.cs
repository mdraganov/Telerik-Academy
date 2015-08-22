//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter sides and height of the trapezoid.");
        Console.Write("Side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine("The area is " + (a + b) / 2 * h);
    }
}

