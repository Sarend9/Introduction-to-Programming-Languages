// See https://aka.ms/new-console-template for more information

// Задача 9: Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

Random random = new Random();
int randomNumber = random.Next(10, 100);

Console.WriteLine($"Случайное число: {randomNumber}");
Console.WriteLine($"Наибольшая цифра числа {randomNumber} -> {GetMaxDigit(randomNumber)}");

static int GetMaxDigit(int number)
{
    int maxDigit = 0;

    while (number > 0)
    {
        int digit = number % 10;
        maxDigit = Math.Max(maxDigit, digit);
        number /= 10;
    }

    return maxDigit;
}

