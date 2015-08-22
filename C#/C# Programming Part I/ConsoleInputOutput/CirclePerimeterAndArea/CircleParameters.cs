//Write a program that reads the radius r of a circle and prints its perimeter 
//and area formatted with 2 digits after the decimal point.

using System;

 class CircleParameters
 {
     static void Main()
     {
         Console.Write("Enter radius: ");
         double radius = double.Parse(Console.ReadLine());
         double perimeter = 2 * Math.PI * radius;
         double area = Math.PI * radius * radius;
         Console.WriteLine("Perimeter: {0,5:0.00}\nArea: {1,10:0.00}", perimeter, area);
     }
 }
