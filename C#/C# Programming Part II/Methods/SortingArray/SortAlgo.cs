//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class SortAlgo
{
    static void Main()
    {
        int[] intArray = new int[] { 10, 2, 5, 6, 4, 8, 2, 4, 2, 6, 2, 4 };

        Sort(intArray);
        Console.WriteLine("Sorted in descending order: {0}", string.Join(" ", intArray));
        Array.Reverse(intArray);
        Console.WriteLine("Sorted in ascending order: {0}", string.Join(" ", intArray));
    }

    static int FindMax(int[] array, int start = 0)
    {
        int biggest = 0;
        int index = 0;

        for (int i = start; i < array.Length; i++)
        {
            if (array[i] > biggest)
            {
                biggest = array[i];
                index = i;
            }
        }

        return index;
    }

    static void Sort(int[] toSort)
    {
        for (int i = 0; i < toSort.Length; i++)
        {
            int maxNumIndex = FindMax(toSort, i);
            int temp = toSort[i];
            toSort[i] = toSort[maxNumIndex];
            toSort[maxNumIndex] = temp;
        }
    }
}

