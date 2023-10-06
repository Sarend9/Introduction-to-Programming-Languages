// See https://aka.ms/new-console-template for more information

/* 
Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125
*/

int[] CalculateCubes(int number)
{
    if (number < 1)
    {
        Console.WriteLine("Число должно быть больше или равно 1.");
    }

    int[] cubes = new int[number];

    for (int i = 1; i <= number; i++)
    {
        cubes[i - 1] = i * i * i;
    }

    return cubes;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int[] cubes = CalculateCubes(number);

Console.Write("Кубы чисел: ");
Console.WriteLine(string.Join(", ", cubes));


