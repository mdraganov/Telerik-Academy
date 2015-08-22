//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.

using System;

class PrintUnicodeChars
{
    static void Main()
    {
        string input = Console.ReadLine();
        
        foreach (char ch in input)
        {
            Console.Write("\\u{0:X4}", (int)ch);
        }
    }
}

