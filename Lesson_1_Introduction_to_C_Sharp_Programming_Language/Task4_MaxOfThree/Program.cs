// See https://aka.ms/new-console-template for more information
/* 
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
 */
 
int a = InputNumber("Введите a: ");
int b = InputNumber("Введите b: ");
int c = InputNumber("Введите c: ");

int max = FindMax(a, b, c);

Console.WriteLine("Максимальное число: " + max);

static int InputNumber(string message)
{
  Console.Write(message);
  return int.Parse(Console.ReadLine());
}

static int FindMax(int a, int b, int c)
{
  int max = a;
  if (b > max)
  {
    max = b;
  }
  if (c > max)
  {
    max = c;
  }
  return max;
}
