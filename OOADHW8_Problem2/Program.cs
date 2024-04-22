using System;

class MatrixTranspose
{
    const int BASE_CASE_THRESHOLD = 32;

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    private static void Transpose(int[,] matrix, int rowStart, int colStart, int size, int N)
    {
        if (size <= 3)
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < i; j++)
                    Swap(ref matrix[rowStart + i, colStart + j], ref matrix[rowStart + j, colStart + i]);
        }
        else
        {
            int k = size / 2;

            // Transpose the top-left quadrant
            Transpose(matrix, rowStart, colStart, k, N);
            // Transpose the top-right quadrant
            Transpose(matrix, rowStart, colStart + k, k, N);
            // Transpose the bottom-left quadrant
            Transpose(matrix, rowStart + k, colStart, k, N);
            // Transpose the bottom-right quadrant
            Transpose(matrix, rowStart + k, colStart + k, k, N);

            // Swap the elements of the top-right and bottom-left quadrants
            for (int i = 0; i < k; i++)
                for (int j = 0; j < k; j++)
                    Swap(ref matrix[rowStart + i, colStart + j + k], ref matrix[rowStart + i + k, colStart + j]);

            // Handle the case when matrix size is odd
            if ((size & 1) == 1)
                for (int i = 0; i < size - 1; i++)
                    Swap(ref matrix[rowStart + i, colStart + size - 1], ref matrix[rowStart + size - 1, colStart + i]);
        }
    }

    public static void Transpose(int[,] matrix)
    {
        int N = matrix.GetLength(0);
        Transpose(matrix, 0, 0, N, N);
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        int[,] matrix = {
            { 1, 2, 3, 5,6 },
            {5, 6, 7, 5, 6},
            {9, 10, 12, 5, 6},
            {13, 14, 16, 5, 6},
            {13, 14, 16, 5, 6},
        };

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        Transpose(matrix);

        Console.WriteLine("Transposed Matrix:");
        PrintMatrix(matrix);
    }
}
