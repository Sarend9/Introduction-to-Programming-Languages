// See https://aka.ms/new-console-template for more information

// Задача 17: Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

List<double> Prompt(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine();

    string[] numberStrings = input.Split(',');
    List<double> numbers = new List<double>();

    foreach (string numberString in numberStrings)
    {
        if (double.TryParse(numberString, out double number))
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

static void QuarterSearch(double x, double y)
{
    string quarter = (x >= 0 && y >= 0) ? "I" : (x <= 0 && y > 0) ? "II" : (x < 0 && y <= 0) ? "III" : "IV";
    Console.WriteLine($"При x = {x}, y = {y}, номер четверти: {quarter}");
}

List<double> numbers = Prompt("Введите координаты точки (X, Y): ");
if (numbers != null && numbers.Count == 2)
{
    QuarterSearch(numbers[0], numbers[1]);
}
else
{
    Console.WriteLine("Ошибка: Введите два числа, разделенных запятой.");
}