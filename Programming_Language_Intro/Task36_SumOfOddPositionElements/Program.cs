// See https://aka.ms/new-console-template for more information

/* 
Задача 36: 
    Задайте одномерный массив, заполненный случайными числами. 
    Найдите сумму элементов, стоящих на нечётных позициях.

    [3, 7, 23, 12] -> 19
    [-4, -6, 89, 6] -> 0
 */

try
{
    int[] numbers = GenerateRandomNumbers();
    PrintNumbers(numbers);
    CalculateSumOfOddIndexedElements(numbers);
}
catch (Exception ex)
{
    Console.WriteLine($"Произошла ошибка: {ex.Message}");
    Environment.Exit(1);
}

static int[] GenerateRandomNumbers()
{
    Console.Write("* Введите количество чисел для генерации: "); ;
    int count = int.Parse(Console.ReadLine());
    int[] numbers = new int[count];

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-99, 100);
    }

    return numbers;
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

static void CalculateSumOfOddIndexedElements(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        sum += numbers[i];
    }
    Console.Write("* Сумма элементов, стоящих на нечётных позициях: ");
    Console.WriteLine(sum);
}