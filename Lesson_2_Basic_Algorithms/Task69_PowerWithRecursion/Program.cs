/* 
Задача 69: 
    Напишите программу, которая на вход принимает два числа A и B, 
    и возводит число А в целую степень B с помощью рекурсии.
    A = 3; B = 5 -> 243 (3⁵)
    A = 2; B = 3 -> 8
 */

public class Answer
{
    static int PowerWithRecursion(int A, int B)
    {
        if (B == 0)
            return 1;

        return A * PowerWithRecursion(A, B - 1);
    }


    static public void Main(string[] args)
    {
        Console.Clear();

        int A = 3;
        int B = 5;
        Console.WriteLine(PowerWithRecursion(A, B));

    }
}
