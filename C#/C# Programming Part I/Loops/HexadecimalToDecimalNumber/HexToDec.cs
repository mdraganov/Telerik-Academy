//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

class HexToDec
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] intArray = new int[input.Length];
        long decimalNumber = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char inputChar = input[i];
            switch (inputChar)
            {                
                case 'A':
                    intArray[i] = 10;
                    break;
                case 'B':
                    intArray[i] = 11;
                    break;
                case 'C':
                    intArray[i] = 12;
                    break;
                case 'D':
                    intArray[i] = 13;
                    break;
                case 'E':
                    intArray[i] = 14;
                    break;
                case 'F':
                    intArray[i] = 15;
                    break;
                default:
                    intArray[i] = int.Parse(input[i].ToString());
                    break;
            }
        }

        for (int i = 0; i < input.Length; i++)
        {
            int power = input.Length - 1 - i;
            decimalNumber += (long)(intArray[i] * Math.Pow(16, power));
        }

        Console.WriteLine(decimalNumber);
    }
}

