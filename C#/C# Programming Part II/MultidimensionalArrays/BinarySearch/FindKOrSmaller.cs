//Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
//and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class FindKOrSmaller
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter K: ");
        int k = int.Parse(Console.ReadLine());
        int indexInArray = 0;
        bool found = false;

        int[] inputArray = new int[n];

        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write("Enter element {0}: ", i);
            inputArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(inputArray);

        while (!found)
        {
            indexInArray = Array.BinarySearch(inputArray, k);
            if (indexInArray < 0)
            {
                k--;
            }
            else
            {
                found = true;
            }
        }

        Console.WriteLine("Largest number <= K: {0}", inputArray[indexInArray]);
    }
}

