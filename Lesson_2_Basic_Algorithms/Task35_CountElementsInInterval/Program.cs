// See https://aka.ms/new-console-template for more information
/* 
Задача 35: 
    Задайте одномерный массив из 123 случайных чисел.
    Найдите количество элементов массива, 
    значения которых лежат в отрезке [10,99].

    Пример для массива из 5, а не 123 элементов. 
    В своём решении сделайте для 123

    [5, 18, 123, 6, 2] -> 1
    [1, 2, 3, 6, 2] -> 0
    [10, 11, 12, 13, 14] -> 5
 */

static int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

static void PrintArray(int[] arr)
{
    Console.Write("* Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

static int[] GetArray(int length, int min, int max)
{
    int[] result = new int[length];
    Random random = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(min, max + 1);
    }
    return result;
}

static void CountTwoDigitNumbers(int[] array)
{
    int totalCount = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] >= 10 && array[index] <= 99)
        {
            totalCount++;
        }
    }
    Console.WriteLine($"Всего найдено двузначных чисел: {totalCount}");

}


int size = WorkWithUser("* Введите размер массива: ");
int minValue = WorkWithUser("* Введите минимальное значение диапазона: ");
int maxValue = WorkWithUser("* Введите максимальное значение диапазона: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
CountTwoDigitNumbers(array);


