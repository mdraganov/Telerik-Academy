//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;

class IntSumator
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine().Split();
        int sum = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            sum += int.Parse(inputArray[i]);
        }

        Console.WriteLine(sum);
    }
}

