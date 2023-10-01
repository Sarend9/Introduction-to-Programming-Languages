/* 
Задача 67: 
    Напишите программу, которая будет принимать 
    на вход число и возвращать сумму его цифр.
    453 -> 12
    45 -> 9
*/

public class Answer
{
    static int SumOfDigits(int num)
    {
        if (num == 0) return 0;
        else return num % 10 + SumOfDigits(num / 10);
    }


    static public void Main(string[] args)
    {
        Console.Clear();

        int N = 4;

        Console.WriteLine(SumOfDigits(N));

    }
}
