using System.Text;


// Первая группа методов — не принимает никаких аргументов 
// и ничего не возвращают.
void Metod1()
{
    Console.WriteLine("Метод_1");
}

Metod1();
Console.WriteLine();

// Вторая группа методов — принимает 
// какие-то аргументы, но ничего не возвращают.
void Metod2(string msg)
{
    Console.WriteLine(msg);
}

Metod2("Метод_2");
Console.WriteLine();

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Metod21("Метод_2.1", 4);
Console.WriteLine();

// Третья группа методов — может что-то возвращать, но не принимает никаких
// аргументов. Например, может служить для генерации случайных данных.
int Metod3()
{
    return DateTime.Now.Year;
}

int year = Metod3();
Console.WriteLine($"Метод_3: {year}");

// Четвёртая группа методов — что-то принимает (аргументы, данные). И что-то
// возвращает для дальнейшей работы.
string Metod4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}

string res1 = Metod4(10, "asdf_");
Console.WriteLine(res1);

// Цикл for
Console.WriteLine("Таблица умножения от 2 до 10:");
Console.WriteLine();
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        int result = i * j;
        Console.WriteLine($"{i} x {j} = {result}");
    }
    Console.WriteLine();
}

//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, " +
              "ежели бы вас послали вместо нашего милого Винценгероде, " +
              "вы бы взяли приступом согласие прусского короля. " +
              "Вы так красноречивы. Вы дадите мне чаю?";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}

string newText = Replase(text, ' ', '|');
Console.WriteLine(newText); Console.WriteLine();

// Упорядочить массивы
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PtintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void selectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        (array[minPosition], array[i]) = (array[i], array[minPosition]);
    }
}


PtintArray(arr);
selectionSort(arr);
PtintArray(arr); Console.WriteLine();

//.................................
static string AddRandomCharacters(string inputString, int numberOfCharacters)
{
    Random random = new Random();
    StringBuilder result = new StringBuilder(inputString);

    for (int i = 0; i < numberOfCharacters; i++)
    {
        char randomChar = (char)random.Next('a', 'z' + 1); //случайный символ от 'a' до 'z'
        result.Append(randomChar);
    }

    return result.ToString();
}

string emptyString = "";
int numberOfRandomCharacters = 10; // желаемое количество случайных символов
string stringWithRandomCharacters = AddRandomCharacters(emptyString, numberOfRandomCharacters);
Console.WriteLine(stringWithRandomCharacters);
Console.WriteLine(emptyString);


