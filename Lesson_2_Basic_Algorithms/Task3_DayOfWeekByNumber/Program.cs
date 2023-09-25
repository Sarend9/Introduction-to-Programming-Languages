/* 
Задача 3:
    Напишите программу, которая будет выдавать название
    дня недели по заданному номеру.
    
    Пример:
    5 -> Среда
    3 -> Пятница
 */

Console.Clear();

string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

Console.Write("Введите номер дня недели (от 1 до 7): ");

int number = int.Parse(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    string dayOfWeek = daysOfWeek[number - 1];
    Console.WriteLine($"День недели под номером {number} - это {dayOfWeek}");
}
else
{
    Console.WriteLine("Некорректный ввод. Введите целое число от 1 до 7.");
}
