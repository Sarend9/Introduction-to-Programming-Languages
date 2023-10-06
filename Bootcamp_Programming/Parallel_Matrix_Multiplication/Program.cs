const int N = 1000; //размер матрицы
const int THREADS_NUMBER = 10;

int[,] serialMulRes = new int[N, N];
int[,] threadMulRes = new int[N, N];

int[,] firstMatrix = MatrixGenerator(N, N);
int[,] secondMatrix = MatrixGenerator(N, N);

SerialMulRes(firstMatrix, secondMatrix);
PrepareParallelMatrixMul(firstMatrix, secondMatrix);
Console.WriteLine(EqualityMatrix(serialMulRes, threadMulRes));


static int[,] MatrixGenerator(int rows, int columns)
{
    Random _rand = new Random();
    int[,] res = new int[rows, columns];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = _rand.Next(-100, 100 + 1);
        }
    }
    return res;
}


void SerialMulRes(int[,] a, int[,] b)
{
    int numRows1 = a.GetLength(0);
    int numCols1 = a.GetLength(1);
    int numRows2 = b.GetLength(0);
    int numCols2 = b.GetLength(1);

    if (numCols1 != numRows2) throw new Exception("Невозможно умножить матрицы. Количество столбцов первой матрицы не совпадает с количеством строк второй матрицы.");

    for (int i = 0; i < numRows1; i++)
    {
        for (int j = 0; j < numCols2; j++)
        {
            for (int k = 0; k < numRows2; k++)
            {
                serialMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}


static void PrintMatrix<T>(T[,] matrix)
{
    int numRows = matrix.GetLength(0);
    int numCols = matrix.GetLength(1);

    for (int i = 0; i < numRows; i++)
    {
        for (int j = 0; j < numCols; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}


void PrepareParallelMatrixMul(int[,] a, int[,] b)
{
    int numRows1 = a.GetLength(0);
    int numCols1 = a.GetLength(1);
    int numRows2 = b.GetLength(0);
    int numCols2 = b.GetLength(1);

    if (numCols1 != numRows2) throw new Exception("Невозможно умножить матрицы. Количество столбцов первой матрицы не совпадает с количеством строк второй матрицы.");

    int eachThreadCalc = N / THREADS_NUMBER;
    Thread[] arr = new Thread[2];
    var threadsList = new List<Thread>();

    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        int startPos = i * eachThreadCalc;
        int endPos = (i + 1) * eachThreadCalc;
        //если последний поток
        if (i == THREADS_NUMBER - 1) endPos = N;
        threadsList.Add(new Thread(() => ParallelMatrixMul(a, b, startPos, endPos)));
        threadsList[i].Start();
    }
    for (int i = 0; i < THREADS_NUMBER; i++)
    {
        threadsList[i].Join();
    }
}

void ParallelMatrixMul(int[,] a, int[,] b, int startPos, int endPos)
{
    int numRows1 = a.GetLength(0);
    int numCols1 = a.GetLength(1);
    int numRows2 = b.GetLength(0);
    int numCols2 = b.GetLength(1);

    if (numCols1 != numRows2) throw new Exception("Невозможно умножить матрицы. Количество столбцов первой матрицы не совпадает с количеством строк второй матрицы.");

    for (int i = startPos; i < endPos; i++)
    {
        for (int j = 0; j < numCols2; j++)
        {
            for (int k = 0; k < numRows2; k++)
            {
                threadMulRes[i, j] += a[i, k] * b[k, j];
            }
        }
    }
}

bool EqualityMatrix(int[,] fMatrix, int[,] sMatrix)
{
    bool res = true;

    for (int i = 0; i < fMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fMatrix.GetLength(1); j++)
        {
            res = res && (fMatrix[i, j] == sMatrix[i, j]);
        }
    }
    return res;
}