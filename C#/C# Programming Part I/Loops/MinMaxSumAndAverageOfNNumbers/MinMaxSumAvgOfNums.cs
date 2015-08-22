//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

class MinMaxSumAvgOfNums
{
    static void Main()
    {
        Console.Write("Enter how many integers you want: ");
        int intCount = int.Parse(Console.ReadLine());
        Console.Write("Enter integer: ");
        double input = double.Parse(Console.ReadLine()); ;
        double min = input;
        double max = input;
        double sum = input;
        double avg;

        for (int i = 0; i < intCount - 1; i++)
        {
            Console.Write("Enter integer: ");
            input = double.Parse(Console.ReadLine());
            if (input < min)
            {
                min = input;
            }
            else if (input > max)
            {
                max = input;
            }
            sum += input;
        }

        avg = sum / intCount;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0}", avg);
    }
}

