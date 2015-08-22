//Write a program that finds the maximal increasing sequence in an array.

using System;

class FindMaxIncreasingSequence
{
    static void Main()
    {
        Console.Write("Please enter a row of integers separated by space: ");
        string[] inputArray = Console.ReadLine().Split();
        int maxSequenceCount = 1;
        int sequenceStart = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            int currSequenceCount = 1;

            for (int j = i; j < inputArray.Length - 1; j++)
            {
                if (int.Parse(inputArray[j]) + 1 == int.Parse(inputArray[j + 1]))
                {
                    currSequenceCount++;
                }
                else
                {
                    break;
                }
            }

            if (currSequenceCount > maxSequenceCount)
            {
                maxSequenceCount = currSequenceCount;
                sequenceStart = i;
                i += maxSequenceCount - 2;          //skips the rest of the current sequence
            }
        }

        for (int i = sequenceStart; i < sequenceStart + maxSequenceCount; i++)
        {
            Console.Write(inputArray[i] + " ");
        }

        Console.WriteLine();
    }
}


