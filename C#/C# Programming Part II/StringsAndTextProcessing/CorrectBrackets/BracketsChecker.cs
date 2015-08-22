//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

using System;

class BracketsChecker
{
    static void Main()
    {
        Console.Write("Enter a math expression:  ");
        string input = Console.ReadLine();
        int openingBrackets = 0;
        int closingBrackets = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                openingBrackets++;
            }
            else if (input[i] == ')')
            {
                closingBrackets++;
                if (closingBrackets > openingBrackets)
                {
                    Console.WriteLine("Brackets are not put correctly.");           
                    break;
                }
            }

            if (i == input.Length - 1 && closingBrackets == openingBrackets) Console.WriteLine("Brackets are correct.");
            else if (i == input.Length - 1) Console.WriteLine("Brackets are not put correctly.");
        }
    }
}

