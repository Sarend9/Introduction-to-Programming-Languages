/* 
Задача 62: 
    Напишите программу, которая заполнит спирально массив 4 на 4.
    Например, на выходе получается вот такой массив:
 
    Пример:
    ```
    1  2  3  4
    12 13 14 5
    11 16 14 6
    10 9  8  7
    ```
 */
using System;

public class Answer
{
    public static void FillSpiralMatrix(int m, int n)
    {
        int[,] array = new int[m, n];
        int number = 1;
        int row = 0, col = 0;

        // Определяем количество "слоев" в матрице 
        int layers = (Math.Min(m, n) + 1) / 2;

        for (int layer = 0; layer < layers; layer++)
        {
            // Заполнение слева направо
            for (int i = col; i < n - col; i++)
                array[row, i] = number++;

            // Заполнение сверху вниз
            for (int i = row + 1; i < m - row; i++)
                array[i, n - col - 1] = number++;

            // Заполнение справа налево
            for (int i = n - col - 2; i >= col; i--)
                array[m - row - 1, i] = number++;

            // Заполнение снизу вверх
            for (int i = m - row - 2; i > row; i--)
                array[i, col] = number++;

            row++;
            col++;
        }
        PrintMatrix(array);
    }

    public static void PrintMatrix<T>(T[,] matrix)
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

    static public void Main(string[] args)
    {
        Console.Clear();
        int m = 5;
        int n = 5;

        if (args.Length == 2)
        {
            m = int.Parse(args[0]);
            n = int.Parse(args[1]);
        }

        FillSpiralMatrix(m, n);

        Console.WriteLine("\n* Примечание:");
        Console.WriteLine("  Для ручного определения матрицы введите: dotnet run m n");
        Console.WriteLine("  где:");
        Console.WriteLine("    m - количество строк;");
        Console.WriteLine("    n - количество столбцов.\n");

    }
}