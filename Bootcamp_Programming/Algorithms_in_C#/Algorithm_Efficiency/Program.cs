// Задача 1: Вычисление суммы чисел от 1 до n
// Данный код выполняет два типа алгоритмов: линейный и константный.

Console.Clear();

// Предпочтительно использовать int.Parse(Console.ReadLine()) вместо Convert.ToInt32(Console.ReadLine()), так как Parse работает быстрее.
Console.Write("* Введите число: ");
int n1 = int.Parse(Console.ReadLine()!);
int result1 = 0;
for (int i = 1; i <= n1; i++) // Линейный алгоритм: O(n)
{
    result1 += i;
}

Console.WriteLine($"* Сумма чисел от 1 до {n1} равна: {result1} ");

// Константный алгоритм: O(1)
Console.Write("* Введите число: ");
int n2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"* Сумма чисел от 1 до {n2} равна {(1 + n2) / 2.0 * n2}");

// Бинарный поиск (O(log2(n)))
// Код для бинарного поиска 

// Быстрая сортировка (O(n * log2(n)))
// Код для быстрой сортировки 
