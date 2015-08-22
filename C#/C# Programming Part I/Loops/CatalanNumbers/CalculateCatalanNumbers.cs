//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).

using System;

class CalculateCatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n (1 <= n <= 100)\nn: ");
        int n = int.Parse(Console.ReadLine());
        decimal nFactorial = 1m;
        decimal kFactorial = 1m;

        for (int i = n + 1; i <= n * 2; i++)
        {
            nFactorial *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            kFactorial *= i;
        }
        decimal result = nFactorial / kFactorial;
        Console.WriteLine(result);
    }
}

