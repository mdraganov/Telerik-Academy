//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexToBinConverter
{
    static void Main()
    {
        string input = Console.ReadLine();
        string result = string.Empty;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            switch (input[i])
            {
                case '0':
                    result = "0000" + result;
                    break;
                case '1':
                    result = "0001" + result;
                    break;
                case '2':
                    result = "0010" + result;
                    break;
                case '3':
                    result = "0011" + result;
                    break;
                case '4':
                    result = "0100" + result;
                    break;
                case '5':
                    result = "0101" + result;
                    break;
                case '6':
                    result = "0110" + result;
                    break;
                case '7':
                    result = "0111" + result;
                    break;
                case '8':
                    result = "1000" + result;
                    break;
                case '9':
                    result = "1001" + result;
                    break;
                case 'A':
                    result = "1010" + result;
                    break;
                case 'B':
                    result = "1011" + result;
                    break;
                case 'C':
                    result = "1100" + result;
                    break;
                case 'D':
                    result = "1101" + result;
                    break;
                case 'E':
                    result = "1110" + result;
                    break;
                case 'F':
                    result = "1111" + result;
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine(result);
    }
}

