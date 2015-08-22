//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

class VariableTypes
{
    static void Main()
    {
        Console.WriteLine(@"Please choose a type:	
1 --> int	
2 --> double
3 --> string");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int intInput = int.Parse(Console.ReadLine());
                Console.WriteLine(intInput++);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleInput = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleInput + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string: ");
                string stringInput = Console.ReadLine();
                Console.WriteLine(stringInput + '*');
                break;
            default:
                Console.WriteLine("You didn't choose from the three available.");
                break;
        }
    }
}

