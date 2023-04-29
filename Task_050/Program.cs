// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Задайте количество строк в массиве:");
int numI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов в массиве:");
int numJ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Ведите номер строки массива:(max {numI})");
int numberI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ведите номер столбца массива:(max {numJ})");
int numberJ = Convert.ToInt32(Console.ReadLine());

if (numI == 0 | numJ == 0)
{
    System.Console.WriteLine("Создание такого  массива невозможно");
    return;
}

if (numberI > numI | numberJ > numJ | numberI == 0 | numberJ == 0)
{
    System.Console.WriteLine("Такого элемента в массиве нет");
    return;
}

int[,] matrix = new int[numI, numJ];
int[,] createMatrixRndInt = CreateMatrixRndInt(matrix, 0, 10);
PrintMatrix(createMatrixRndInt);

System.Console.WriteLine($"Элемент соответствующий данной ячейке массива: [{matrix[numberI - 1, numberJ - 1]}]");

int[,] CreateMatrixRndInt(int[,] matr, int min, int max)
{

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
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
