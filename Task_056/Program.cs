// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
// 1 строка

Console.WriteLine("Введите количество строк");
int numberI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int numberJ = Convert.ToInt32(Console.ReadLine());
if (numberI <= 0 || numberJ <= 0)
{
    Console.WriteLine("Невозможно создать такую матрицу");
    return;
}

int[,] createMatrixRndIntint = CreateMatrixRndInt(numberI, numberJ, 1, 9);
PrintMatrix(createMatrixRndIntint);
Console.WriteLine();
int[] minAmountInLine = MinAmountInLine(createMatrixRndIntint);
int indexMinInArray = IndexMinInArray(minAmountInLine);
Console.WriteLine($"Минимальная сумма элементов в {indexMinInArray+1} строке");

int IndexMinInArray(int[] arr)
{
    int min = arr[0];
    int minIndex = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            minIndex = i;
        }
    }
    return minIndex;
}

int[] MinAmountInLine(int[,] matr)
{
    int[] array = new int[matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        array[i] = sum;
    }
    return array;
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
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine(" |");
    }
}
