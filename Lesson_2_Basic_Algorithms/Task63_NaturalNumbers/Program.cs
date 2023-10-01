/* 
Задача 63: 
    Задайте значение N. Напишите программу, 
    которая выведет все натуральные числа в промежутке от 1 до N.

    N = 5 -> "1, 2, 3, 4, 5"
    N = 6 -> "1, 2, 3, 4, 5, 6"
*/

using System;

public class Answer
{
    public static string GenerateNaturalNumbers(int n)
    {
        if (n == 1)
        {
            return "1";
        }
        else
        {
            string previousNumbers = GenerateNaturalNumbers(n - 1);
            return previousNumbers + ", " + n;
        }
    }


    static public void Main(string[] args)
    {
        Console.Clear();

        int n = int.Parse(Console.ReadLine());
        string result = GenerateNaturalNumbers(n);
        Console.WriteLine(result);

    }
}














