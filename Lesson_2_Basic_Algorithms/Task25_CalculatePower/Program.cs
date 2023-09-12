// See https://aka.ms/new-console-template for more information

/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

static List<double> Prompt(string prompt)
{
    Console.Write(prompt);
    string? input = Console.ReadLine();

    if (input == null)
    {
        Console.WriteLine("Ошибка: Введите корректные числа, разделенные запятой.");
        Environment.Exit(0);
    }

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


List<double> numbers = Prompt("Введите число A и степень B: ");
if (numbers == null || numbers.Count != 2)
{
    Console.WriteLine("Ошибка: Введите два числа");
    return;
}
if (numbers[1] % 1 != 0)
{
    Console.WriteLine("Ошибка: степень не целочисленная");
    return;
}

CalculatePower(numbers[0], (int)numbers[1]);

static void CalculatePower(double A, int B)
{
    double result = 1;
    bool negativeExponent = B < 0;

    for (int i = 0; i < Math.Abs(B); i++)
    {
        result *= A;
    }

    if (negativeExponent)
    {
        result = 1 / result;
    }
    Console.WriteLine(result);

    // или Console.WriteLine(Math.Pow(A, B));
}