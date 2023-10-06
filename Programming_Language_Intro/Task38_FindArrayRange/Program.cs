// See https://aka.ms/new-console-template for more information

/* 
Задача 38: 
    Задайте массив вещественных чисел. 
    Найдите разницу между максимальным и минимальным элементов массива.

    [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
 */


using System.Globalization;


static List<double> Prompt(string prompt)
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
            Environment.Exit(0);
        }
    }

    return numbers;
}

static void CalculateRangeAndPrint(List<double> numbers)
{
    if (numbers.Count == 0)
    {
        Console.WriteLine("Массив пуст.");
        return;
    }

    double min = numbers[0];
    double max = numbers[0];

    foreach (double number in numbers)
    {
        if (number < min)
            min = number;

        if (number > max)
            max = number;
    }
    double range = max - min;
    string formattedNumbers = string.Join(", ", numbers.Select(num => num.ToString(CultureInfo.InvariantCulture)));
    
    Console.WriteLine($"* Вывод: [{formattedNumbers}] => {max.ToString(CultureInfo.InvariantCulture)} - {min.ToString(CultureInfo.InvariantCulture)} = {range.ToString(CultureInfo.InvariantCulture)}");
}


List<double> numbers = Prompt("* Введите числа: ");
CalculateRangeAndPrint(numbers);


//ТЕСТы
/* 
Console.WriteLine(numbers.Select(num => num.ToString(CultureInfo.InvariantCulture)).ToList()[0]);
Console.WriteLine(numbers[0]);
//Console.WriteLine(Convert.ToDouble(numbers[0]));
 */
