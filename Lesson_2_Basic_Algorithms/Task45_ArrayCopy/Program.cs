// See https://aka.ms/new-console-template for more information
Console.Clear();
/* 
Задача 45: 
    Напишите программу, которая будет создавать копию
    заданного массива с помощью поэлементного копирования.
 */

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rand.Next(minValue, maxValue + 1);
    }
    return result;
}

int[] CopyArray(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;
}

int[] array = GetArray(10, 0, 10);
Console.WriteLine($"* Изначальный массив: {string.Join(" ", array)}");
array = CopyArray(array);
Console.WriteLine($"* Скопированный массив: {string.Join(" ", array)}");
