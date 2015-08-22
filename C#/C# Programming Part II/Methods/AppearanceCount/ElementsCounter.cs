//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class ElementsCounter
{
    static void Main()
    {
        Console.Write("Enter a row of numbers separated by space: ");
        string[] arrayInput = Console.ReadLine().Split();
        Console.Write("Enter the number you want to count: ");
        string numberInput = Console.ReadLine();

        Counter(arrayInput, numberInput);
    }

    static void Counter(string[] inputArray, string inputNum)
    {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] == inputNum) count++;
        }

        if (count == 0) Console.WriteLine("This number is not in the array.");
        else Console.WriteLine("The number appears {0} times.", count);
    }
}

