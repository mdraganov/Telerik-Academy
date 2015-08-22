//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right)
//in given integer number n, has value of 1.

using System;

class CheckBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter index p: ");
        int index = int.Parse(Console.ReadLine());
        int getBit = number >> index & 1;
        bool result = getBit == 1;
        Console.WriteLine(result);
    }
}

