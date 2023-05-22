// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

int[,] matrix1 = CreateMatrixRndInt(5, 5, -9, 9);
PrintMatrix(matrix1);
int[] position = IndexMinInArray(matrix1);
int min = position[0];
Console.WriteLine($"Минимальное {min}");
int[,] createNewMatrix = CreateNewMatrix(position[1], position[2], matrix1);
PrintMatrix(createNewMatrix);

int[] IndexMinInArray(int[,] arr)
{
    int min = arr[0, 0];
    int minIndexI = 0;
    int minIndexJ = 0;
    for (int i = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < min)
            {
                min = arr[i, j];
                minIndexI = i;
                minIndexJ = j;
            }
        }
    }
    return new int[] { min, minIndexI, minIndexJ };
}


int[,] CreateNewMatrix(int rows, int columns, int[,] matr)
{

    int[,] matrix = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    int r = 0;
    int c = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (r == rows) r++;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (c == columns) c++;
            matrix[i, j] = matr[r, c];
            c++;
        }
        c = 0;
        r++;
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
            Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine(" |");
    }
}