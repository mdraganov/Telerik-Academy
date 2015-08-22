//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class FindMax
{
    static void Main(string[] args)
    {
        Console.Write("Enter int 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter int 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter int 3: ");
        int c = int.Parse(Console.ReadLine());

        int greaterAB = GetMax(a, b);
        int biggest = GetMax(c, greaterAB);

        Console.WriteLine(biggest);
    }

    static int GetMax(int first, int second)
    {
        if (first > second) return first;
        else return second;
    }
}

