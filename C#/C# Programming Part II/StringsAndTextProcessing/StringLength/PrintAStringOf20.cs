//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Text;

class PrintAStringOf20
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder(20);

        for (int i = 0; i < 20; i++)
        {
            if (i >= input.Length)
            {
                result.Append('*');
            }
            else
            {
                result.Append(input[i]);
            }
        }

        Console.WriteLine(result);
    }
}

