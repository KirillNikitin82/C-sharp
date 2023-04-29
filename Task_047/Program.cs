// Задача 47. Задайте двумерный массив размером 
// m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задайте количество строк в массиве m:");
int numI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов в массиве n:");
int numJ = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[numI, numJ];
double[,] createMatrixRndDouble = CreateMatrixRndDouble(matrix, 0, 10);
// double[,] createMatrixRndDoubleRound = Math.Round(createMatrixRndDouble, 2);
// не удается преобразовать из "double[]" в "decimal". сделал метод
ResultRound(createMatrixRndDouble);
PrintMatrix(matrix);

double[,] CreateMatrixRndDouble(double[,] matr, int min, int max)
{

    Random rnd = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i,j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matr;
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5} ");
        }
        Console.WriteLine(" | ");
    }
}

void ResultRound(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(arr[i,j], 1);
        }
        
    }
}

