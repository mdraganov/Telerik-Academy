//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigits
{
    static void Main()
    {
        Console.Write("Please enter a four-digit number: ");
        string input = Console.ReadLine();
        char a = input[0];
        char b = input[1];
        char c = input[2];
        char d = input[3];
        int intA = (int)char.GetNumericValue(a);
        int intB = (int)char.GetNumericValue(b);
        int intC = (int)char.GetNumericValue(c);
        int intD = (int)char.GetNumericValue(d);
        Console.WriteLine(intA + intB + intC + intD);
        Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
    }
}

