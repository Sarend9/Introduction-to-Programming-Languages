// See https://aka.ms/new-console-template for more information

// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным

Console.Write("Введите цифру, обозначающую день недели: ");
if (!int.TryParse(Console.ReadLine(), out int day))
{
    Console.WriteLine("Ошибка: Вы ввели некорректное значение.");
    return;
}

if (day >= 1 && day <= 5)
{
    Console.WriteLine("Нет, это не выходной день.");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("Да, это выходной день.");
}
else
{
    Console.WriteLine("Вы ввели несуществующий день недели.");
}

