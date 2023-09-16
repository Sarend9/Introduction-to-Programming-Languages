// See https://aka.ms/new-console-template for more information
/* 
Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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

static void CheckIfValueExists(int[] array, int target)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target) 
        {
            Console.WriteLine("* Yes");
            return;
        }
    }
    Console.WriteLine("* No");
}


int size = WorkWithUser("* Введите размер массива: ");
int minValue = WorkWithUser("* Введите минимальное значение диапазона: ");
int maxValue = WorkWithUser("* Введите максимальное значение диапазона: ");
int value = WorkWithUser("* Введите искомое значение: ");
int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
CheckIfValueExists(array, value);

