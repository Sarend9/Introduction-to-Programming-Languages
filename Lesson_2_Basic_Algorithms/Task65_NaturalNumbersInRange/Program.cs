/* 
    Задача 65: Задайте значения M и N. 
    Напишите программу, которая выведет все 
    натуральные числа в промежутке от M до N.

    M = 1; N = 5 -> "1, 2, 3, 4, 5"
    M = 4; N = 8 -> "4, 6, 7, 8"
 */

public class Answer
{
    static string ShowNumbers(int M, int N)
    {
        if (M <= N) return $"{M} " + ShowNumbers(M + 1, N);
        else return string.Empty;
    }

    static void GenerateNumbers(int start, int end)
    {
        if (start > end)
        {
            return;
        }

        Console.Write(start + ", ");
        GenerateNumbers(start + 1, end);
    }


    static public void Main(string[] args)
    {
        Console.Clear();

        int M = 3;
        int N = 7;
        GenerateNumbers(M, N);

    }
}
