//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) 
//operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Text;

class Encryptor
{
    static void Main()
    {
        Console.Write("Enter the text you want do encode: ");
        StringBuilder toEncode = new StringBuilder(Console.ReadLine());
        Console.Write("Enter the key: ");
        StringBuilder key = new StringBuilder(Console.ReadLine());
        StringBuilder encoded = new StringBuilder();
        int keyIndexCounter = 0;

        //Encode
        for (int i = 0; i < toEncode.Length; i++)
        {
            encoded.Append((char)(toEncode[i] ^ key[keyIndexCounter]));

            if (keyIndexCounter < key.Length - 1) keyIndexCounter++;
            else keyIndexCounter = 0;
        }

        Console.WriteLine("The encoded message is: {0}", encoded);

        //Decode
        StringBuilder decoded = new StringBuilder();
        keyIndexCounter = 0;

        for (int i = 0; i < encoded.Length; i++)
        {
            decoded.Append((char)(encoded[i] ^ key[keyIndexCounter]));

            if (keyIndexCounter < key.Length - 1) keyIndexCounter++;
            else keyIndexCounter = 0;
        }

        Console.WriteLine("The decoded message is: {0}", decoded);
    }
}

