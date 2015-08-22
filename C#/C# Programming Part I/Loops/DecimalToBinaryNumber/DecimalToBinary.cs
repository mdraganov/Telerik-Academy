//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToBinary
{
    static void Main()
    {
        int someInt = int.Parse(Console.ReadLine());
        string result = string.Empty;
        do
        {
            if (someInt % 2 != 0)
            {
                result = 1 + result;
            }
            else if (someInt % 2 == 0)
            {
                result = 0 + result;
            }
            someInt /= 2;
        } while (someInt != 0);
        Console.WriteLine(result);
    }
}

