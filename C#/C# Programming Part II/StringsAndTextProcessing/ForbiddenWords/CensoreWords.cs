//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

using System;
using System.Text;

class CensoreWords
{
    static void Main()
    {
        Console.Write("Enter the text you want do censore: ");
        StringBuilder text = new StringBuilder(Console.ReadLine());
        Console.Write("Enter forbidden words: ");
        char[] separators = {' ', ','};
        string[] forbWords = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < forbWords.Length; i++)
        {
            text.Replace(forbWords[i], new string('*', forbWords[i].Length));
        }

        Console.WriteLine(text);
    }
}

