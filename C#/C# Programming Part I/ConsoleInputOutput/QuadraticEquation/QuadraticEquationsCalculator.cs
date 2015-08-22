//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquationsCalculator
{
    static void Main()
    {
        Console.Write("Enter coefficient a: ");
        double a = double.Parse(Console.ReadLine());

        if     (a == 0)                                 //Coeff. a should not be zero.
        {
            do
            {
                Console.Write("Coefficient a should be different than 0, try again: ");
                a = double.Parse(Console.ReadLine());
            } while (a == 0);
        }
        Console.Write("Enter coefficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double c = double.Parse(Console.ReadLine());
        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("There are no real roots.");
        }
        else if (discriminant == 0)
        {
            double result = -b / (2 * a);
            Console.WriteLine("The equation has a double root: " + result);
        }
        else
        {
            double result1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double result2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("The roots are {0} and {1}", result1, result2);
        }

    }
}

