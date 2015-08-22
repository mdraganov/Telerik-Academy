//Write a program to calculate n! for each n in the range [1..100].

using System;
using System.Numerics;

class Factorials
{
    static void Main()
    {
        Print100Factorials();
    }

    private static void Print100Factorials()
    {
        BigInteger currentProduct = 1;
        for (int i = 1; i < 101; i++)
        {
            Console.Write("{0}! is: ", i);
            currentProduct *= i;
            Console.WriteLine(currentProduct);
            Console.WriteLine();
        }
    }
}

