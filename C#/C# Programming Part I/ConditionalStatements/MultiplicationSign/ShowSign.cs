//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

class ShowSign
{
    static void Main()
    {
        Console.Write("Enter A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter C: ");
        double c = double.Parse(Console.ReadLine());

        if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0 && c > 0) || (a > 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c < 0))
        {
            Console.WriteLine('+');           //all the possibilities for the product to be positive are exausted
        }                                     //so if this is not true it's either 0 or negative
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine('-');
        }

    }
}

