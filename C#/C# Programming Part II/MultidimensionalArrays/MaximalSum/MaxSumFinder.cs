//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaxSumFinder
{
    static void Main()
    {
        Console.Write("Enter N (at least 3): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M (at least 3): ");
        int m = int.Parse(Console.ReadLine());
        int maxSum = 0;
        int maxSumRow = 0;
        int maxSumCol = 0;
        int[,] matrix = new int[n, m];

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Enter element {0},{1} : ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                                + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                                + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
               
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumRow = row;
                    maxSumCol = col;
                }
            }
        }
        Console.WriteLine("Max sum : {0}",maxSum);
        Console.WriteLine("{0,3}{1,3}{2,3}", matrix[maxSumRow, maxSumCol], matrix[maxSumRow, maxSumCol + 1], matrix[maxSumRow, maxSumCol + 2]);
        Console.WriteLine("{0,3}{1,3}{2,3}", matrix[maxSumRow + 1, maxSumCol], matrix[maxSumRow + 1, maxSumCol + 1], matrix[maxSumRow + 1, maxSumCol + 2]);
        Console.WriteLine("{0,3}{1,3}{2,3}", matrix[maxSumRow + 2, maxSumCol], matrix[maxSumRow + 2, maxSumCol + 1], matrix[maxSumRow + 2, maxSumCol + 2]);
    }

}

