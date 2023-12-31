## Описание кода

Этот репозиторий содержит C# код для работы с целочисленными массивами. Код включает в себя класс `IntArrayProcessor`, который предоставляет функции для ввода и вывода целочисленных массивов в консольном приложении.

## Содержание

1. [Как работает класс `IntArrayProcessor`](#как-работает-класс-intarrayprocessor)
    - [Метод `PrintIntArray`](#метод-printintarray)
    - [Метод ReadIntArray](#метод-readintarray)


## Как работает класс `IntArrayProcessor`

Класс `IntArrayProcessor` предоставляет два статических метода: `PrintIntArray` и `ReadIntArray`, для работы с целочисленными массивами.

### Метод `PrintIntArray`

```csharp
public static void PrintIntArray(int[] arr)
```

Метод `PrintIntArray` принимает массив целых чисел `arr` в качестве аргумента и выводит его содержимое в консоль. Если массив пуст (равен `null`), то выводится сообщение "Массив пуст." В противном случае, элементы массива выводятся в виде строки, разделенной запятыми, например: "Массив: [1, 2, 3, 4]".

#### Пример использования:

```csharp
int[] arr = { 1, 2, 3, 4 };
IntArrayProcessor.PrintIntArray(arr);
```

Вывод в консоль:

```
Массив: [1, 2, 3, 4]
```

### Метод `ReadIntArray`

```csharp
public static int[] ReadIntArray(int maxLength)
```

Метод `ReadIntArray` принимает аргумент `maxLength`, который определяет максимальное количество чисел, которое пользователь может ввести. Метод запрашивает ввод чисел от пользователя через консоль и разбивает введенную строку на числа. Если количество введенных чисел превышает `maxLength`, то выводится сообщение об ошибке, и метод возвращает `null`.

Если введенные строки не являются целыми числами, то также выводится сообщение об ошибке, и метод возвращает `null`.

В случае успешного ввода и преобразования строк в целые числа, метод создает и возвращает массив целых чисел, содержащий введенные значения.

#### Пример использования:

```csharp
int[] arr = IntArrayProcessor.ReadIntArray(5);
IntArrayProcessor.PrintIntArray(arr);
```

Пользователь вводит числа через консоль, например: "1 2 3 4 5".

Вывод в консоль:

```
Массив: [1, 2, 3, 4, 5]
```

Если пользователь введет неправильные данные, такие как "abc def", метод `ReadIntArray` вернет `null`, и соответствующее сообщение об ошибке будет выведено в консоль.

### Объявление методов как `public` и `static`

- `public` означает, что методы могут быть вызваны из других классов или частей программы. Это делает методы `PrintIntArray` и `ReadIntArray` доступными для использования в других частях кода.

- `static` означает, что методы принадлежат классу `IntArrayProcessor`, а не экземпляру класса. Таким образом, они могут быть вызваны без создания объекта класса `IntArrayProcessor`, что упрощает их использование.