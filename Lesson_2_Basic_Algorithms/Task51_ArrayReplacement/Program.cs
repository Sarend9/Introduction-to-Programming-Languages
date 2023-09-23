// See https://aka.ms/new-console-template for more information
/* 
Задайте двумерный массив и найдите элементы, 
у которых оба индексы чётные. 

Замените эти элементы на их квадраты.

  Например, задан массив:
  ```
  1 4 7 2
  5 9 2 3
  8 4 2 4
  ```
  Сумма элементов главной диагонали: 1+9+2 = 12
 */

Console.Clear();

static int WorkWithUser(string prompt)
{
    int result;
    bool isValidInput;

    do
    {
        Console.Write(prompt);
        isValidInput = int.TryParse(Console.ReadLine(), out result);

        if (!isValidInput)
        {
            Console.WriteLine("Ошибка: Введите корректное значение.");
        }
    } while (!isValidInput);

    return result;
}



static int[,] GetArray(int rows, int columns, int minValue, int maxValue)
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

static int CalculateDiagonalSum(int[,] array)
{
    int sum = 0;
    int length = Math.Min(array.GetLength(0), array.GetLength(1));

    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }

    return sum;
}

int m = WorkWithUser("Введите количество строк m: ");
int n = WorkWithUser("Введите количество столбцов n: ");
int[,] array = GetArray(m, n, 0, 10);
PrintArray(array);
Console.WriteLine($"Сумма по диагонали: {CalculateDiagonalSum(array)}");