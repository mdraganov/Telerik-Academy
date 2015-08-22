//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye.
//Use try-catch-finally block.

using System;

class SquareRoot
{
    static void Main()
    {

        try
        {
            int someInt = int.Parse(Console.ReadLine());
            Console.WriteLine("The square root of that is: {0}", Math.Sqrt(someInt));
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number.");
        }
        finally 
        {
            Console.WriteLine("Good bye.");
        }
    }
}

