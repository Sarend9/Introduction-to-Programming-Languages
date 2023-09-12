// See https://aka.ms/new-console-template for more information

/* 
Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
 */


int[] arr = IntArrayProcessor.ReadIntArray(8);
IntArrayProcessor.PrintIntArray(arr);

public class IntArrayProcessor
{
    public static void PrintIntArray(int[] arr)
    {
        if (arr == null)
        {
            Console.WriteLine("Массив пуст.");
        }
        else
        {
            Console.WriteLine("Массив: [" + string.Join(", ", arr) + "]");
        }
    }

    public static int[] ReadIntArray(int maxLength)
    {
        Console.WriteLine($"Введите числа (максимум {maxLength}) через пробел:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        if (inputArray.Length > maxLength)
        {
            Console.WriteLine($"Вы ввели больше {maxLength} чисел. Введите не более {maxLength} чисел.");
            return null;
        }

        int[] arr = new int[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (!int.TryParse(inputArray[i], out arr[i]))
            {
                Console.WriteLine($"Ошибка ввода. \"{inputArray[i]}\" не является целым числом.");
                return null;
            }
        }

        return arr;
    }
}