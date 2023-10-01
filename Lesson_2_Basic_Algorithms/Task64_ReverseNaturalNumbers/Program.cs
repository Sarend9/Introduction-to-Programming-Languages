/* 
Задача 64: 
    Задайте значение N. Напишите программу, 
    которая выведет все натуральные числа в промежутке от N до 1.
    Выполнить с помощью рекурсии.

    N = 5 -> "5, 4, 3, 2, 1"
    N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */
using System;

public class Answer
{
    public static string ReverseNaturalNumbers(int n)
    {
        {
            if (n < 1)
            {
                return "";
            }

            string currentNumber = n.ToString();
            if (n > 1)
            {
                currentNumber += ", ";
            }

            return currentNumber + ReverseNaturalNumbers(n - 1);
        }
    }

    public static void Main(string[] args)
    {
        Console.Clear();

        int n = 5;

        if (args.Length == 1)
        {
            n = int.Parse(args[0]);
        }

        Console.WriteLine(ReverseNaturalNumbers(n));

        Console.WriteLine("\n* Примечание:");
        Console.WriteLine("  Эта программа выводит все натуральные числа в промежутке от N до 1.");
        Console.WriteLine("  Для запуска программы, введите: dotnet run N");
        Console.WriteLine("  Где:");
        Console.WriteLine("    N - натуральное число\n");

    }

}