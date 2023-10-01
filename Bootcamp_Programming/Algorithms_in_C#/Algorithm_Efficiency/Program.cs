public class Answer
{
    public static void InputArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            array[i] = new Random().Next(-30, 30 + 1);
    }

    static int[] GenerateRandomArray(int n, int max)
    {
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
            array[i] = Random.Shared.Next(max);

        return array;
    }




    // Задача 1: Вычисление суммы чисел от 1 до n
    // Данный код выполняет два типа алгоритмов: линейный и константный.

    // Предпочтительно использовать int.Parse(Console.ReadLine()) вместо Convert.ToInt32(Console.ReadLine()), так как Parse работает быстрее.
    // Функция для вычисления суммы чисел от 1 до n (линейный алгоритм)
    public static void CalculateSum()
    {
        Console.Write("* Введите число: ");
        int n1 = int.Parse(Console.ReadLine()!);
        int result1 = 0;
        for (int i = 1; i <= n1; i++) // Линейный алгоритм: O(n)
        {
            result1 += i;
        }

        Console.WriteLine($"* Сумма чисел от 1 до {n1} равна: {result1} ");
    }

    // Константный алгоритм: O(1)
    // Функция для вычисления суммы чисел от 1 до n с использованием формулы (константный алгоритм)
    public static void CalculateSumWithFormula()
    {
        Console.Write("* Введите число: ");
        int n2 = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"* Сумма чисел от 1 до {n2} равна {(1 + n2) / 2.0 * n2}");
    }



    // Сложность алгоритма O(1) (O нотация), 
    // где 1 - сколько действий выполнили,
    // чтобы узнать конечный результат.
    // Функция для ввода массива и доступа к элементу по индексу
    public static void InputArrayAndAccessElement()
    {
        int n3 = 5;
        int[] array = new int[5];
        for (int i = 0; i < n3; i++)
        {
            Console.Write($"* Введите {i + 1} число массива: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("* [" + string.Join(", ", array) + "]");
        Console.WriteLine(array[3]);
    }


    // В данном примере выполнили 1 действие, 
    // чтобы узнать число под номером 3.
    // Это и есть сложность алгоритма (О нотация)

    // Таблица умножения:
    public static void MultiplicationTable()
    {
        Console.Write("* Введите размер таблицы умножения: ");
        int n4 = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n4; i++)
        {
            for (int j = 1; j <= n4; j++)
            {
                Console.Write($"{i * j}\t");
            }
            Console.WriteLine();
        }
    }


    // Как сократить такую операцию? Нужно убрать повторы.
    // Если разделим по диагонале таблицу, то элементы будут смежными:
    // 1       2       3       4       5 
    // 2       4       6       8       10
    // 3       6       9       12      15
    // 4       8       12      16      20
    // 5       10      15      20      25
    // И нам достаточно узнать первую половину

    // Используем матрицу:
    // Сложность такого алгоритма O(n^2/2)
    public static void MultiplicationМatrix()
    {
        Console.Write("* Введите размер матрицы умножения: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = (i + 1) * (j + 1);
                matrix[j, i] = (i + 1) * (j + 1);
                // Thread.Sleep(2000);
                // Console.WriteLine($"matrix[{i}, {j}] = {matrix[i, j]}");
                // Console.WriteLine($"matrix[{j}, {i}] = {matrix[j, i]}");
                // Console.WriteLine();
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j]);
                Console.Write("\t");
            }
            Console.WriteLine();
        }
    }

    // Сортировка Выбором O(n^2)

    /* 
    [45, 23, -10, 5, 3, 9, 1]
    min = -10;
    [-10, 23, 45, 5, 3, 9, 1] //теперь ищем с 1 индекса и делаем замену:
    min = 1
    [-10, 1, 45, 5, 3, 9, 23]
    min = 3
    [-10, 1, 3, 5, 45, 9, 23]
    min = 5 //номер совпал и менять не надо
    [-10, 1, 3, 5, 45, 9, 23]
    min = 9
    [-10, 1, 3, 5, 9, 45, 23]
    min = 23
    [-10, 1, 3, 5, 9, 23, 45] //последний элемент не имеет смысла менять
     */
    public static int[] SelectionSort(int[] array)
    {
        //Стандарт счетчиков i, j, k, m, n
        for (int i = 0; i < array.Length; i++)
        {
            int indexMin = i;
            for (int j = i; j < array.Length; j++)
            {
                if (array[j] < array[indexMin])
                {
                    indexMin = j;
                }
            }
            if (array[indexMin] == array[i])
                continue; //переход к следующей итерации цикла

            (array[i], array[indexMin]) = (array[indexMin], array[i]);
        }
        return array;
    }

    /// <summary>
    /// Сортировка Пузырьком O((n-1)^2)
    /// </summary>
    /// <param name="arr"></param>
    public static void BubbleSort(int[] arr)
    {
        for (int k = 0; k < arr.Length - 1; k++)
        {
            for (int i = 0; i < arr.Length - 1 - k; i++)
            {
                if (arr[i] > arr[i + 1])
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
            }
        }
    }

    /// <summary>
    ///  Быстрая сортировка O(n * log2 n)
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    // [7, 4, 1, 3, 5, 2, 6]
    // опорный элемент = 7
    // [4, 1, 3, 5, 2, 6] + [7] + []
    // опорный элемент = 4
    // [1, 3, 2] + [4] + [5, 6]
    // опорный элемент = 5
    // [] + [5] + [6]
    // опорный элемент = 3
    // [2] + [3] + []
    static int[] QuickSort(int[] arr, int left, int right)
    {
        int i = left, j = right, pivot = arr[left];
        while (i <= j)
        {
            while (arr[i] < pivot) i++;

            while (arr[j] > pivot) j--;

            if (i <= j)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
                i++;
                j--;
            }
        }
        if (left < j) QuickSort(arr, left, j);

        if (i < right) QuickSort(arr, i, right);

        return arr;
    }


    //сортировка подсчетом
    public static int[] CountingSortExtended(int[] inputArray)
    {
        int max = inputArray.Max();
        int min = inputArray.Min();

        int offset = -min;
        int[] sortedArray = new int[inputArray.Length];
        int[] counters = new int[max + offset + 1];



        for (int i = 0; i < inputArray.Length; i++)
        {
            counters[inputArray[i] + offset]++;
        }

        //Console.WriteLine($"[{String.Join(',', counters)}]");

        int index = 0;
        for (int i = 0; i < counters.Length; i++)
        {
            for (int j = 0; j < counters[i]; j++)
            {
                sortedArray[index] = i - offset;
                index++;
            }
        }

        return sortedArray;
    }

    public static void PrepareParallelCountingSort(int[] inputArray, int THREADS_NUMBER, object lock_object)
    {
        int max = inputArray.Max();
        int min = inputArray.Min();

        int offset = -min;
        int[] counters = new int[max + offset + 1];

        int eachThreadCalc = inputArray.Length / THREADS_NUMBER;
        var threadsParall = new List<Thread>();

        for (int i = 0; i < THREADS_NUMBER; i++)
        {
            int startPos = i * eachThreadCalc;
            int endPos = (i + 1) * eachThreadCalc;
            if (i == THREADS_NUMBER - 1) endPos = inputArray.Length;
            threadsParall.Add(new Thread(() => CountingSortParallel(inputArray, counters, offset, startPos, endPos, lock_object)));
            threadsParall[i].Start();
        }

        foreach (var thread in threadsParall)
        {
            thread.Join();
        }

        int index = 0;
        for (int i = 0; i < counters.Length; i++)
        {
            for (int j = 0; j < counters[i]; j++)
            {
                inputArray[index] = i - offset;
                index++;
            }
        }
    }
    public static void CountingSortParallel(int[] inputArray, int[] counters, int offset, int startPos, int endPos, object lock_object)
    {
        for (int i = startPos; i < endPos; i++)
        {
            lock (lock_object)
            {
                counters[inputArray[i] + offset]++;
            }
        }
    }

    /// <summary>
    /// Сравнение матриц
    /// </summary>
    /// <param name="fmatrix"></param>
    /// <param name="smatrix"></param>
    /// <returns></returns>
    public static bool EqualityMatrix(int[] fmatrix, int[] smatrix)
    {
        bool res = true;

        for (int i = 0; i < fmatrix.Length; i++)
        {
            res = res && (fmatrix[i] == smatrix[i]);
        }

        return res;
    }


    public static void Main(string[] args)
    {
        Console.Clear();

        //  Console.Write("* Задача 1: Вычисление суммы чисел от 1 до n *\n");
        //  CalculateSum();

        // Console.Write("* Задача 2: Вычисление суммы чисел от 1 до n с использованием формулы *\n");
        // CalculateSumWithFormula();

        // Console.Write("* Задача 3: Ввод массива и доступ к элементу по индексу *\n");
        // InputArrayAndAccessElement();

        // Console.Write("* Задача 4: Таблица умножения *\n");
        // MultiplicationTable();
        // Сложность такого алгоритма O(n^2)

        // Console.Write("* Задача 5: Матрица умножения *\n");
        // MultiplicationМatrix();

        // Бинарный поиск O(log2 n)
        // Код для бинарного поиска 

        // Console.WriteLine("* Задача 6: Сортировка Выбором O(n^2)");
        // Console.Write("Введите кол-во элементов массива: ");
        // int n = int.Parse(Console.ReadLine()!);
        // int[] array = new int[n];
        // InputArray(array);
        // Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
        // Console.WriteLine($"Отсортир массив: [{string.Join(", ", SelectionSort(array))}]");

        // Console.WriteLine($"* Задача 7: Сортировка пузырьком O((n-1)^2)");
        // Console.Write("Введите кол-во элементов массива: ");
        // int n = int.Parse(Console.ReadLine()!);
        // int[] array = GenerateRandomArray(n, 100);
        // InputArray(array);
        // Console.WriteLine($"Исходный массив: [{String.Join(',', array)}]");
        // BubbleSort(array);
        // Console.WriteLine($"Отсортир массив: [{String.Join(',', array)}]");

        // Console.WriteLine($"* Задача 8: Быстрая сортировка O(n * log2 n)");
        // Console.Write("Введите 2 числа: ");
        // int[] numbers = Console.ReadLine()!
        //                        .Split()
        //                        .Select(x => int.Parse(x))
        //                        .ToArray();

        // int[] array = GenerateRandomArray(numbers[0], numbers[1]);
        // Console.WriteLine($"Исходный массив: [{String.Join(',', array)}]");
        // QuickSort(array, 0, array.Length - 1);
        // Console.WriteLine($"Отсортир массив: [{String.Join(',', array)}]");


        // Console.WriteLine($"* Задача 9.1: Сортировка подсчетом");
        // int[] array = { -10, -5, -9, 0, 2, 5, 1, 3, 1, 0, 1 };
        // int[] sortedArray = CountingSortExtended(array);

        // Console.WriteLine($"Исходный массив: [{String.Join(',', array)}]");
        // Console.WriteLine($"Отсортир массив: [{String.Join(',', sortedArray)}]");


        Console.WriteLine($"* Задача 9.2: Сортировка подсчетом в потоке");
        const int THREAFS_NUMBER = 4; // число потоков
        const int N = 15;
        object lock_object = new object();
        // int[] array = { -10, -5, -9, 0, 2, 5, 1, 3, 1, 0, 1 };

        int[] resSerial = new int[N].Select(r => new Random().Next(0, 10)).ToArray();
        int[] resParallel = new int[N];
        Array.Copy(resSerial, resParallel, N);

        Console.WriteLine($"Исходный массив: [{String.Join(',', resSerial)}]");
        PrepareParallelCountingSort(resSerial, THREAFS_NUMBER, lock_object);
        Console.WriteLine($"Отсортир массив: [{String.Join(',', resSerial)}]");


    }

}