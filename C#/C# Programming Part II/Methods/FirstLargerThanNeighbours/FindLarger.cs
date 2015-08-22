//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FindLarger
{
    static void Main()
    {
        int[] intArray = new int[] { 1, 2, 5, 6, 4, 8, 2, 4, 2, 6, 2, 4 };

        Console.WriteLine(CheckNeighbours(intArray));       
    }

    static int CheckNeighbours(int[] inputArray)
    {
        int index = -1;
        for (int i = 1; i < inputArray.Length - 1; i++)
        {
            if (inputArray[i] > inputArray[i - 1] && inputArray[i] > inputArray[i + 1])
            {
                index = i;
                break;
            }
        }

        return index;
    }
}
