/* 
Задача 60:
    Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
    Напишите программу, которая будет построчно выводить массив, 
    добавляя индексы каждого элемента.

  Массив размером 2 x 2 x 2

  ```
  66(0,0,0) 25(0,1,0)
  34(1,0,0) 41(1,1,0)
  27(0,0,1) 90(0,1,1)
  26(1,0,1) 55(1,1,1)
  ```
    ```
*/

using System;

public class Answer
{
    static void Print3DMatrix(int[,,] matrix)
    {
        int depth = matrix.GetLength(0);
        int rows = matrix.GetLength(1);
        int columns = matrix.GetLength(2);

        for (int i = 0; i < depth; i++)
        {
            Console.WriteLine($"Глубина {i + 1}:");
            for (int j = 0; j < rows; j++)
            {
                for (int k = 0; k < columns; k++)
                {
                    Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }


    static int[,,] CreateRandom3DMatrix(int m, int n, int p, int minLimitRandom, int maxLimitRandom)
    {
        if ((maxLimitRandom - minLimitRandom + 1) < (m * n * p))
        {
            Console.WriteLine($"Невозможно создать трехмерный массив размером {m}x{n}x{p}, так как доступно всего {maxLimitRandom - minLimitRandom + 1} уникальных чисел!");
            Environment.Exit(1);
        }

        Random rand = new();
        int[] usedNumbers = new int[maxLimitRandom - minLimitRandom + 1];
        int[,,] array3D = new int[m, n, p];
        int num;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < p; k++)
                {
                    do
                    {
                        num = rand.Next(minLimitRandom, maxLimitRandom + 1);
                    }
                    while (usedNumbers[num - minLimitRandom] != 0);

                    array3D[i, j, k] = num;
                    usedNumbers[num - minLimitRandom] = 1;
                }
            }
        }
        return array3D;
    }


    static public void Main(string[] args)
    {
        Console.Clear();
        int m, n, p, minLimitRandom, maxLimitRandom;

        if (args.Length >= 5)
        {
            m = int.Parse(args[0]);
            n = int.Parse(args[1]);
            p = int.Parse(args[2]);

            minLimitRandom = int.Parse(args[3]);
            maxLimitRandom = int.Parse(args[4]);
        }
        else
        {
            m = 3;
            n = 3;
            p = 3;

            minLimitRandom = 10;
            maxLimitRandom = 99;
        }

        int[,,] matrix3D = CreateRandom3DMatrix(m, n, p, minLimitRandom, maxLimitRandom);
        Print3DMatrix(matrix3D);

    }
}



