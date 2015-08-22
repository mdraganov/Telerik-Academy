//Write a program that finds the longest sequence of equal strings in the matrix.
//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.

using System;

class LongestSequence
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter M: ");
        int m = int.Parse(Console.ReadLine());
        int maxSequence = 1;
        int sequenceStartRow = 0;
        int sequenceStartCol = 0;
        string[,] matrix = new string[n, m];    //{ 
                                                //{"ha","fifi","ho","hi"}, 
                                                //{"fo","ha","hi","xx"}, 
                                                //{"xxx","ho","ha","xa"}                           
                                                //};
        for (int row = 0; row < n; row++)                                   
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write("Enter element {0},{1} : ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }                                                                   

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int currentSequence = 1;
                for (int i = col; i < matrix.GetLength(1) - 1; i++)  //Checks lines.
                {
                    if (matrix[row, i] == matrix[row, i + 1])
                    {
                        currentSequence++;
                        if (currentSequence > maxSequence)
                        {
                            maxSequence = currentSequence;
                            sequenceStartRow = row;
                            sequenceStartCol = col;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                currentSequence = 1;
                for (int i = row; i < matrix.GetLength(0) - 1; i++)  //Checks rows.
                {
                    if (matrix[i, col] == matrix[i + 1, col])
                    {
                        currentSequence++;
                        if (currentSequence > maxSequence)
                        {
                            maxSequence = currentSequence;
                            sequenceStartRow = row;
                            sequenceStartCol = col;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                currentSequence = 1;
                for (int i = 0; i < matrix.GetLength(1) - 1 - col && i < matrix.GetLength(0) - 1 - row; i++)  //Checks first diagonal.
                {
                    if (matrix[row + i, col + i] == matrix[row + i + 1, col + i + 1])
                    {
                        currentSequence++;
                        if (currentSequence > maxSequence)
                        {
                            maxSequence = currentSequence;
                            sequenceStartRow = row;
                            sequenceStartCol = col;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                currentSequence = 1;
                for (int i = 0; i < matrix.GetLength(1) - 1 - col && i < matrix.GetLength(0) - 1 - row && col - i - 1 > 0; i++)  //Checks second diagonal.
                {
                    if (matrix[row + i, col - i] == matrix[row + i + 1, col - i - 1])
                    {
                        currentSequence++;
                        if (currentSequence > maxSequence)
                        {
                            maxSequence = currentSequence;
                            sequenceStartRow = row;
                            sequenceStartCol = col;
                        }
                    }
                    else
                    {                        
                        break;
                    }
                }
            }
        }

        for (int i = 0; i < maxSequence; i++)
        {            
            Console.Write("{0} ", matrix[sequenceStartRow, sequenceStartCol]);
        }
    }
}

