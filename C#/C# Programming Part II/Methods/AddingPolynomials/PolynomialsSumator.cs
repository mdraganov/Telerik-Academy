//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.
//Example:
//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

using System;

class PolynomialsSumator
{
    static void Main()
    {
        int[] firstPolynomial = { 5, 0, 2, 6 };
        int[] secondPolynomial = { 5, 2, 3 };
        Console.Write("The sum of the two polynomials is: ");
        SumPolynomials(firstPolynomial, secondPolynomial);
    }

    private static void SumPolynomials(int[] firstPoly, int[] secondPoly)
    {
        int[] polySum = new int[Math.Max(firstPoly.Length, secondPoly.Length)];

        for (int i = polySum.Length - 1; i >= 0; i--)
        {
            int firstPolyCoeff = i < firstPoly.Length ? firstPoly[i] : 0;
            int secondPolyCoeff = i < secondPoly.Length ? secondPoly[i] : 0;
            polySum[i] = firstPolyCoeff + secondPolyCoeff;

            if (i > 1)
            {
                Console.Write("{0}x^{1} + ", polySum[i], i);
            }
            else if (i == 1)
            {
                Console.Write("{0}x + ", polySum[i]);
            }
            else
            {
                Console.WriteLine(polySum[i]);
            }
        }
    }
}

