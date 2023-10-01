/* 
Задача 66: 
   Задайте значения M и N. Напишите программу, которая найдёт 
   сумму натуральных элементов в промежутке от M до N.

    M = 1; N = 15 -> 120
    M = 4; N = 8 -> 30
 */

using System;

public class Answer
{
    public static int SumOfNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            return m + SumOfNaturalNumbers(m + 1, n);
        }
        return 0;
    }

    public static bool ValidInput(string input)
    {
        if (int.TryParse(input, out int result))
        {
            return result > 0;
        }
        return false;
    }


    static public void Main(string[] args)
    {
        Console.Clear();

        int m = 1;
        int n = 15;

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

        Console.WriteLine($"M = {m}; N = {n} -> {SumOfNaturalNumbers(m, n)}");


        Console.WriteLine("\n* Примечание:");
        Console.WriteLine("  Эта программа вычисляет сумму натуральных чисел в диапазоне [M, N].");
        Console.WriteLine("  Для запуска программы, введите: dotnet run M N");
        Console.WriteLine("  Где:");
        Console.WriteLine("    M - начальное натуральное число");
        Console.WriteLine("    N - конечное натуральное число\n");
    }

}