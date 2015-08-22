//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class NumbersRandomizer
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        bool[] checkPosition = new bool[n + 1];
        Random rndm = new Random();
        int random = new int();

        for (int i = 0; i < n; i++)
        {
            random = rndm.Next(1, n + 1);
            if (checkPosition[random] == false)
            {
                numbers[i] = random;
                checkPosition[random] = true;
            }
            else
            {
                i--;
            }
        }
        foreach (int i in numbers)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}

