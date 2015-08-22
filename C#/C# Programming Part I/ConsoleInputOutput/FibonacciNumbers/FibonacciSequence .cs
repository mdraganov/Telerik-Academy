//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

using System;

 class FibonacciSequence 
 {
     static void Main()
     {
         Console.Write("Enter n: ");
         int n = int.Parse(Console.ReadLine());
         int number = 1;
         int oldNumber = 2;

         for (int i = 0; i < n; i++)
         {
             oldNumber = number - oldNumber;
             number = number + oldNumber;
             Console.Write("{0}, ", number);
         }
     }
 }

