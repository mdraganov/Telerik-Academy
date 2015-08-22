//Write a method that reverses the digits of given decimal number.

using System;

class NumberReverser
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        char[] inputArray = Console.ReadLine().ToCharArray();

        Reverse(inputArray);

        Console.WriteLine(inputArray);
    }

    static void Reverse(char[] toReverse)
    {
        char temp;
        for (int i = 0; i < toReverse.Length / 2; i++)
        {
            temp = toReverse[toReverse.Length - 1 - i];
            toReverse[toReverse.Length - 1 - i] = toReverse[i];
            toReverse[i] = temp;
        }
    }
}

