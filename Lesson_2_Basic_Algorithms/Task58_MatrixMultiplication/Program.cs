/* 
Задача 58:
    Задайте две матрицы. Напишите программу, 
    которая будет находить произведение двух матриц.
    
    Например, даны 2 матрицы:
    ```
    2 4 | 3 4
    3 2 | 3 3
    ```

    Результирующая матрица будет:
    ```
    18 20
    15 18
    ```
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

    public static void MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int numRows1 = matrix1.GetLength(0);
        int numCols1 = matrix1.GetLength(1);
        int numRows2 = matrix2.GetLength(0);
        int numCols2 = matrix2.GetLength(1);

        if (numCols1 != numRows2)
        {
            Console.WriteLine("Невозможно умножить матрицы. Количество столбцов первой матрицы не совпадает с количеством строк второй матрицы.");
            return;
        }

        int[,] resultMatrix = new int[numRows1, numCols2];

        for (int i = 0; i < numRows1; i++)
        {
            for (int j = 0; j < numCols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < numRows2; k++)
                {
                    // Console.WriteLine($"resultMatrix[{i},{j}] = matrix1[{i},{k}] x matrix2[{k},{j}]"); //Отладка
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }

        PrintMatrix(resultMatrix);
    }


    static public void Main(string[] args)
    {
        Console.Clear();
        int m1, n1, m2, n2, minLimitRandom, maxLimitRandom;

        if (args.Length >= 6)
        {
            m1 = int.Parse(args[0]);
            n1 = int.Parse(args[1]);

            m2 = int.Parse(args[2]);
            n2 = int.Parse(args[3]);

            minLimitRandom = int.Parse(args[4]);
            maxLimitRandom = int.Parse(args[5]);
        }
        else
        {
            m1 = 2;
            n1 = 3;

            m2 = 3;
            n2 = 2;

            minLimitRandom = -10;
            maxLimitRandom = 10;
        }
        /* int[,] array_1 = CreateRandomMatrix(m1, n1, minLimitRandom, maxLimitRandom);
        int[,] array_2 = CreateRandomMatrix(m2, n2, minLimitRandom, maxLimitRandom);
 */

        int[,] array_1 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        int[,] array_2 = { { 7, 8, 9 }, { 10, 11, 12 } };

        Console.WriteLine("\nПеврая матрица");
        PrintMatrix(array_1);
        Console.WriteLine("\nВторая матрица");
        PrintMatrix(array_2);
        Console.WriteLine("\nУмножение матриц:");
        MultiplyMatrices(array_1, array_2);

        Console.WriteLine("\n* Примечание:");
        Console.WriteLine("  Для ручного определения первой и второй матрицы введите:");
        Console.WriteLine("  dotnet run m1 n1 m2 n2 minLimitRandom maxLimitRandom");
        Console.WriteLine("  где:");
        Console.WriteLine("    m1 - количество строк первой матрицы;");
        Console.WriteLine("    n1 - количество столбцов первой матрицы;");
        Console.WriteLine("    m2 - количество строк второй матрицы;");
        Console.WriteLine("    n2 - количество столбцов второй матрицы;");
        Console.WriteLine("    minLimitRandom - минимальное значение случайных элементов матриц;");
        Console.WriteLine("    maxLimitRandom - максимальное значение случайных элементов матриц.\n");

    }
}





































