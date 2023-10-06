// See https://aka.ms/new-console-template for more information

/* 
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 
*/

Console.Write("Введите число: ");
int input = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {input} равна {CalculateDigitSum(input)}");

static int CalculateDigitSum(int number)
{
    int temp = number;
    int sum = 0;
    for (int i = 0; i < number.ToString().Length; i++)
    {
        sum += temp % 10;
        temp /= 10;
    } 
    return sum;
}


