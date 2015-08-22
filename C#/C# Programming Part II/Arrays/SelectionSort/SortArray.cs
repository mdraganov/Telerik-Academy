//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
//smallest from the rest, move it at the second position, etc.

using System;

class SortArray
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

        int smallest = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            smallest = intArray[i];
            int position = 0;

            for (int j = i + 1; j < intArray.Length; j++)
            {
                if (intArray[j] < smallest)
                {
                    smallest = intArray[j];
                    position = j;
                }
            }

            if (position == 0)
            {
                continue;
            }

            intArray[position] = intArray[i];
            intArray[i] = smallest;            
        }

        foreach (var item in intArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

