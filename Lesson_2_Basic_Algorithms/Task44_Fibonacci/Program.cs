// See https://aka.ms/new-console-template for more information
Console.Clear();
/*
Задача 44: 
    Не используя рекурсию, выведите первые N чисел
    Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
    Если N = 5 -> 0 1 1 2 3
    Если N = 3 -> 0 1 1
    Если N = 7 -> 0 1 1 2 3 5 8 
*/

static int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int[] CalculateFibonacciSequence(int n)
{
    int[] sequence = new int[n];
    sequence[0] = 0;
    sequence[1] = 1;
    for (int i = 2; i < n; i++)
    {
        sequence[i] = sequence[i - 1] + sequence[i - 2];
    }
    return sequence;
}

int number = WorkWithUser("* Введите число: ");
Console.WriteLine($"* f({number}) = {string.Join(" ", CalculateFibonacciSequence(number))}");