// See https://aka.ms/new-console-template for more information

/* Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом. */
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
if (number.ToString().Length > 5)
{
    Console.WriteLine("Ошибка: введите пятизначное число");
}

IsPalindrome(number);

void IsPalindrome(int number)
{
    int reverse = 0;
    int temp = number;

    for (int i = 0; i < 5; i++)
    {
        reverse = reverse * 10 + temp % 10;
        temp /= 10;
    }
    if (reverse == number)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
