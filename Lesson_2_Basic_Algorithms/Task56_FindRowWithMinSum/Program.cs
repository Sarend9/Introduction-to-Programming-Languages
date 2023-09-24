/* 
Задача 56:
    Задайте прямоугольный двумерный массив.
    Напишите программу, которая будет находить 
    строку с наименьшей суммой элементов.
*/

using System;

public class Answer
{

    public static void PrintMatrix(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write($"{matrix[i, j],10}");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
    {
        Random rand = new Random();
        int[,] array = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                int randomValue = rand.Next(minLimitRandom, maxLimitRandom + 1);
                array[i, j] = randomValue;
            }
        }
        return array;
    }

    public static void FindRowWithMinSum(int[,] matrix)
    {
        Console.WriteLine("Удаление строки и столбца с минимальным элементом:");
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        int minSumRowsIndex = 0;
        int minSumRows = int.MaxValue;

        for (int i = 0; i < numRows; i++)
        {
            int sumRows = 0;

            for (int j = 0; j < numCols; j++)
            {
                sumRows += matrix[i, j];
            }

            Console.WriteLine($"* Сумма {i + 1}-ой строки: {sumRows,3}");

            if (sumRows < minSumRows)
            {
                minSumRows = sumRows;
                minSumRowsIndex = i;
            }
        }
        Console.WriteLine($"Номер строки с наименьшей суммой: {minSumRowsIndex + 1}\n");
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
        int[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
        PrintMatrix(array);
        Console.WriteLine();
        FindRowWithMinSum(array);
    }
}





































