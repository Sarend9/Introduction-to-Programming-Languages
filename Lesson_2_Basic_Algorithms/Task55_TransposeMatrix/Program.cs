// See https://aka.ms/new-console-template for more information

/* 
Задача 55: 
    Задайте двумерный массив. Напишите программу,
    которая заменяет строки на столбцы. В случае, если это
    невозможно, программа должна вывести сообщение для
    пользователя.

*/

using System;

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

    public static void TransposeMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        if (rows != cols)
        {
            Console.WriteLine("Матрица не квадратная и не может быть транспонирована.");
            return;
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = i + 1; j < cols; j++)
            {
                double temp = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = temp;
            }
        }
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
        }
        else
        {
            m = 5;
            n = 5;
            minLimitRandom = -10;
            maxLimitRandom = 10;

        }
        double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
        PrintMatrix(array);
        TransposeMatrix(array);
        Console.WriteLine("Перевернутая матрица: ");
        PrintMatrix(array);
    }
}