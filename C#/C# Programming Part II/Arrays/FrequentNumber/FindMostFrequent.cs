//Write a program that finds the most frequent number in an array.

using System;

class FindMostFrequent
{
    static void Main()
    {
        Console.Write("Please enter a row of integers separated by space: ");
        string[] inputArray = Console.ReadLine().Split();
        int[] intArray = new int[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            intArray[i] = int.Parse(inputArray[i]);
        }

        bool[] doubleCountCheck = new bool[intArray.Length];

        int count = 1;
        int freqNumber = intArray[0];

        for (int i = 0; i < intArray.Length; i++)
        {
            if (doubleCountCheck[i])
            {
                continue;
            }
            else
            {
                int currCount = 1;

                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[j] == intArray[i])
                    {
                        currCount++;
                        doubleCountCheck[j] = true;
                    }
                }

                if (currCount > count)
                {
                    count = currCount;
                    freqNumber = intArray[i];
                }
            }
        }

        Console.WriteLine("{0} ({1} times)", freqNumber, count);
    }
}

