// See https://aka.ms/new-console-template for more information

// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
if (!int.TryParse(Console.ReadLine(), out int number) || number < 100 || number > 999)
{
    Console.WriteLine("Ошибка: Введите корректное трёхзначное число.");
    return;
}

int digit1 = number / 100;
int digit2 = (number / 10) % 10;
int digit3 = number % 10;

Console.WriteLine($"Первая цифра: {digit1}");
Console.WriteLine($"Вторая цифра: {digit2}");
Console.WriteLine($"Третья цифра: {digit3}");
