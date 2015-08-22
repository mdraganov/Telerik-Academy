//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class PrintIndexOfLetter
{
    static void Main()
    {
        char[] alphabet = new char[26];

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)((int)'A' + i);
        }

        Console.Write("Please enter a word with capital letters: ");
        char[] inputArray = Console.ReadLine().ToCharArray();

        for (int i = 0; i < inputArray.Length; i++)
        {
            bool indexFound = false;
            int index = 0;
            int devisor = 2;
            int subsetMiddle = alphabet.Length / 2;

            while (!indexFound)
            {
                if (alphabet[subsetMiddle] == inputArray[i])
                {
                    indexFound = true;
                    index = subsetMiddle;
                }
                else if (alphabet[subsetMiddle] > inputArray[i])
                {
                    if (devisor > alphabet.Length)
                    {
                        subsetMiddle -= 1;
                    }
                    else
                    {
                        devisor *= 2;
                        subsetMiddle -= alphabet.Length / devisor;
                    }
                }
                else
                {
                    if (devisor > alphabet.Length)
                    {
                        subsetMiddle += 1;
                    }
                    else
                    {
                        devisor *= 2;
                        subsetMiddle += alphabet.Length / devisor;
                    }
                }
            }

            Console.WriteLine(index);
        }
    }
}

