//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CharArrayComparer
{
    static void Main()
    {
        Console.Write("Please enter first row of letters separated by space: ");
        string[] firstArray = Console.ReadLine().Split();
        Console.Write("Please enter second row of letters separated by space: ");
        string[] secondArray = Console.ReadLine().Split();
        Console.WriteLine("First Array: | Second Array:");

        for (int i = 0; i < Math.Max(firstArray.Length, secondArray.Length); i++)
        {
            if (firstArray.Length - 1 < i)                          //If one array is longer tha the other returns no letter
            {
                Console.WriteLine("  No Letter  |{0,8}", secondArray[i]);
            }
            else if (secondArray.Length - 1 < i)
            {
                Console.WriteLine("{0,6}       |    No Letter", firstArray[i]);
            }
            else
            {
                Console.Write("{0,6}       |{1,8}     - ", firstArray[i], secondArray[i]);
                if (firstArray[i] == secondArray[i]                                                         //Also checks if capital letter is compared to the same letter in lower case
                    || Convert.ToChar(firstArray[i]) == Convert.ToChar(secondArray[i]) - 32 
                    || Convert.ToChar(firstArray[i]) == Convert.ToChar(secondArray[i]) + 32)
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

