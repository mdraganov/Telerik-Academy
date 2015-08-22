using System;

class NumberFormatting
{
    static void Main()
    {
        Console.Write("Enter integer a: ");
        int a = int.Parse(Console.ReadLine());
        string binaryA = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.Write("Enter floating-point b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter floating-point c: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0,-5:X}|{1}|{2,7:0.00}|{3,-7:0.000}|", a, binaryA, b, c);
    }
}

