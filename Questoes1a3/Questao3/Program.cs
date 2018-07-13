namespace Questao3
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 } };            
            int[,] invertedMatrix = InvertMatrix(matrix);
            PrintMatrix(matrix, invertedMatrix);

            Console.ReadKey();
        }

        public static int[,] InvertMatrix(int[,] matrix)
        {
            int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    newMatrix[i, j] = matrix[j, i];
                }
            }

            return newMatrix;
        }

        public static void PrintMatrix(int[,] matrix, int[,] invertedMatrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.Write($"\n");
            }

            Console.Write($"\n======================\n");

            for (int i = 0; i < invertedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < invertedMatrix.GetLength(1); j++)
                {
                    Console.Write($"{invertedMatrix[i, j]}\t");
                }
                Console.Write($"\n");
            }
        }
    }
}
