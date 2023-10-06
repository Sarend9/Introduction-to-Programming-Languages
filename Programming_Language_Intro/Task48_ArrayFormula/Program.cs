// See https://aka.ms/new-console-template for more information
/* 
Задача 48: 
    Задайте двумерный массив размера m на n,
    каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
    Выведите полученный массив на экран.
    m = 3, n = 4.
    0 1 2 3
    1 2 3 4
    2 3 4 5
 */
static int WorkWithUser(string prompt)
{
    int result;
    do
    {
        Console.Write(prompt);
    } while (!int.TryParse(Console.ReadLine(), out result));
    return result;
}

static int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
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

int m = WorkWithUser("Введите значение m: ");
int n = WorkWithUser("Введите значение n: ");

int[,] array = CreateArray(m, n);

PrintArray(array);