using System;

class MatrixFiller
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        for (int row = 0; row < matrix.GetLength(0); row++)                 //Fills the matrix by counting the number of elements 
        {                                                                   //before the current element.
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int counter = 0;
                int addition = col + 1;
                for (int i = row; i < matrix.GetLength(0) - 1; i++)
                {
                    counter += addition;
                    addition++;
                    if (addition > matrix.GetLength(1))
                    {
                        addition--;
                    }
                }

                addition = col + 1;
                for (int i = row; i >= 0; i--)
                {
                    counter += addition;
                    addition--;
                    if (addition == 0)
                    {
                        break;
                    }
                }
                                
                matrix[row, col] = counter;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)         //Prints the matrix
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}



