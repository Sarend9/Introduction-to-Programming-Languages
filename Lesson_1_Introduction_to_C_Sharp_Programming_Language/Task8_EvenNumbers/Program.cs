// See https://aka.ms/new-console-template for more information
Console.Write("Введите число (N): ");
int N = int.Parse(Console.ReadLine());

Console.Write("Чётные числа от 1 до N: ");
for (int i = 2; i <= N; i += 2) {
  Console.Write(i + ", ");
}
Console.WriteLine();
