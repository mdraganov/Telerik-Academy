//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class ConvertNumbersToWords             // a little longer than it has to be but at least it works
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a 3 digit number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (input.Length == 1)
            {
                string theNumber = "";
                if (number == 0)
                {
                    theNumber = "Zero";
                }
                else if (number == 1)
                {
                    theNumber = "One";
                }
                else if (number == 2)
                {
                    theNumber = "Two";
                }
                else if (number == 3)
                {
                    theNumber = "Three";
                }
                else if (number == 4)
                {
                    theNumber = "Four";
                }
                else if (number == 5)
                {
                    theNumber = "Five";
                }
                else if (number == 6)
                {
                    theNumber = "Six";
                }
                else if (number == 7)
                {
                    theNumber = "Seven";
                }
                else if (number == 8)
                {
                    theNumber = "Eight";
                }
                else if (number == 9)
                {
                    theNumber = "Nine";
                }
                Console.WriteLine(theNumber);
            }
            else if (input.Length == 2)
            {
                int digit1 = Convert.ToInt32(input[0].ToString());
                int digit2 = Convert.ToInt32(input[1].ToString());

                if (digit1 == 1)
                {
                    switch (number)
                    {
                        case 10:
                            Console.WriteLine("Ten");
                            break;
                        case 11:
                            Console.WriteLine("Eleven");
                            break;
                        case 12:
                            Console.WriteLine("Twelve");
                            break;
                        case 13:
                            Console.WriteLine("Thirteen");
                            break;
                        case 14:
                            Console.WriteLine("Fourteen");
                            break;
                        case 15:
                            Console.WriteLine("Fifteen");
                            break;
                        case 16:
                            Console.WriteLine("Sixteen");
                            break;
                        case 17:
                            Console.WriteLine("Seventeen");
                            break;
                        case 18:
                            Console.WriteLine("Eighteen");
                            break;
                        case 19:
                            Console.WriteLine("Nineteen");
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    string firstDigit = "";
                    string secondDigit = "";
                    if (digit1 == 2)
                    {
                        firstDigit = "Twenty";
                    }
                    else if (digit1 == 3)
                    {
                        firstDigit = "Thirty";
                    }
                    else if (digit1 == 4)
                    {
                        firstDigit = "Fourty";
                    }
                    else if (digit1 == 5)
                    {
                        firstDigit = "Fifty";
                    }
                    else if (digit1 == 6)
                    {
                        firstDigit = "Sixty";
                    }
                    else if (digit1 == 7)
                    {
                        firstDigit = "Seventy";
                    }
                    else if (digit1 == 8)
                    {
                        firstDigit = "Eighty";
                    }
                    else if (digit1 == 9)
                    {
                        firstDigit = "Ninety";
                    }
                    if (digit2 == 1)
                    {
                        secondDigit = "one";
                    }
                    else if (digit2 == 2)
                    {
                        secondDigit = "two";
                    }
                    else if (digit2 == 3)
                    {
                        secondDigit = "three";
                    }
                    else if (digit2 == 4)
                    {
                        secondDigit = "four";
                    }
                    else if (digit2 == 5)
                    {
                        secondDigit = "five";
                    }
                    else if (digit2 == 6)
                    {
                        secondDigit = "six";
                    }
                    else if (digit2 == 7)
                    {
                        secondDigit = "seven";
                    }
                    else if (digit2 == 8)
                    {
                        secondDigit = "eight";
                    }
                    else if (digit2 == 9)
                    {
                        secondDigit = "nine";
                    }
                    if (digit2 == 0)
                    {
                        Console.WriteLine(firstDigit);
                    }
                    else
                    {
                        Console.WriteLine(firstDigit + " " + secondDigit);
                    }
                }
            }
            else
            {
                int digit1 = Convert.ToInt32(input[0].ToString());
                int digit2 = Convert.ToInt32(input[1].ToString());
                int digit3 = Convert.ToInt32(input[2].ToString());
                string firstDigit = "";
                string secondDigit = "";
                string thirdDigit = "";

                if (digit1 == 1)
                {
                    firstDigit = "One hundred";
                }
                else if (digit1 == 2)
                {
                    firstDigit = "Two hundred";
                }
                else if (digit1 == 3)
                {
                    firstDigit = "Three hundred";
                }
                else if (digit1 == 4)
                {
                    firstDigit = "Four hundred";
                }
                else if (digit1 == 5)
                {
                    firstDigit = "Five hundred";
                }
                else if (digit1 == 6)
                {
                    firstDigit = "Six hundred";
                }
                else if (digit1 == 7)
                {
                    firstDigit = "Seven hundred";
                }
                else if (digit1 == 8)
                {
                    firstDigit = "Eight hundred";
                }
                else if (digit1 == 9)
                {
                    firstDigit = "Nine hundred";
                }
                if (digit2 == 2)
                {
                    secondDigit = "Twenty";
                }
                else if (digit2 == 3)
                {
                    secondDigit = "Thirty";
                }
                else if (digit2 == 4)
                {
                    secondDigit = "Fourty";
                }
                else if (digit2 == 5)
                {
                    secondDigit = "Fifty";
                }
                else if (digit2 == 6)
                {
                    secondDigit = "Sixty";
                }
                else if (digit2 == 7)
                {
                    secondDigit = "Seveny";
                }
                else if (digit2 == 8)
                {
                    secondDigit = "Eighty";
                }
                else if (digit2 == 9)
                {
                    secondDigit = "Ninety";
                }
                if (digit3 == 1)
                {
                    thirdDigit = "one";
                }
                else if (digit3 == 2)
                {
                    thirdDigit = "two";
                }
                else if (digit3 == 3)
                {
                    thirdDigit = "three";
                }
                else if (digit3 == 4)
                {
                    thirdDigit = "four";
                }
                else if (digit3 == 5)
                {
                    thirdDigit = "five";
                }
                else if (digit3 == 6)
                {
                    thirdDigit = "six";
                }
                else if (digit3 == 7)
                {
                    thirdDigit = "seven";
                }
                else if (digit3 == 8)
                {
                    thirdDigit = "eight";
                }
                else if (digit3 == 9)
                {
                    thirdDigit = "nine";
                }
                if (digit2 == 0 && digit3 == 0)
                {
                    Console.WriteLine(firstDigit);
                }
                else if (digit2 == 1)
                {
                    switch (digit3)
                    {
                        case 0:
                            Console.WriteLine(firstDigit + " and ten");
                            break;
                        case 1:
                            Console.WriteLine(firstDigit + " and eleven");
                            break;
                        case 2:
                            Console.WriteLine(firstDigit + " and twelve");
                            break;
                        case 3:
                            Console.WriteLine(firstDigit + " and thirteen");
                            break;
                        case 4:
                            Console.WriteLine(firstDigit + " and fourteen");
                            break;
                        case 5:
                            Console.WriteLine(firstDigit + " and fifteen");
                            break;
                        case 6:
                            Console.WriteLine(firstDigit + " and sixteen");
                            break;
                        case 7:
                            Console.WriteLine(firstDigit + " and seventeen");
                            break;
                        case 8:
                            Console.WriteLine(firstDigit + " and eighteen");
                            break;
                        case 9:
                            Console.WriteLine(firstDigit + " and nineteen");
                            break;
                        default:
                            break;
                    }
                }
                else if (digit3 == 0)
                {
                    Console.WriteLine(firstDigit + " and " + secondDigit.ToLower());
                }
                else if (digit2 == 0)
                {
                    Console.WriteLine(firstDigit + " and " + thirdDigit);
                }
                else
                {
                    Console.WriteLine(firstDigit + " and " + secondDigit.ToLower() + " " + thirdDigit);
                }
            }
        }
    }
}