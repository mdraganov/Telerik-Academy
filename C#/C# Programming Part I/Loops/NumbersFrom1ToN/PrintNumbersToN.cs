//Write a program that enters from the console a positive integer n and prints all the numbers
//from 1 to n, on a single line, separated by a space.

using System;

class PrintNumbersToN
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}

