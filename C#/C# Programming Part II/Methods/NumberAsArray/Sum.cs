//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;

class Sum
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        char[] firstNum = Console.ReadLine().ToCharArray();
        Console.Write("Enter a second number: ");
        char[] secondNum = Console.ReadLine().ToCharArray();

        Array.Reverse(firstNum);
        Array.Reverse(secondNum);

        List<int> result = new List<int>();

        bool residual = false;
        for (int i = 0; i < Math.Max(firstNum.Length, secondNum.Length) + 1; i++)
        {
            int firstArrayDigit = i < firstNum.Length ? firstNum[i] - '0' : 0;
            int secondArrayDigit = i < secondNum.Length ? secondNum[i] - '0' : 0;
            int digitsSum = firstArrayDigit + secondArrayDigit;
            bool isThereResidual = false;

            if (digitsSum > 9)
            {
                digitsSum %= 10;
                isThereResidual = true;
            }

            if (residual)
            {
                result.Add(digitsSum + 1);
                residual = false;
            }
            
            else result.Add(digitsSum);

            if (isThereResidual) residual = true;
        }

        result.Reverse();

        if (result[0] == 0) result.Remove(0);

        for (int i = 0; i < result.Count; i++)
        {
            Console.Write(result[i]);
        }
    }
}

