//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.

using System;

class SortNumbers
{
    static void Main()
    {
        Console.Write("Enter A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter C: ");
        double c = double.Parse(Console.ReadLine());

        if (a < b)
        {
            if (b < c)
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
            else if (c < a)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
        else if (b < c)
        {
            if (c < a)
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        else
        {
            Console.WriteLine("{0} {1} {2}", a, b, c);
        }
    }
}

