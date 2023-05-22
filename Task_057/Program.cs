// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] matrix1 = CreateMatrixRndInt(5, 5, -9, 9);
PrintMatrix(matrix1);
int[] arrayInLine = ArrayInLine(matrix1);
PrintArray(arrayInLine);
Array.Sort(arrayInLine);
Console.WriteLine();
PrintArray(arrayInLine);
Console.WriteLine();
DictionaryCount(arrayInLine);

void DictionaryCount(int[] arr)
{
    int number = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == number) count++;
        else
        {
            Console.WriteLine($"Число {number} встречается {count} раз");
            count = 1;
            number = arr[i];
        }
    }
    Console.WriteLine($"Число {number} встречается {count} раз");
}

int[] ArrayInLine(int[,] matr)
{
    int[] array = new int[matr.GetLength(0) * matr.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            array[k] = matr[i, j];
            k++;
        }
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

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]},   ");
        else Console.Write($"{arr[i]}");
    }
}