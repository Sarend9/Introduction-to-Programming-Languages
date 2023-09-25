/* 
Задача 1:
    Напишите программу, которая на вход принимает число 
    и выдает его квадрат (число, умноженное на само себя).
    Пример:
      4 -> 16
     -3 -> 9
     -7 -> 49 
*/

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Квадрат числа: " + (number * number));
