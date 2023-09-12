// See https://aka.ms/new-console-template for more information

/* 
Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
 */


int[] binaryArray = GenerateRandomBinaryArray(8);

Console.WriteLine("Сгенерированный массив из 8 элементов:");
PrintArray(binaryArray);


static int[] GenerateRandomBinaryArray(int length)
{
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(2);
    }

    return array;
}

static void PrintArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write(element + " ");
    }
    Console.WriteLine();
}
