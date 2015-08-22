//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinToHexConverter
{
    static void Main()
    {
        string input = Console.ReadLine();        
        string result = string.Empty;

        for (int i = input.Length - 1; i >= 0; i -= 4)
        {
            string fourBits = string.Empty;
            for (int j = i; j >= i - 3; j--)
            {
                char currentDigit = j < 0 ? '0' : input[j];
                fourBits = currentDigit + fourBits;
            }

            switch (fourBits)
            {
                case "0000":
                    result = '0' + result;
                    break;
                case "0001":
                    result = '1' + result;
                    break;
                case "0010":
                    result = '2' + result;
                    break;
                case "0011":
                    result = '3' + result;
                    break;
                case "0100":
                    result = '4' + result;
                    break;
                case "0101":
                    result = '5' + result;
                    break;
                case "0110":
                    result = '6' + result;
                    break;
                case "0111":
                    result = '7' + result;
                    break;
                case "1000":
                    result = '8' + result;
                    break;
                case "1001":
                    result = '9' + result;
                    break;
                case "1010":
                    result = 'A' + result;
                    break;
                case "1011":
                    result = 'B' + result;
                    break;
                case "1100":
                    result = 'C' + result;
                    break;
                case "1101":
                    result = 'D' + result;
                    break;
                case "1110":
                    result = 'E' + result;
                    break;
                case "1111":
                    result = 'F' + result;
                    break;
                default:
                    break;
            }
        }

        Console.WriteLine(result);
    }
}

