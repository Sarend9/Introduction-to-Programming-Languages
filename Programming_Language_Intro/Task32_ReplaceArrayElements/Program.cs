// See https://aka.ms/new-console-template for more information
/* 
Задача 32: Напишите программу замена элементов
массива: положительные элементы замените на
соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
 */

int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[] GetArray(int length, int min, int max)
{
    int[] result = new int[length];
    Random random = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = random.Next(min, max + 1);
    }
    return result;
}

void PrintArray(int[] arr)
{
    Console.Write("* Массив: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void Opposite(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = numbers[i] * (-1);
    }
}

int size = WorkWithUser("* Введите размер массива: ");
int minValue = WorkWithUser("* Введите минимальное значение диапазона: ");
int maxValue = WorkWithUser("* Введите максимальное значение диапазона: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Opposite(array);
PrintArray(array);