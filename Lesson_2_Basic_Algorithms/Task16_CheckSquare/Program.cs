// See https://aka.ms/new-console-template for more information

// Задача 16: Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.


Console.Write("Введите два числа через запятую: ");
string input = Console.ReadLine();
string[] numbers = input.Split(',');

if (numbers.Length != 2 || !double.TryParse(numbers[0], out double number1) || !double.TryParse(numbers[1], out double number2))
{
    Console.WriteLine("Ошибка: Введите два корректных числа, разделенных запятой.");
    return;
}

if (IsSquare(number1, number2))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

static bool IsSquare(double number1, double number2)
{
    double sqrt1 = Math.Sqrt(number1);
    double sqrt2 = Math.Sqrt(number2);

    return Math.Round(sqrt1) == sqrt1 || Math.Round(sqrt2) == sqrt2;
}
