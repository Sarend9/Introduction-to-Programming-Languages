/* 
Задача 61: 
    Вывести первые N строк треугольника
    Паскаля. Сделать вывод в виде равнобедренного
    треугольника
 */
using System;

public class Answer
{
    public static void GeneratePascalTriangle(int N)
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N - i - 1; j++)
            {
                Console.Write(" ");
            }

            int number = 1;
            for (int j = 0; j <= i; j++)
            {
                Console.Write(number + " ");
                number = number * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }

    public static int ValidateInput(string[] args)
    {
        if (args.Length == 1 && int.TryParse(args[0], out int n) && n > 0)
        {
            return n;
        }
        else
        {
            Console.WriteLine("Неверные входные данные. Используется значение по умолчанию (5).");
            return 5;
        }
    }

    static public void Main(string[] args)
    {
        Console.Clear();

        int n = 5;

        if (args.Length == 1)
        {
            n = ValidateInput(args);
        }

        GeneratePascalTriangle(n);
    }
}