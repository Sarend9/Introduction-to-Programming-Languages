// See https://aka.ms/new-console-template for more information

/* Задача 21: Напишите программу, которая
принимает на вход координаты двух точек и
находит расстояние между ними в 2D
пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21 */

List<double> Prompt(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine();

    string[] numberStrings = input.Split(',');
    List<double> numbers = new List<double>();

    foreach (string numberString in numberStrings)
    {
        if (double.TryParse(numberString.Replace(".", ","), out double number))
        {
            numbers.Add(number);
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректные числа, разделенные запятой.");
            return null;
        }
    }

    return numbers;
}

static double CalculateDistance(List<double> pointA, List<double> pointB)
{
    double cathetus1 = Math.Abs(pointA[0] - pointB[0]);
    double cathetus2 = Math.Abs(pointA[1] - pointB[1]);

    return Math.Sqrt(Math.Pow(cathetus1, 2) + Math.Pow(cathetus2, 2));
}

List<double> A = Prompt("Введите координаты точки A(x,y): ");
if (A == null || A.Count != 2)
{
    Console.WriteLine("Ошибка: Введите корректные координаты точки в формате 'x,y'.");
    return;
}

List<double> B = Prompt("Введите координаты точки B(x,y): ");
if (B == null || B.Count != 2)
{
    Console.WriteLine("Ошибка: Введите корректные координаты точки в формате 'x,y'.");
    return;
}

double distance = CalculateDistance(A, B);

Console.WriteLine($"Расстояние между точкой A и B: {distance:F2}");

