//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.

using System;

class SwitchBitsAdvanced
{
    static void Main()
    {
        Console.Write("Enter number: ");
        long number = long.Parse(Console.ReadLine());
        Console.Write("Enter p value: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter q value: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter k value: ");
        int k = int.Parse(Console.ReadLine());

        if ((p + k) > Convert.ToString(number, 2).Length || (q + k) > Convert.ToString(number, 2).Length || p < 0 || q < 0)
        {
            Console.WriteLine("out of range");
        }
        else if ((Math.Min(p, q) + k) > Math.Max(p, q))
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            int a;
            int b;
            for (a = p, b = q; a <= (p + k - 1); a++, b++)
            {
                long getBitA = (number >> a) & 1;               //Gets the value of the bit at the current position
                long getBitB = (number >> b) & 1;

                if ((getBitA == 1) && (getBitB == 1))
                {
                    number = number | (1 << b);                 //Switches the original bits with 1s and 0s depending on the case
                    number = number | (1 << a);                 //In this case both are ones
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
}

