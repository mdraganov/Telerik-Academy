//You are given an array of strings. Write a method that sorts 
//the array by the length of its elements (the number of characters composing them).

using System;

class StringSorter
{
    static void Main()
    {
        Console.Write("Please enter a few words separated by space: ");
        string[] stringArray = Console.ReadLine().Split();

        Array.Sort(stringArray, (x, y) => x.Length.CompareTo(y.Length)); ;

        Console.WriteLine(string.Join(" ", stringArray));
    }
}

