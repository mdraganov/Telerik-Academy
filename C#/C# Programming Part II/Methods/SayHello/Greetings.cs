//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.

using System;


class Greetings
{
    static void Main()
    {
        Greeting();
    }

    static void Greeting()
    {
        Console.Write("What's your name? ");
        string input = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", input);
    }
}

