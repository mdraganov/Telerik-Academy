//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).

using System;

class CountSubStrings
{
    static void Main()
    {
        Console.Write("Enter some text:  ");
        string inputText = Console.ReadLine();
        Console.Write("Enter a substring to search for:  ");
        string inputString = Console.ReadLine();
        int count = 0;

        for (int i = 0; i <= inputText.Length - inputString.Length; i++)
        {
            string currentSubStr = inputText.Substring(i, inputString.Length);
            if (currentSubStr == inputString)
            {
                count++;
                i += inputString.Length - 1;            // skips a few pointless iterations
            }
        }

        Console.WriteLine(count);
    }
}

