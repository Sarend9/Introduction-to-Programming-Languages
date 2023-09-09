// See https://aka.ms/new-console-template for more information

// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Ошибка: Введенное значение не является целым числом типа int.");
    return;
}

string numberStr = number.ToString();

if (numberStr.Length >= 3)
{
    Console.WriteLine($"Третья цифра: {numberStr[2]}");
}
else
{
    Console.WriteLine("Третьей цифры в числе нет.");
}



