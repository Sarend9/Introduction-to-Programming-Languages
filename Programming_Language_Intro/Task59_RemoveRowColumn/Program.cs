// See https://aka.ms/new-console-template for more information

/* 
Задача 59: 
    Задайте двумерный массив из целых чисел.
    Напишите программу, которая удалит строку и столбец, на
    пересечении которых расположен наименьший элемент
    массива.
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

    public static int[,] RemoveRowAndColumnWithMinElement(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        int minElement;
        int minRow;
        int minCol;

        FindMinElementAndCoordinates(matrix, out minElement, out minRow, out minCol);
        Console.WriteLine($"minElement[{minRow},{minCol}]: {minElement}");

        int[,] newMatrix = RemoveRowAndColumn(matrix, minRow, minCol);
        return newMatrix;
    }

    private static void FindMinElementAndCoordinates(int[,] matrix, out int minElement, out int minRow, out int minCol)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        minElement = matrix[0, 0];
        minRow = 0;
        minCol = 0;

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                if (matrix[i, j] < minElement)
                {
                    minElement = matrix[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }
    }

    private static int[,] RemoveRowAndColumn(int[,] matrix, int rowToRemove, int colToRemove)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        int[,] newMatrix = new int[numRows - 1, numCols - 1];

        for (int i = 0, newRow = 0; i < numRows; i++)
        {
            if (i == rowToRemove)
                continue;

            for (int j = 0, newCol = 0; j < numCols; j++)
            {
                if (j == colToRemove)
                    continue;

                newMatrix[newRow, newCol] = matrix[i, j];
                newCol++;
            }

            newRow++;
        }

        return newMatrix;
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
        Console.WriteLine("Удаление строки и столбца с минимальным элементом:");
        PrintMatrix(RemoveRowAndColumnWithMinElement(array));
    }
}





































