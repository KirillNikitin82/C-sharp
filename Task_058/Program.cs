// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк матрицы 1");
int rowsI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы 1");
int colomnsJ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк матрицы 2");
int rows2I = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы 2");
int colomns2J = Convert.ToInt32(Console.ReadLine());

if (rowsI <= 0 || colomnsJ <= 0 || rows2I <= 0 || colomns2J <= 0)
{
    Console.WriteLine("Невозможно создать такую матрицу");
    return;
}

if (colomnsJ == rows2I)
{
    int[,] createMatrixRndInt = CreateMatrixRndInt(rowsI, colomnsJ, 1, 9);
    int[,] create2MatrixRndInt = CreateMatrixRndInt(rows2I, colomns2J, 1, 9);
    int[,] multiplicationOfTwoMatrices = MultiplicationOfTwoMatrices(createMatrixRndInt, create2MatrixRndInt);
    PrintMatrix(createMatrixRndInt);
    System.Console.WriteLine();
    PrintMatrix(create2MatrixRndInt);
    System.Console.WriteLine("Произведение Матрицы 1 на Матрицу 2");
    PrintMatrix(multiplicationOfTwoMatrices);
}
else
{
    Console.WriteLine("Невозможно перемножать матрицы");
    return;
}

int[,] MultiplicationOfTwoMatrices(int[,] matr, int[,] matr2)
{
    int[,] matrix = new int[matr.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < matr2.GetLength(0); n++)
            {
                sum += matr[i, n] * matr2[n, j];
            }
            matrix[i, j] = sum;
        }

    }
    return matrix;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{

    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}
