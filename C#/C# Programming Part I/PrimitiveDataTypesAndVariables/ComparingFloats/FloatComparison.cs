//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

using System;

class FloatComparison
{
    static void Main()
    {
        Console.Write("Enter first fraction: ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("Enter second fraction: ");
        double numberB = double.Parse(Console.ReadLine());
        bool result = Math.Abs(numberA - numberB) < 0.000001 ? true : false;
        Console.WriteLine(result);
    }
}

