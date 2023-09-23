using System;

public class MyClass
{
    private int privateField; // Приватная переменная
    public int publicField; // Публичная переменная

    private int PrivateMethod()
    {
        return privateField * 2;
    }

    public void SetPrivateField(int value)
    {
        privateField = value;
    }

    public int CalculateUsingPrivateMethod()
    {
        return PrivateMethod();
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }

    public static int AddWithPrivateField(int a, int b, MyClass instance)
    {
        instance.SetPrivateField(a);
        return a + b + instance.PrivateMethod();
    }
}

public static class MathHelper
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        MyClass obj = new MyClass();

        obj.SetPrivateField(5);

        int result1 = obj.CalculateUsingPrivateMethod();
        Console.WriteLine("Результат вызова CalculateUsingPrivateMethod: " + result1);

        int sum = MyClass.Add(10, 20);
        int difference = MyClass.Subtract(30, 15);
        int product = MathHelper.Multiply(5, 6);
        int sumWithPrivateField = MyClass.AddWithPrivateField(10, 20, obj);

        Console.WriteLine("Сумма: " + sum);
        Console.WriteLine("Разница: " + difference);
        Console.WriteLine("Произведение: " + product);
        Console.WriteLine("Сумма с privateField: " + sumWithPrivateField);

        // Доступ к публичной переменной
        obj.publicField = 42;
        Console.WriteLine("publicField: " + obj.publicField);
    }
}
