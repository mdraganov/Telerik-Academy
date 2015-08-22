//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

using System;

class CheckPrimes
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 2)
        {
            Console.WriteLine(false);
        }
        else
        {
            for (int i = 2; i <= number; i++)
            {
                if (i == number)
                {
                    Console.WriteLine(true);
                    break;
                }
                else if (number % i == 0)
                {
                    Console.WriteLine(false);
                    break;
                }
            }
        }
    }
}

