//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class FindMaxKSum
{
    static void Main()
    {
        Console.Write("Enter N, the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K, the number of elements with max sum: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter N integers: ");
        int[] intArray = new int[n];

        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write("Element {0}: ", i);
            intArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine();

        Array.Sort(intArray);
        int sum = 0;

        Console.Write("Elements with maximum sum: ");

        for (int i = intArray.Length - 1; i > intArray.Length - 1 - k; i--)
        {
            sum += intArray[i];
            Console.Write(intArray[i] + " ");
        }

        Console.WriteLine();
        Console.WriteLine("Max sum is {0}", sum);
    }
}   
