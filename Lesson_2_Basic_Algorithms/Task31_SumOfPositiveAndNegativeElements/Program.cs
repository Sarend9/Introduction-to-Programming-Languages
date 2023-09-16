// See https://aka.ms/new-console-template for more information

/* 
Задача 31: Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.

Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
* сумма положительных чисел равна 29, 
* сумма отрицательных равна -20.
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
    Console.Write("* Массив:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void GetSums(int[] inArray)
{
    int positiveSum = 0;
    int negativeSum = 0;
    foreach (int el in inArray)
    {
        if (el > 0) positiveSum += el;
        else negativeSum += el;
    }
    Console.WriteLine($"* Сумма положительных чисел равна: {positiveSum}");
    Console.WriteLine($"* Сумма отрицательных чисел равна: {negativeSum}");
}

int size = WorkWithUser("* Введите размер массива: ");
int minValue = WorkWithUser("* Введите минимальное значение диапазона: ");
int maxValue = WorkWithUser("* Введите максимальное значение диапазона: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
GetSums(array);

