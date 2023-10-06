// See https://aka.ms/new-console-template for more information

/* 
Задача 24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36 
*/

Console.Write("Введите число: ");
int input = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма чисел от 1 до {input} равна {CalculateSum(input)}.");

static int CalculateSum(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i;
        Console.WriteLine($"i:{i}, sum: {sum}");
    } 
    return sum;
}


