/* 
Задача 61: 
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
    public static void FUNC1(int n)
    {
        int[,] array = new int[n, n];
        array[0, 0] = 0;
        int number = 0;

        for (int i = 0; i < n; i++)
        {
            number++;
            array[0, i] = number;
        }

        number = 0;
        for (int i = 0; i < n; i++)
        {
            number++;
            array[i, 4] += 1;
        }

        number = 4;
        for (int i = 0; i < n; i++)
        {
            number++;
            array[4, i] -= 1;
        }

        number = 4;
        for (int i = 0; i < n - 1; i++)
        {
            number++;
            array[i, 4] -= 1;
        }

        PrintMatrix(array);
    }

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


    public static int ValidateInput(string[] args)
    {
        if (args.Length == 1 && int.TryParse(args[0], out int n) && n > 0)
        {
            return n;
        }
        else
        {
            Console.WriteLine("Неверные входные данные. Используется значение по умолчанию (5).");
            return 5;
        }
    }

    static public void Main(string[] args)
    {
        Console.Clear();

        int n = 5;

        if (args.Length == 1)
        {
            n = ValidateInput(args);
        }

        FUNC1(n);
    }
}