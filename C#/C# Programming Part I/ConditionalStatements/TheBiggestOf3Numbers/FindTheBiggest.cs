//Write a program that finds the biggest of three numbers.

using System;

class FindTheBiggest
{
    static void Main()
    {
        Console.Write("Enter A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter C: ");
        double c = double.Parse(Console.ReadLine());
        double biggest = a;

        if (b > a)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }
        Console.WriteLine(biggest);
    }
}

