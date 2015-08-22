//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class SwitchBits
{
    static void Main()
    {
        Console.Write("Enter number: ");
        long number = long.Parse(Console.ReadLine());
        int a;
        int b;
        for (a = 3, b = 24; a <= 5; a++, b++)
        {
            long getBitA = (number >> a) & 1;                   //Gets the value of the bit at the current position
            long getBitB = (number >> b) & 1;

            if ((getBitA == 1) && (getBitB == 1))
            {
                number = number | (1 << b);                     //Switches the original bits with 1s and 0s depending on the case
                number = number | (1 << a);                     //In this case both are ones
            }
            else if ((getBitA == 1) && (getBitB == 0))
            {
                number = number | (1 << b);
                number = number & ~(1 << a);
            }
            else if ((getBitA == 0) && (getBitB == 1))
            {
                number = number & ~(1 << b);
                number = number | (1 << a);
            }
            else
            {
                number = number & ~(1 << b);
                number = number & ~(1 << a);
            }
        }
        Console.WriteLine(number);
    }
}

