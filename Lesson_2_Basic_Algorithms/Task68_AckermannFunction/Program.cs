/* 
Задача 68: 
    Напишите программу вычисления функции Аккермана с помощью
    рекурсии. Даны два неотрицательных числа m и n. 

    m = 2, n = 3 -> A(m,n) = 29
 */

using System;

public class Answer
{
    public static int AkkermanFunction(int m, int n)
    {
        if (m < 0 || n < 0)
        {
            throw new ArgumentException("m и n должны быть неотрицательными числами.");
        }

        if (m == 0)
            return n + 1;
        else if (n == 0)
            return AkkermanFunction(m - 1, 1);
        else
            return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }

    public static bool ValidInput(string input)
    {
        if (int.TryParse(input, out int result))
        {
            return result >= 0;
        }
        return false;
    }

    public static bool IsValidInputRange(int m, int n)
    {
        switch (m)
        {
            case 0:
                return n >= 0 && n <= int.MaxValue;
            case 1:
                return n <= 13750;
            case 2:
                return n <= 6870;
            case 3:
                return n <= 10;
            case 4:
                return n <= 0;
            default:
                return false;
        }
    }

    static void Main(string[] args)
    {
        Console.Clear();

        int m = 2;
        int n = 3;

        if (args.Length == 2)
        {
            m = int.Parse(args[0]);
            n = int.Parse(args[1]);
        }

        for (int i = 0; i < args.Length; i++)
        {
            if (!ValidInput(args[i]))
            {
                Console.WriteLine("Ошибка: Введите два натуральных числа.");
                return;
            }
        }

        if (!IsValidInputRange(m, n))
        {
            Console.WriteLine("Ошибка: m и n должны быть в допустимых пределах.");
            return;
        }

        Console.WriteLine($"A({m},{n}) = {AkkermanFunction(m, n)}");


        Console.WriteLine("\n* Примечание:");
        Console.WriteLine("  Эта программа вычисляет функцию Аккермана для заданных неотрицательных чисел.");
        Console.WriteLine("  Для запуска программы, введите: dotnet run M N");
        Console.WriteLine("  Где:");
        Console.WriteLine("    M - первый аргумент функции Аккермана (неотрицательное целое число)");
        Console.WriteLine("    N - второй аргумент функции Аккермана (неотрицательное целое число)\n");
    }
}
