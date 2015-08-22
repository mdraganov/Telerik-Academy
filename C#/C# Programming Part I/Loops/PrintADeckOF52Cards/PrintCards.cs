//Write a program that generates and prints all possible cards from a standard deck of 52 cards 
//(without the jokers). The cards should be printed using the classical notation 
//(like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
//Use 2 nested for-loops and a switch-case statement.

using System;
using System.Text;

class PrintCards
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        for (int i = 2; i <= 14; i++)
        {
            if (i < 11)
            {                
                Console.WriteLine("{0,2}\u2663, {0,2}\u2660, {0,2}\u2665, {0,2}\u2666", i);
            }
            
            switch (i)
            {
                case 11:
                    Console.WriteLine("{0,2}\u2663, {0,2}\u2660, {0,2}\u2665, {0,2}\u2666", "J");
                    break;
                case 12:
                    Console.WriteLine("{0,2}\u2663, {0,2}\u2660, {0,2}\u2665, {0,2}\u2666", "Q");
                    break;
                case 13:
                    Console.WriteLine("{0,2}\u2663, {0,2}\u2660, {0,2}\u2665, {0,2}\u2666", "K");
                    break;
                case 14:
                    Console.WriteLine("{0,2}\u2663, {0,2}\u2660, {0,2}\u2665, {0,2}\u2666", "A");
                    break;
                default:
                    break;
            }
        }
    }
}

