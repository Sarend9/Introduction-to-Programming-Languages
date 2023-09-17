// See https://aka.ms/new-console-template for more information

/* 
Задача 43:
    Напишите программу, которая найдёт точку пересечения 
    двух прямых, заданных уравнениями 
    
    y = k1 * x + b1, 
    y = k2 * x + b2; 

    значения b1, k1, b2 и k2 задаются пользователем.

    b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

 */



using System.Globalization;


static void GetParameters(double[] k, double[] b)
{
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"* Введите параметры для прямой y = k{i + 1}*x + b{i + 1}:");
        Console.Write($"* Введите k{i + 1}: ");
        k[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write($"* Введите b{i + 1}: ");
        //                                      CultureInfo.InvariantCulture - использует точку как разделитель десятичных знаков.
        b[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    }
}

static void FindIntersection(double k1, double b1, double k2, double b2)
{
    if (k1 == k2)
    {
        Console.WriteLine("* Прямые параллельны и не пересекаются.");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine($"* Точка пересечения: ({x.ToString(CultureInfo.InvariantCulture)}, {y.ToString(CultureInfo.InvariantCulture)})");
    }
}

double[] k = new double[2];
double[] b = new double[2];

GetParameters(k, b);
FindIntersection(k[0], b[0], k[1], b[1]);

