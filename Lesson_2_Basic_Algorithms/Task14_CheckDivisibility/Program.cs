/* 
   Задача 14. Напишите программу, которая принимает на
   вход число и проверяет, кратно ли оно
   одновременно 7 и 23.

   Пример:
   14 -> нет
   46 -> нет
   161 -> да
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

bool isDivisibleBy7 = (number % 7 == 0);
bool isDivisibleBy23 = (number % 23 == 0);

if (isDivisibleBy7 && isDivisibleBy23)
{
    Console.WriteLine("Да, число кратно и 7, и 23.");
}
else
{
    Console.WriteLine("Нет, число не кратно одновременно 7 и 23.");
}