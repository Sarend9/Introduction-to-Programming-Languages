// See https://aka.ms/new-console-template for more information
/* 
Задача 37: 
    Найдите произведение пар чисел в одномерном массиве.
    Парой считаем первый и последний элемент, 
    второй и предпоследнийи т.д. 
    Результат запишите в новом массиве.
    
    [1 2 3 4 5] -> 5 8 3
    [6 7 3 6] -> 12 10
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

static void MultiplyAndPrintArray(int[] inputArray)
{
    int lastIndex = inputArray.Length - 1;

    for (int i = 0; i < inputArray.Length / 2; i++)
    {
        Console.Write(inputArray[i] * inputArray[lastIndex] + " ");
        lastIndex--;
    }

    if (inputArray.Length % 2 != 0)
    {
        Console.Write(inputArray[inputArray.Length / 2] + " ");
    }
}

int size = WorkWithUser("* Введите размер массива: ");
int minValue = WorkWithUser("* Введите минимальное значение диапазона: ");
int maxValue = WorkWithUser("* Введите максимальное значение диапазона: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
MultiplyAndPrintArray(array);



