// See https://aka.ms/new-console-template for more information
/* 
Задача 46: 
    Задайте двумерный массив размером m×n,
    заполненный случайными целыми числами.

    m = 3, n = 4.
    1 4 8 19
    5 -2 33 -2
    77 3 8 1
 */

 Console.Clear();

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

static void PrintArray(int[,] array)
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

int m = WorkWithUser("Введите количество строк m: ");
int n = WorkWithUser("Введите количество столбцов n: ");
int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);