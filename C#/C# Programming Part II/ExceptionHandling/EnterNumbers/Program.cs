//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        List<int> tenNums = new List<int>(10);

        try
        {
            ReadNumber(tenNums);
            Console.WriteLine(string.Join(" ", tenNums));
        }
        catch (Exception theException)
        {
            Console.WriteLine(theException.Message);
        }
    }

    static void ReadNumber(List<int> addNums)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter number {0}: ", i);
            int input = int.Parse(Console.ReadLine());

            if (addNums.Count > 0 && input < addNums[i - 1])
            {
                throw new ArgumentException("Number shoud be bigger than previous.");
            }

            addNums.Add(input);
        }
    }
}

