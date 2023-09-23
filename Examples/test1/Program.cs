using System.Linq;
Console.Clear();

void Method(int maximum)
{
    int minimum = -maximum;
    while (minimum <= maximum)
    {
        Console.Write(minimum + " ");
        minimum++;
    }
}

int[] CreateArray(int N)
{
    int[] arrayA = new int[N * 2 + 1];
    for (int i = -N; i <= N; i++)
    {
        arrayA[i + N] = i;
    }
    return arrayA;
}

int Ar(int N)
{
    int x = -N;
    while (x <= N)
    {
        Console.Write(x + " ");
        x++;
    }
    return x;
}

void Numbers(int n)
{
    int length = n + n;
    for (int i = 0; i < length + 1; i++)
    {
        Console.Write(-n + i + " ");
    }
}

string ShowNums(int N)
{
    string NumsShow = "";
    for (int i = -N; i < N; i++)
    {
        NumsShow = NumsShow + i + " ";
    }
    return NumsShow;
}

Method(9);
int[] array = CreateArray(9);
Console.WriteLine();
Console.WriteLine(string.Join(" ", array));
Ar(9);
Console.WriteLine();
Numbers(9);
Console.WriteLine();
Console.WriteLine(ShowNums(9));
Console.WriteLine();

// Какое решение лучше?

// Отдельнное решение:
int af = -5;
int uf = 5;
Console.WriteLine($"{af} .. {uf}");


bool IsEven1(int value)
{
    return value % 2 == 0;
}

bool IsEven2(int value) => value % 2 == 0;

var IsEven3 = (int v) => v % 2 == 0;

Console.WriteLine(IsEven1(10));
Console.WriteLine(IsEven2(10));
Console.WriteLine(IsEven3(10));

Console.WriteLine(IsEven1(10).GetType().Name);
Console.WriteLine(IsEven2(10).GetType().Name);
Console.WriteLine(IsEven3.GetType().Name);
Console.WriteLine();



var data = new int[] { 1, 2, 3, 4 }
         .Where(e => e > 0)
         .Select(e => new { q = e, w = e + 1 });

Console.WriteLine(data.GetType().Name);
Console.WriteLine(string.Join(", ", data));