// See https://aka.ms/new-console-template for more information
Console.Write("Введите a: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите b: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите c: ");
int c = int.Parse(Console.ReadLine());

int max;

if (a >= b && a >= c) {
  max = a;
} else if (b >= a && b >= c) {
  max = b;
} else {
  max = c;
}

Console.WriteLine("Максимальное число:" + max);
