// See https://aka.ms/new-console-template for more information

/* 
Задача 41: 
    Пользователь вводит с клавиатуры M чисел. 
    Посчитайте, сколько чисел больше 0 ввёл пользователь.
    
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223 -> 3
 */
using System.Globalization;

static List<double> Prompt(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine();

    string[] numberStrings = input.Split(",");
    List<double> numbers = new();

    foreach (string numberString in numberStrings)
    {
        if (double.TryParse(numberString.Replace(".", ","), out double number))
        {
            numbers.Add(number);
        }
        else
        {
            Console.WriteLine("Ошибка: Введите корректные числа, разделенные запятой.");
            Environment.Exit(0);
        }
    }
    return numbers;
}

static int CountPositiveNumbers(List<double> numbers)
{
    int count = 0;
    foreach (double number in numbers)
    {
        if (number > 0) count++;
    }
    return count;
}

List<double> numbers = Prompt("Введите массив через запятую: ");
string formattedNumbers = string.Join(", ", numbers.Select(num => num.ToString(CultureInfo.InvariantCulture)));
Console.WriteLine($"{formattedNumbers} -> {CountPositiveNumbers(numbers)}");
