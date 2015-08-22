//Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

using System;

class LargestArea
{
    static void Main()
    {
        int[,] inputArray = {{1,3,2,2,2,4},
                             {3,3,3,2,4,4},
                             {4,3,1,2,3,3},
                             {4,3,1,3,3,1},
                             {4,3,3,3,1,1}};
        
        bool[,] checkedCells = new bool[inputArray.GetLength(0), inputArray.GetLength(1)];
        int maxCount = 1;

        for (int row = 0; row < inputArray.GetLength(0); row++)
        {
            for (int col = 0; col < inputArray.GetLength(1); col++)
            {
                if (!checkedCells[row, col])
                {
                    int currentCount = FindNeighbours(inputArray, row, col, checkedCells);
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
            }
        }

        Console.WriteLine(maxCount);        
    }

    static int FindNeighbours(int[,] matrix, int currentRow, int currentCol, bool[,]check)
    {
        int count = 1;        
        check[currentRow, currentCol] = true;

        if (currentCol + 1 < matrix.GetLength(1))
        {
            if (matrix[currentRow, currentCol] == matrix[currentRow, currentCol + 1] && !check[currentRow, currentCol + 1])
            {
                count += FindNeighbours(matrix, currentRow, currentCol + 1, check);
            }
        }
        if (currentRow + 1 < matrix.GetLength(0))
        {            
            if (matrix[currentRow, currentCol] == matrix[currentRow + 1, currentCol] && !check[currentRow + 1, currentCol])
            {
                count += FindNeighbours(matrix, currentRow + 1, currentCol, check);
            }
        }
        if (currentCol - 1 >= 0)
        {            
            if (matrix[currentRow, currentCol] == matrix[currentRow, currentCol - 1] && !check[currentRow, currentCol - 1])
            {
                count += FindNeighbours(matrix, currentRow, currentCol - 1, check);
            }
        }
        if (currentRow - 1 >= 0)
        {            
            if (matrix[currentRow, currentCol] == matrix[currentRow - 1, currentCol] && !check[currentRow - 1, currentCol])
            {
                count += FindNeighbours(matrix, currentRow - 1, currentCol, check);
            }
        }

        return count;
    }
}

