//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold 
//the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyaABit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        int value = int.Parse(Console.ReadLine());
        int setBit = 1 << position;

        if (value == 0)
        {
            Console.WriteLine(number & ~setBit);
        }
        else
        {
            Console.WriteLine(number | setBit);
        }
    }
}

