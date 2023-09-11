// See https://aka.ms/new-console-template for more information

// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает
// диапазон возможных координат точек в этой
// четверти (x и y).

Console.Write("Введите номер четверти: ");
int quadrant = int.Parse(Console.ReadLine());

FirstMethod(quadrant);
SecondMethod(quadrant);

static void FirstMethod(int quadrant)
{
    Console.WriteLine("Первый способ: ");
    if (quadrant >= 1 && quadrant <= 4)
    {
        string coordinate_range = (quadrant == 1) ? "x: (0 до +∞); y: (0 до +∞);"
                            : (quadrant == 2) ? "x: (-∞ до 0); y: (0 до +∞);"
                            : (quadrant == 3) ? "x: (-∞ до 0); y: (-∞ до 0);"
                            : "x: (0 до +∞); y: (-∞ до 0);";
        Console.WriteLine(coordinate_range);
    }
    else
    {
        Console.WriteLine("Некорректный номер четверти. Введите число от 1 до 4.");
    }
}

static void SecondMethod(int quadrant)
{
    Console.WriteLine("Второй способ: ");
    if (quadrant >= 1 && quadrant <= 4)
    {
        switch (quadrant)
        {
            case 1:
                Console.WriteLine("Диапазон координат в 1-й четверти:");
                Console.WriteLine("x: (0, +∞)");
                Console.WriteLine("y: (0, +∞)");
                break;
            case 2:
                Console.WriteLine("Диапазон координат в 2-й четверти:");
                Console.WriteLine("x: (-∞, 0)");
                Console.WriteLine("y: (0, +∞)");
                break;
            case 3:
                Console.WriteLine("Диапазон координат в 3-й четверти:");
                Console.WriteLine("x: (-∞, 0)");
                Console.WriteLine("y: (-∞, 0)");
                break;
            case 4:
                Console.WriteLine("Диапазон координат в 4-й четверти:");
                Console.WriteLine("x: (0, +∞)");
                Console.WriteLine("y: (-∞, 0)");
                break;
        }
    }
    else
    {
        Console.WriteLine("Некорректный номер четверти. Введите число от 1 до 4.");
    }
}
