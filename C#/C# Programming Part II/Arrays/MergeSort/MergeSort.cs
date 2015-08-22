//Write a program that sorts an array of integers using the Merge sort algorithm.

using System;

class MergeSort
{
    static void Main()
    {
        Console.Write("Please enter a row of integers separated by space: ");
        string[] inputArray = Console.ReadLine().Split();
        int[] notSorted = new int[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            notSorted[i] = int.Parse(inputArray[i]);
        }

        int[] sortedArray = MergeSortAlgo(notSorted);

        foreach (var item in sortedArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static int[] MergeSortAlgo(int[] toSort)
    {
        if (toSort.Length == 1)
        {
            return toSort;
        }
        
        //Split the array in two

        int[] firstHalf = new int[toSort.Length - toSort.Length / 2];
        int[] secondHalf = new int[toSort.Length / 2];

        for (int i = 0; i < firstHalf.Length; i++)
        {
            firstHalf[i] = toSort[i];
        }

        for (int i = toSort.Length - toSort.Length / 2; i < toSort.Length; i++)
        {
            secondHalf[i - (toSort.Length - toSort.Length / 2)] = toSort[i];
        }

        int[] sortedFirstHalf = MergeSortAlgo(firstHalf);
        int[] sortedSecondHalf = MergeSortAlgo(secondHalf);
        int[] result = new int[sortedFirstHalf.Length + sortedSecondHalf.Length];

        //Sorts and merges the two halves

        bool[] sortedFirstHalfChek = new bool[sortedFirstHalf.Length];          //Checks if the element from the first half has been sorted and merged yet.
        bool[] sortedSecondHalfCheck = new bool[sortedSecondHalf.Length];       //Checks if the element from the second half has been sorted and merged yet.
        int currElementFirstHalf = 0;
        int currElementFirstHalfPosition = 0;
        int currElementSecondHalf = 0;
        int currElementSecondHalfPosition = 0;

        for (int i = 0; i < result.Length; i++)                     //Fills the resulting array from the two halves.
        {
            for (int j = 0; j < sortedFirstHalf.Length; j++)        //Check what's the current element in the first half that is to be sorted.
            {
                if (!sortedFirstHalfChek[j])
                {
                    currElementFirstHalf = sortedFirstHalf[j];
                    currElementFirstHalfPosition = j;
                    break;
                }
            }

            for (int j = 0; j < sortedSecondHalf.Length; j++)       //Check what's the current element in the second half that is to be sorted.
            {
                if (!sortedSecondHalfCheck[j])
                {
                    currElementSecondHalf = sortedSecondHalf[j];
                    currElementSecondHalfPosition = j;
                    break;
                }
            }

            if (currElementFirstHalf <= currElementSecondHalf && !sortedFirstHalfChek[sortedFirstHalfChek.Length - 1])       //Compares the elements from both halves and sets the smaller in result[i]
            {
                result[i] = currElementFirstHalf;
                sortedFirstHalfChek[currElementFirstHalfPosition] = true;
            }
            else if (currElementFirstHalf > currElementSecondHalf && !sortedSecondHalfCheck[sortedSecondHalfCheck.Length - 1])
            {
                result[i] = currElementSecondHalf;
                sortedSecondHalfCheck[currElementSecondHalfPosition] = true;
            }
            else if (sortedFirstHalfChek[sortedFirstHalfChek.Length - 1])
            {
                result[i] = currElementSecondHalf;
                sortedSecondHalfCheck[currElementSecondHalfPosition] = true;
            }
            else
            {
                result[i] = currElementFirstHalf;
                sortedFirstHalfChek[currElementFirstHalfPosition] = true;
            }
        }

        return result;
    }    
}

