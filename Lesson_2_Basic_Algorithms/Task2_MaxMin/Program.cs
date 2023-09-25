// See https://aka.ms/new-console-template for more information
/* 
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
 */
Console.Clear();

Console.Write("Введите первое число (a): ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число (b): ");
int b = int.Parse(Console.ReadLine()!);

int max = Math.Max(a, b);
int min = Math.Min(a, b);

Console.WriteLine();
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: " + min);
