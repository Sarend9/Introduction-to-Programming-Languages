// See https://aka.ms/new-console-template for more information

/* 
Задача 34: 
    Задайте массив заполненный случайными 
    положительными трёхзначными числами. 
    Напишите программу, которая покажет 
    количество чётных чисел в массиве.

    [345, 897, 568, 234] -> 2
 */

try
{
    int[] numbers = GenerateRandomNumbers();
    PrintNumbers(numbers);
    int evenCount = CountEvenNumbers(numbers);
    Console.Write($"* Количество четных чисел: {evenCount}");

}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
    Environment.Exit(1);
}


static void PrintNumbers(int[] numbers)
{
    Console.Write("* Сгенерированные числа: ");
    foreach (var item in numbers)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

static int[] GenerateRandomNumbers()
{
    Console.Write("* Введите количество чисел для генерации: "); ;
    int count = int.Parse(Console.ReadLine());
    int[] numbers = new int[count];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }

    return numbers;
}

static int CountEvenNumbers(int[] numbers)
{
    int evenCount = 0;

    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            evenCount++;
        }
    }

    return evenCount;
}

