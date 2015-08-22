//Write an expression that checks if given integer is odd.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        bool result = number % 2 != 0;
        Console.WriteLine(result);
    }
}

