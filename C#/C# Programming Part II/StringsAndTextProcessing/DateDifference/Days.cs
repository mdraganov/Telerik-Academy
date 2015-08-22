//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

using System;

class Days
{
    static void Main()
    {
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine(Math.Abs(secondDate.Subtract(firstDate).Days));
    }
}

