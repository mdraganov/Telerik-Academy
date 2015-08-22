using System;

class MatrixFiller
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int height = matrix.GetLength(0);
        int currentCol = 0;
        int revCurrentCol = n - 1;
        int currentRow = 0;
        int revCurrentRow = n - 1;
        int counter = 1;
        bool keepWorking = true;

        while (keepWorking)         //Fills the matrix by sequencing each direction until its filled.
	    {            
            for (int row = currentRow; row < height; row++)
            {
                matrix[row, currentCol] = counter;
                counter++;
            }
            currentCol++;

            for (int col = currentCol; col < height; col++)
			{
			    matrix[revCurrentRow, col] = counter;
                counter++;
			}
            revCurrentRow--;

            for (int row = height - 2; row >= currentRow; row--)
			{
			    matrix[row, revCurrentCol] = counter;
                counter++;
			}
            revCurrentCol--;

            for (int col = height - 2; col > currentRow; col--)
			{
			    matrix[currentRow, col] = counter;
                counter++;
			}
            currentRow++;
            height--;

            if (currentRow > height)
	        {
                keepWorking = false;
	        }
        }
        
        for (int row = 0; row < matrix.GetLength(0); row++)         //Prints the matrix
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

