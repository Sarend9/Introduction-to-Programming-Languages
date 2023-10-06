// See https://aka.ms/new-console-template for more information

/* 
Задача 28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
 */

Console.Write("Введите число: ");
int input = int.Parse(Console.ReadLine());

Console.WriteLine($"Факториал {input} равен {CalculateFactorial(input)}.");

static ulong CalculateFactorial(int N)
{
    if (N < 0)
    {
        Console.WriteLine("Ошибка: Факториал не определен для отрицательных чисел");
        return 0; // Мы используем ulong, чтобы вернуть 0 вместо -1.
    }
    if (N == 0 || N == 1)
    {

        return 1;
    }

    ulong factorial = 1;
    for (int i = 2; i <= N; i++)
    {
        factorial *= (ulong)i;
        Console.WriteLine($"i:{i}, factorial: {factorial}");

    }
    return factorial;
}




