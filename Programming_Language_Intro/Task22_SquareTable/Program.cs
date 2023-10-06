// See https://aka.ms/new-console-template for more information

/* 
Напишите программу, которая
принимает на вход число (N) и выдаёт таблицу
квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 
*/

int[] CalculateSquares(int number)
{
    if (number < 1)
    {
        Console.WriteLine("Число должно быть больше или равно 1.");
    }

    int[] squares = new int[number];

    for (int i = 1; i <= number; i++)
    {
        squares[i - 1] = i * i;
    }

    return squares;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int[] squares = CalculateSquares(number);

Console.Write("Квадраты чисел: ");
Console.WriteLine(string.Join(", ", squares));
