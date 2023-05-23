// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

Console.WriteLine("Введите количество строк");
int numberI = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int numberJ = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину массива");
int numberD = Convert.ToInt32(Console.ReadLine());

if (numberI * numberJ * numberD >= 90 || numberI <= 0 || numberJ <= 0 || numberD <= 0)
{
    Console.WriteLine("Невозможно заполнить матрицу согласно условию");
    return;
}

int[,,] createMatrix3dInt = CreateMatrix3dInt(numberI, numberJ, numberD);
PrintMatrix3d(createMatrix3dInt);

int[,,] CreateMatrix3dInt(int numI, int numJ, int numD)
{
    int[,,] matrix3d = new int[numI, numJ, numD];
    int num = 10;

    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            for (int d = 0; d < matrix3d.GetLength(2); d++)
            {
                matrix3d[i, j, d] = num;
                num++;
            }

        }
    }

    return matrix3d;
}

void PrintMatrix3d(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int d = 0; d < matr.GetLength(2); d++)
            {
                Console.Write($"{matr[i, j, d],5} ({i},{j},{d})");

            }

        }
        Console.WriteLine("  ");
    }

}
