//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Please enter a row of sorted integers separated by space: ");
        string[] inputArray = Console.ReadLine().Split();
        int[] sortedArray = new int[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            sortedArray[i] = int.Parse(inputArray[i]);
        }

        Console.Write("Please enter the number you want the index of: ");
        int n = int.Parse(Console.ReadLine());

        bool indexFound = false;
        int index = 0;
        int devisor = 2;
        int subsetMiddle = sortedArray.Length / 2;

        while (!indexFound)
        {
            if (sortedArray[subsetMiddle] == n)
            {
                indexFound = true;
                index = subsetMiddle;
            }
            else if (sortedArray[subsetMiddle] > n)
            {
                if (devisor > sortedArray.Length)
                {
                    subsetMiddle -= 1;
                }
                else
                {
                    devisor *= 2;
                    subsetMiddle -= sortedArray.Length / devisor;
                }
            }
            else
            {
                if (devisor > sortedArray.Length)
                {
                    subsetMiddle += 1;
                }
                else
                {
                    devisor *= 2;
                    subsetMiddle += sortedArray.Length / devisor;
                }
            }
        }

        Console.WriteLine("The index of the chosen element is: " + index);
    }
}

