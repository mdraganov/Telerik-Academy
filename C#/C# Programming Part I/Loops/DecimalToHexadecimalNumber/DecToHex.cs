//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecToHex
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string result = string.Empty;
        while (input != 0)
        {
            int reminder = input % 16;
            switch (reminder)
            {
                case 10:
                    result += 'A';
                    break;
                case 11:
                    result += 'B';
                    break;
                case 12:
                    result += 'C';
                    break;
                case 13:
                    result += 'D';
                    break;
                case 14:
                    result += 'E';
                    break;
                case 15:
                    result += 'F';
                    break;
                default:
                    result += reminder.ToString();
                    break;
            }

            input /= 16;
        }

        char[] charArray = result.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(new string(charArray));
    }
}

