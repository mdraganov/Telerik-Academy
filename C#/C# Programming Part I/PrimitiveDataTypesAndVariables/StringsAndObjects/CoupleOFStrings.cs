﻿//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).

using System;

class CoupleOFStrings
{
    static void Main()
    {
        string someString = "Hello";
        string someOtherString = "World";
        object someObject = someString + " " + someOtherString;
        string anotherString = (string)someObject;
    }
}

