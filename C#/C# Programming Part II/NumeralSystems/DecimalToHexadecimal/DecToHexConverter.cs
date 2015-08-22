//Write a program to convert decimal numbers to their hexadecimal representation.

using System;

class DecToHexConverter
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string result = string.Empty;
        while (input != 0)
        {
            long reminder = input % 16;
            switch (reminder)
            {
                case 10:
                    result = 'A' + result;
                    break;       
                case 11:         
                    result = 'B' + result;
                    break;       
                case 12:         
                    result = 'C' + result;
                    break;       
                case 13:         
                    result = 'D' + result;
                    break;       
                case 14:         
                    result = 'E' + result;
                    break;       
                case 15:         
                    result = 'F' + result;
                    break;
                default:
                    result = reminder.ToString() + result;
                    break;
            }

            input /= 16;
        }

        Console.WriteLine(result);
    }
}

