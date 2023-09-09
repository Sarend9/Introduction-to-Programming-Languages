// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число (a): ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число (b): ");
int b = int.Parse(Console.ReadLine());

int max = Math.Max(a, b);
int min = Math.Min(a, b);

Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: " + min);
