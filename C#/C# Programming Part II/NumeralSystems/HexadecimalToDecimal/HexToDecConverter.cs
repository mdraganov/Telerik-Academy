//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexToDecConverter
{
    static void Main()
    {
        string input = Console.ReadLine();
        long result = new long();
        int currentDigit = new int();
        int powersOf16 = 1;

        for (int i = input.Length - 1; i >= 0; i--)
        { 
            switch (input[i])
            {
                case 'A':
                    currentDigit = 10;
                    break;
                case 'B':
                    currentDigit = 11;
                    break;
                case 'C':
                    currentDigit = 12;
                    break;
                case 'D':
                    currentDigit = 13;
                    break;
                case 'E':
                    currentDigit = 14;
                    break;
                case 'F':
                    currentDigit = 15;
                    break;
                default:
                    currentDigit = input[i] - '0';
                    break;
            }

            result += currentDigit * powersOf16;
            powersOf16 *= 16;
        }

        Console.WriteLine(result);
    }
}

