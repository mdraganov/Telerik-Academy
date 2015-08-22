//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter index p: ");
        int index = int.Parse(Console.ReadLine());
        int bitAtP = number >> index & 1;
        Console.WriteLine("The bit at P is: " + bitAtP);
    }
}

