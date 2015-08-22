//Write a program to convert binary numbers to their decimal representation.

using System;

class BinToDecConverter
{
    static void Main()
    {
        string input = Console.ReadLine();
        double result = new int();
        int powersOfTwo = 1;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            result += (input[i] - '0') * powersOfTwo;
            powersOfTwo *= 2;
        }
        Console.WriteLine(result);
    }
}
