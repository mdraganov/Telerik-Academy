//Write a program that finds the biggest of five numbers by using only five if statements.

using System;

class BiggestNumber
{
    static void Main()
    {
        Console.Write("Enter A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter C: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter D: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter E: ");
        double e = double.Parse(Console.ReadLine());
        double biggest = a;

        if (b > a)
        {
            biggest = b;            
        }
        if (c > biggest)
        {
            biggest = c;
        }
        if (d > biggest)
        {
            biggest = d;
        }
        if (e > biggest)
        {
            biggest = e;
        }
        Console.WriteLine(biggest);
    }
}

