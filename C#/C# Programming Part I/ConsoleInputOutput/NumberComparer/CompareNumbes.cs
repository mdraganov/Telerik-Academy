//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

class CompareNumbes
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Greater: " + Math.Max(a, b));
    }
}

