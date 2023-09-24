// See https://aka.ms/new-console-template for more information
/*
Задача 54:
    Задайте двумерный массив. Напишите программу, которая
    упорядочит по убыванию элементы каждой строки двумерного массива.
 */

public class Answer
{
    public static void PrintMatrix(double[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write($"{matrix[i, j],10:F2}");
            }
            Console.WriteLine();
        }
    }

    public static double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
    {
        Random rand = new Random();
        double[,] array = new double[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                double randomValue = rand.NextDouble() * (maxLimitRandom - minLimitRandom) + minLimitRandom;
                array[i, j] = Math.Round(randomValue, 1);
            }
        }
        return array;
    }

    public static void SortRowsDescending(double[,] matrix)
    {
        int rowCount = matrix.GetLength(0);
        int colCount = matrix.GetLength(1);

        for (int i = 0; i < rowCount; i++)
        {
            //Сортировка пузырьком для текущей строки (i-й строки)
            for (int j = 0; j < colCount - 1; j++)
            {
                for (int k = 0; k < colCount - j - 1; k++)
                {
                    if (matrix[i, k] < matrix[i, k + 1])
                    {
                        (matrix[i, k], matrix[i, k + 1]) = (matrix[i, k + 1], matrix[i, k]);
                    }
                }
            }
        }
        Console.WriteLine("Упорядоченная матрица:");
        PrintMatrix(matrix);
    }

    static public void Main(string[] args)
    {
        Console.Clear();

        int m, n, minLimitRandom, maxLimitRandom;

        if (args.Length >= 4)
        {
            m = int.Parse(args[0]);
            n = int.Parse(args[1]);
            minLimitRandom = int.Parse(args[2]);
            maxLimitRandom = int.Parse(args[3]);

            double[,] array =
                CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
            PrintMatrix(array);
            SortRowsDescending(array);
        }
        else
        {
            m = 3;
            n = 4;
            minLimitRandom = -10;
            maxLimitRandom = 10;

            double[,] array =
                CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
            PrintMatrix(array);
            SortRowsDescending(array);
        }
    }
}
