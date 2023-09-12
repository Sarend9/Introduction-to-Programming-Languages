// See https://aka.ms/new-console-template for more information

// Задача 12: Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу
// 1, то программа выводит остаток от деления.

Console.Write("Введите два числа через запятую: ");
string input = Console.ReadLine();
string[] numbers = input.Split(',');

if (numbers.Length != 2 || !int.TryParse(numbers[0].Trim(), out int number1) || !int.TryParse(numbers[1].Trim(), out int number2))
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите два целых числа через запятую.");
    return;
}

if (IsMultiples(number1, number2))
{
    Console.WriteLine($"{number2} кратно {number1}");
}
else
{
    Console.WriteLine($"{number2} не кратно {number1}, остаток от деления: {CalculateRemainder(number1, number2)}");
}

static bool IsMultiples(int number1, int number2)
{
    return number2 % number1 == 0;
}

static int CalculateRemainder(int number1, int number2)
{
    return number2 % number1;
}