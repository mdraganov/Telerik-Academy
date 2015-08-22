//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        int result = (number / 100) % 10;
        Console.WriteLine(result == 7);
    }
}

