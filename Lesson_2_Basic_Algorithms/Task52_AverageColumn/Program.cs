// See https://aka.ms/new-console-template for more information

/* Задача 52:
  Задайте двумерный массив из целых чисел. 
  Найдите среднее арифметическое элементов в каждом столбце.

  Например, задан массив:
  ```
  1 4 7 2
  5 9 2 3
  8 4 2 4
  ```
  Средние арифметические для каждого столбца: 4.67, 5.67, 3.67, 3.
*/


using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] matrix = new int[n, m];
        int value = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = value;
                value += k;
            }
        }
        return matrix;
    }

    static void PrintListAvr(double[] list)
    {
        Console.WriteLine("The averages in columns are: ");
        for (int j = 0; j < list.Length; j++)
        {
            Console.Write($"{list[j]:F2}\t");
        }

    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        double[] array = new double[matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                array[i] += matrix[j, i];
            }
            array[i] /= matrix.GetLength(0);
        }
        return array;
    }

    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}