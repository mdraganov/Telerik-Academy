//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class FindSum
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

        Console.Write("Please enter sum: ");
        int sum = int.Parse(Console.ReadLine());
        int sumStart = 0;
        int sumEnd = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            int currSum = 0;
            for (int j = i; j < intArray.Length; j++)
            {
                currSum += intArray[j];
                if (currSum == sum)
                {
                    sumStart = i;
                    sumEnd = j;
                }
            }
        }

        for (int i = sumStart; i <= sumEnd; i++)
        {
            Console.Write(intArray[i] + " ");
        }

        Console.WriteLine();
    }
}

