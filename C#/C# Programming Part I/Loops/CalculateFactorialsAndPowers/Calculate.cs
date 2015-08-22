//Write a program that, for a given two integer numbers n and x, calculates 
//the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;

class Calculate
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        double factorial = 1;
        double result;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
            result = factorial / Math.Pow(x, i);
            sum += result;
        }
        Console.WriteLine("{0:0.00000}", sum);
    }
}

