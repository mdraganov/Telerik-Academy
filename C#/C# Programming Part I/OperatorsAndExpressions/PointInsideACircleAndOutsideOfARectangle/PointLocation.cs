//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5)
//and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointLocation
{
    static void Main()
    {
        Console.Write("Enter x coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y coordinate: ");
        double y = double.Parse(Console.ReadLine());
        bool checkCircle = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5;
        bool checkRectangle = (x >= 0 && x <= 5) && (y >= -1 && y <= 1);

        if ((checkCircle == true) && (checkRectangle == false))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}