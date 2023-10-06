// See https://aka.ms/new-console-template for more information
Console.Clear();
/* 
Задача 40: 
    Напишите программу, которая принимает на вход три числа и
    проверяет, может ли существовать треугольник с сторонами такой длины.

    Теорема о неравенстве треугольника: каждая сторона треугольника
    меньше суммы двух других сторон.
 */

static int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

static bool Triangle(int a, int b, int c)
{
    bool res = false;
    if (a < (b + c) && b < (a + c) && c < (b + a)) res = true;
    return res;
}

int a = WorkWithUser("* Введите сторону a: ");
int b = WorkWithUser("* Введите сторону b: ");
int c = WorkWithUser("* Введите сторону c: ");
Console.WriteLine($"* {Triangle(a, b, c)}");