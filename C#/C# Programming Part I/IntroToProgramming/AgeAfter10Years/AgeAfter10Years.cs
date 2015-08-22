//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("Please write your birthday (dd.mm.yyyy):");
        string input = Console.ReadLine();
        DateTime birthday = DateTime.Parse(input);
        int age = DateTime.Now.Year - birthday.Year;

        if (birthday.AddYears(age) > DateTime.Now)            //Checks if person has had birthday yet
        {
            age -= 1;
        }

        Console.WriteLine("You are " + age + " years old now and you'll be " + (age + 10) + " in ten years.");
    }
}

