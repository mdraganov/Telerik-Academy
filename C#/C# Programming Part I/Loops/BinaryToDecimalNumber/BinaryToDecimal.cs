//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        double sum = new int();
        int position = input.Length - 1;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[position] == '1')
            {
                sum += Math.Pow(2, i);
            }
            position--;
        }
        Console.WriteLine(sum);
    }
}

