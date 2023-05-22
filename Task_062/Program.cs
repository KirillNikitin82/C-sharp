// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

System.Console.WriteLine("Введите количество строк в матрице");
int numI = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов в матрице");
int numJ = Convert.ToInt32(Console.ReadLine());

if (numI <= 0 || numJ <= 0)
{
    Console.WriteLine("Невозможно создать такую матрицу");
    return;
}

int[,] spiralFilling = SpiralFilling(numI, numJ);
PrintMatrix(spiralFilling);

int[,] SpiralFilling(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int num = 1;
    for (int j = 0; j < columns; j++)
    {
        matrix[0, j] = num;
        num++;
    }
    for (int i = 1; i < rows; i++)
    {
        matrix[i, columns - 1] = num;
        num++;
    }
    for (int j = columns - 2; j >= 0; j--)
    {
        matrix[rows - 1, j] = num;
        num++;
    }
    for (int i = rows - 2; i > 0; i--)
    {
        matrix[i, 0] = num;
        num++;
    }
    int r = 1;
    int c = 1;
    while (num < rows * columns)
    {
        while (matrix[r, c + 1] == 0)
        {
            matrix[r, c] = num;
            num++;
            c++;
        }
        while (matrix[r + 1, c] == 0)
        {
            matrix[r, c] = num;
            num++;
            r++;
        }
        while (matrix[r, c - 1] == 0)
        {
            matrix[r, c] = num;
            num++;
            c--;
        }
        while (matrix[r - 1, c] == 0)
        {
            matrix[r, c] = num;
            num++;
            r--;
        }
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (matrix[i, j] == 0) 
            {
                matrix[i, j] = num;
            }
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
