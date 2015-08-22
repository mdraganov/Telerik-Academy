//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

class NeighboursComparer
{
    static void Main()
    {
        Console.Write("Enter a row of numbers separated by space: ");
        string[] arrayInput = Console.ReadLine().Split();
        Console.Write("Enter the position you want to check: ");
        int positionInput = int.Parse(Console.ReadLine());

        CheckNeighbours(arrayInput, positionInput);
    }

    static void CheckNeighbours(string[] inputArray, int position)
    {
        if (position + 1 >= inputArray.Length || position - 1 < 0)
        {
            Console.WriteLine("The element does not have two neighbours.");
        }
        else
        {
            bool checkPrevious = int.Parse(inputArray[position]) > int.Parse(inputArray[position - 1]);
            bool checkNext = int.Parse(inputArray[position]) > int.Parse(inputArray[position + 1]);
            if (checkNext && checkPrevious) Console.WriteLine("The element is larger than it's two neighbours.");
            else Console.WriteLine("The element is not larger than it's two neighbours.");
        }
    }    
}

