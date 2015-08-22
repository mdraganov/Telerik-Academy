//Write a program that reads a string, reverses it and prints the result at the console.

using System;

class StringReverser
{
    static void Main()
    {
        Console.Write("Enter some text:  ");
        string input = Console.ReadLine();
        char[] reverse = input.ToCharArray();
        Array.Reverse(reverse);
        Console.WriteLine(reverse);
    }
}

