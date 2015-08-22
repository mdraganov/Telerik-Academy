//In combinatorics, the number of ways to choose k different members out of a group of n different elements 
//(also known as the number of combinations) is calculated by the following formula: formula For example, 
//there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.

using System;

class CombinatoricsCalculations
{
    static void Main()
    {
        Console.Write("Enter n and k (1 < k < n < 100)\nn: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k: ");
        int k = int.Parse(Console.ReadLine());
        long nFactorial = 1;
        long kFactorial = 1;

        for (int i = n - k + 1; i <= n; i++)
        {
            nFactorial *= i;
        }
        for (int i = 1; i <=k; i++)
        {
            kFactorial *= i;
        }
        long result = nFactorial / kFactorial;
        Console.WriteLine(result);
    }
}

