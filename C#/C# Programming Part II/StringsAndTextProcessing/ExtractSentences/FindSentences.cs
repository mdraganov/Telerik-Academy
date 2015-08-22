//Write a program that extracts from a given text all sentences containing given word.
//Example:
//The word is: in
//The text is: We are living in a yellow submarine. We don't have anything else. 
//Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;

class FindSentences
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string inputText = " " + Console.ReadLine();
        Console.Write("Enter word: ");
        string searchedWord = Console.ReadLine();
        int sentenceStart = 1;
        int sentenceEnd = 0;

        while (sentenceStart < inputText.Length)
        {
            for (int i = sentenceStart; i < inputText.Length - 2; i++)          //Finds current sentence boundaries.
            {
                if (inputText[i] == '.' && char.IsUpper(inputText[i + 2]))
                {
                    sentenceEnd = i;
                    break; 
                }
                else if (i == inputText.Length - 3)
                {
                    sentenceEnd = i + 2;
                    break;
                }
            }

            int subStrLength = sentenceEnd + 1 - sentenceStart;
            int searchedWordIndex = inputText.ToUpper().IndexOf(searchedWord.ToUpper(), sentenceStart, subStrLength);       //Finds the first instance of the word in the curr. sentence if there's any.

            while (searchedWordIndex != -1)     //Checks if there are any more instances of the word in the rest of the current sentance.
            {
                if (searchedWordIndex != -1 && !char.IsLetter(inputText[searchedWordIndex - 1]) && !char.IsLetter(inputText[searchedWordIndex + searchedWord.Length]))
                {
                    Console.Write(inputText.Substring(sentenceStart, subStrLength) + " ");
                }
                searchedWordIndex = inputText.ToUpper().IndexOf(searchedWord.ToUpper(), searchedWordIndex + 1, subStrLength - (searchedWordIndex + 1 - sentenceStart));
            }

            sentenceStart = sentenceEnd + 2;
        }

        Console.WriteLine();
    }
}

