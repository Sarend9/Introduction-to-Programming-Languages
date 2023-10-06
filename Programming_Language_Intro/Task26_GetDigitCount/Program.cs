// See https://aka.ms/new-console-template for more information

/* 
Задача 26: Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5  
*/

Console.Write("Введите число: ");
double  input = double.Parse(Console.ReadLine());

Console.WriteLine($"Количество чисел в числе {input} равна {GetDigitCount(input)}.");

static int GetDigitCount(double  number)
{
    int count = 0;
    foreach (char c in number.ToString())
    {
        if (Char.IsDigit(c))
        {
            count++;
        }
    }
    return count;
}

