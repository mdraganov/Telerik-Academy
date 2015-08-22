//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class RectangleParameters
{
    static void Main()
    {
        Console.Write("Please enter the rectangle's widht: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Please enter the rectangle's height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = width * 2 + height * 2;
        double area = width * height;
        Console.WriteLine("The perimeter ie {0} and the area is {1}.", perimeter, area);
    }
}

