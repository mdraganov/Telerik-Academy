//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.

using System;
using System.Text;

class AboutStrings
{
    static void Main()
    {
        string definition = @"Strings are immutable sequences of characters (instances of the System.String Class in .NET Framework)
->Declared by the keyword string in C#
->Can be initialized by string literals
->Use Unicode to support multiple languages and alphabets
->Stored in the dynamic memory (managed heap)

System.String is a reference type
String objects are like arrays of characters (char[])
->Have fixed length (String.Length)
->Elements can be accessed directly by index (the index is in the range [0..Length-1])

Most important string processing members are:
->Length, this[], Compare(str1, str2), IndexOf(str), LastIndexOf(str), Substring(startIndex, length), Replace(oldStr, newStr), 
Remove(startIndex, length), ToLower(), ToUpper(), Trim()";

        Console.WriteLine(definition);        
    }               
}

