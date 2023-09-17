// See https://aka.ms/new-console-template for more information
Console.Clear();
/* 
Задача 42: 
    Напишите программу, которая будет преобразовывать
    десятичное число в двоичное.
    45 -> 101101
    3 -> 11
    2 -> 10
 */

static int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int DecimalToBinary1(int num)
{
    int binary = 0;
    int count = 1;
    while (num >= 1)
    {
        binary = binary + num % 2 * count;
        count *= 10;
        num /= 2;
    }
    return binary;
}

string DecimalToBinary2(int num)
{
    string binary = string.Empty;
    while (num >= 1)
    {
        binary = num % 2 + binary;
        num /= 2;
    }
    return binary;
}

int number = WorkWithUser("Введите десятичное число: ");
Console.WriteLine(DecimalToBinary1(number));
Console.WriteLine(DecimalToBinary2(number));
Console.WriteLine(Convert.ToString(number, 2));