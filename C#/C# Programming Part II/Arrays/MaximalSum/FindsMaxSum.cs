//Write a program that finds the sequence of maximal sum in given array.

using System;

class FindsMaxSum
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

        int maxSum = 0;
        int maxSumStart = 0;
        int maxSumEnd = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            int currSum = 0;
            
            for (int j = i; j < intArray.Length; j++)
            {
                currSum += intArray[j];
                if (currSum > maxSum)
                {
                    maxSum = currSum;
                    maxSumStart = i;
                    maxSumEnd = j;
                }
            }
        }

        Console.WriteLine(maxSum);
        for (int i = maxSumStart; i <= maxSumEnd; i++)
        {
            Console.Write(intArray[i] + " ");
        }
        
        Console.WriteLine();
    }
}

