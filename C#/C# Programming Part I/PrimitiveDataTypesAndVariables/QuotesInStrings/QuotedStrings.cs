//Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//Do the above in two different ways - with and without using quoted strings.
//Print the variables to ensure that their value was correctly defined.

using System;

class QuotedStrings
{
    static void Main()
    {
        string firstTry = "The \"use\" of quotations causes difficulties.";
        string secondTry = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(firstTry);
        Console.WriteLine(secondTry);
    }
}

