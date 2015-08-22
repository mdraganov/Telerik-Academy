//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

class LeapYearChecker
{
    static void Main()
    {
        Console.Write("Enter an year: ");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Is leap: {0}", DateTime.IsLeapYear(input));
    }
}

