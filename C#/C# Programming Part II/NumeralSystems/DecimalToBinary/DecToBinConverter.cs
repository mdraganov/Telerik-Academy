//Write a program to convert decimal numbers to their binary representation.

using System;

class DecToBinConverter
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string result = string.Empty;
        do
        {
            if (input % 2 != 0)
            {
                result = 1 + result;
            }
            else if (input % 2 == 0)
            {
                result = 0 + result;
            }
            input /= 2;
        } while (input != 0);
        Console.WriteLine(result);
    }
}

