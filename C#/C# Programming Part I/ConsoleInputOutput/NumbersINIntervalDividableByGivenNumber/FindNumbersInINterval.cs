//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

using System;

class FindNumbersInINterval
{
    static void Main()
    {
        Console.Write("Enter Start number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter End number: ");
        int end = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

