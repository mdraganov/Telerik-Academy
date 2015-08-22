//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;

class TriangleSurfaceCalculator
{
    static void Main()
    {
        Console.WriteLine("Choose how to calculate the surface: ");
        Console.WriteLine("1. From a side and height.");
        Console.WriteLine("2. From three sides.");
        Console.WriteLine("3. From two sides and ana angle between them.");
        Console.Write("Choice: ");
        int choice = int.Parse(Console.ReadLine());

        while (choice != 1 && choice != 2 && choice != 3)
        {
            Console.Write("Wrong choice, try again: ");
            choice = int.Parse(Console.ReadLine());
        }

        if (choice == 1)
        {
            Console.Write("Enter the side: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            double heaightA = double.Parse(Console.ReadLine());

            Console.WriteLine(SurfaceFromSideAndHeight(sideA, heaightA));
        }
        else if (choice == 2)
        {
            Console.Write("Enter side a: ");
            int sideA = int.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            int sideB = int.Parse(Console.ReadLine());
            Console.Write("Enter side c: ");
            int sideC = int.Parse(Console.ReadLine());

            Console.WriteLine(SurfaceFromThreeSides(sideA, sideB, sideC));
        }
        else if (choice == 3)
        {
            Console.Write("Enter side a: ");
            double sideA = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            double sideB = double.Parse(Console.ReadLine());
            Console.Write("Enter the angle betweent them: ");
            double angle = double.Parse(Console.ReadLine());

            Console.WriteLine(SurfaceFromSidesAndAngle(sideA, sideB, angle));
        }
    }

    static double SurfaceFromSideAndHeight(double side, double height)
    {
        double surface = (side * height) / 2;
        return surface;
    }

    static double SurfaceFromThreeSides(double a, double b, double c)
    {
        double halfPerimeter = (a + b + c) / 2;
        double surface = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        return surface;
    }

    static double SurfaceFromSidesAndAngle(double a, double b, double angle)
    {
        double surface = (a * b * Math.Sin(angle)) / 2;
        return surface;
    }
}

