using System;
using System.Linq;
using System.Xml.XPath;


public class Answer
{
    /// <summary>
    /// Метод выполняет парсинг входной строки, извлекает координаты и фильтрует их.
    /// </summary>
    /// <remarks>
    /// Входная строка должна быть в формате "(x1,y1) (x2,y2) ... (xn,yn)".
    /// Координаты извлекаются из строки и фильтруются по следующему условию: остаются только точки с четными x-координатами.
    /// Затем x-координаты умножаются на 10.
    /// </remarks>
    public static void ParseAndFilterCoordinates()
    {
        string text = "(1,2) (2,3) (4,5) (6,7)"
                        .Replace("(", "") //заменям скобку на пустую строку
                        .Replace(")", "");

        Console.WriteLine(text);

        var data = text.Split(" ")
                       .Select(item => item.Split(','))
                       .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
                       .Where(e => e.x % 2 == 0)
                       .Select(point => (point.x * 10, point.y))
                       .ToArray();

        for (int i = 0; i < data.Length; i++)
            Console.WriteLine(data[i]);

        Console.WriteLine();
    }


    public static string NumbersFor(int a, int b)
    {
        string result = String.Empty;
        for (int i = a; i <= b; i++)
        {
            result += $"{i} ";
        }
        return result;
    }

    public static string NumbersRec(int a, int b)
    {
        if (a < b) return $"{a} {NumbersRec(a + 1, b)}";
        else return $"{b}";
    }

    public static int PowerFor(int a, int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++) result *= a;
        return result;
    }

    public static int PowerRec(int a, int n)
    {
        return n == 0 ? 1 : PowerRec(a, n - 1) * a;
        // if (n == 0) return 1;
        // else return PowerRec(a, n - 1) * a;
    }

    // работает быстрее, чем PowerFor и PowerRec
    public static int PowerRecMath(int a, int n)
    {
        if (n == 0) return 1;
        else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
        else return PowerRecMath(a, n - 1) * a;
    }


    public static void CatalogInfo(string path, string indent = "")
    {
        DirectoryInfo catalogs = new DirectoryInfo(path);
        foreach (var currentCatalog in catalogs.GetDirectories())
        {
            Console.WriteLine($"{indent}{currentCatalog.Name}");
            CatalogInfo(currentCatalog.FullName, indent + " ");
        }
        foreach (var item in catalogs.GetFiles())
        {
            Console.WriteLine($"{indent}{item.Name}");
        }
    }

    public static void InOrderTraversal(string[] tree, int pos = 1)
    {
        if (pos < tree.Length)
        {
            int left = 2 * pos;
            int right = 2 * pos + 1;

            if (left < tree.Length && !String.IsNullOrEmpty(tree[left]))
                InOrderTraversal(tree, left);

            Console.WriteLine(tree[pos]);
            if (right < tree.Length && !String.IsNullOrEmpty(tree[right]))
                InOrderTraversal(tree, right);
        }
    }


    static public void Main(string[] args)
    {
        // ParseAndFilterCoordinates();

        // Console.WriteLine(NumbersFor(1, 10));
        // Console.WriteLine(NumbersRec(1, 10));

        // Console.WriteLine(PowerFor(2, 10));
        // Console.WriteLine(PowerRec(2, 10));
        // Console.WriteLine(PowerRecMath(2, 10));

        // string path = @"/Users/Projects/HelloCode";
        // CatalogInfo(path);

        string emp = String.Empty;
        string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
        InOrderTraversal(tree);

    }
}