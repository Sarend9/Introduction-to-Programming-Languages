/*
Задача 54:
    Задайте двумерный массив. Напишите программу, которая
    упорядочит по убыванию элементы каждой строки двумерного массива.
    
    Например, задан массив:
    ```
    1 4 7 2
    5 9 2 3
    8 4 2 4
    ```

    В итоге получается вот такой массив:
    ```
    7 4 2 1
    9 5 3 2
    8 4 4 2
  ```
 */

public class Answer
{
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

    public static void SortRowsDescending(int[,] matrix)
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

            int[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
            PrintMatrix(array);
            SortRowsDescending(array);
        }
        else
        {
            m = 3;
            n = 4;
            minLimitRandom = -10;
            maxLimitRandom = 10;

            int[,] array =
            CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
            PrintMatrix(array);

            Console.WriteLine("\nУпорядоченная матрица:");
            SortRowsDescending(array);

            Console.WriteLine("\n* Примечание:");
            Console.WriteLine("  Для ручного определения матрицы введите: dotnet run m n minLimitRandom maxLimitRandom");
            Console.WriteLine("  где:");
            Console.WriteLine("    m - количество строк;");
            Console.WriteLine("    n - количество столбцов;");
            Console.WriteLine("    minLimitRandom - минимальное значение случайных элементов матриц;");
            Console.WriteLine("    maxLimitRandom - максимальное значение случайных элементов матриц.\n");
        }
    }
}
