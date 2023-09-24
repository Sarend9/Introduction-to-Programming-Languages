// See https://aka.ms/new-console-template for more information

/* 
Задача 57: 
    Составить частотный словарь элементов
    двумерного массива. Частотный словарь содержит
    информацию о том, сколько раз встречается элемент
    входных данных.
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



    public static int[] CreateArray(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);

        int[] array = new int[numRows * numCols];

        int index = 0;

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }
        return array;
    }

    public static void SortArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }

        }
        Console.WriteLine("[" + string.Join(", ", array) + "]");
    }

    public static void CountElement(int[] array)
    {
        int findElement = array[0];
        int count = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == findElement)
            {
                count++;
            }
            else
            {
                Console.WriteLine($"число {findElement,2} встречается {count,2} {GetEnding(count)}");
                findElement = array[i];
                count = 1;
            }
        }
        Console.WriteLine($"число {findElement,2} встречается {count,2} {GetEnding(count)}");
    }

    public static string GetEnding(int count)
    {
        int lastDigit = count % 10;
        string ending;

        switch (lastDigit)
        {
            case 1:
                ending = "раз";
                break;
            case 2:
            case 3:
            case 4:
                ending = "раза";
                break;
            default:
                ending = "раз";
                break;
        }

        return ending;
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
        int[,] matrix = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
        PrintMatrix(matrix);
        Console.WriteLine();
        int[] array = CreateArray(matrix);
        Console.WriteLine();
        Console.WriteLine("[" + string.Join(", ", array) + "]");
        SortArray(array);
        CountElement(array);
    }
}



