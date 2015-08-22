//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter five numbers in a row: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split();
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += double.Parse(numbers[i]);
        }
        Console.WriteLine(sum);
    }
}

