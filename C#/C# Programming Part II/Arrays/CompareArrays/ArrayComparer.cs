//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class ArrayComparer
{
    static void Main()
    {
        Console.Write("Please enter first row of integers separated by space: ");
        string[] firstArray = Console.ReadLine().Split();
        Console.Write("Please enter second row of integers separated by space: ");
        string[] secondArray = Console.ReadLine().Split();
        Console.WriteLine("First Array: | Second Array:");

        for (int i = 0; i < Math.Max(firstArray.Length, secondArray.Length); i++)
        {
            if (firstArray.Length - 1 < i)
            {
                Console.WriteLine("  No Value   |{0,8}", secondArray[i]);
            }
            else if (secondArray.Length - 1 < i)
            {
                Console.WriteLine("{0,6}       |    No Value", firstArray[i]);
            }
            else
            {
                Console.Write("{0,6}       |{1,8}     - ", firstArray[i], secondArray[i]);
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("equal");
                }
                else
                {
                    Console.WriteLine("different");
                }
            }
        }
    }
}

