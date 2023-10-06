// See https://aka.ms/new-console-template for more information
/* 
Задача 49: 
    Задайте двумерный массив. Найдите элементы, у
    которых оба индекса чётные, и замените эти элементы на их
    квадраты.

    Начальный массив:
    ```
    1 4 7 2
    5 9 2 3
    8 4 2 4
    ```

    Результат:
    ```
    1 4 7 2
    5 81 2 9
    8 4 2 4
    ```
 */

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SquareElementsWithEvenIndices(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
}

int m = WorkWithUser("Введите количество строк m: ");
int n = WorkWithUser("Введите количество столбцов n: ");
int[,] array = GetArray(m, n, 0, 10);

Console.WriteLine("Начальный массив:");
PrintArray(array);

SquareElementsWithEvenIndices(array);

Console.WriteLine("\nРезультат:");
PrintArray(array);
