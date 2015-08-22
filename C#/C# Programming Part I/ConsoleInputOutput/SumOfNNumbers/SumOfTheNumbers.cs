//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;

class SumOfTheNumbers
{
    static void Main()
    {
        Console.Write("Enter the number of numbers: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0.0;
        
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            sum = sum + double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The sum is {0}.", sum);
    }
}

 