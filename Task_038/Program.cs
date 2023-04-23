// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] array = CreateArrayRndDouble(5, 1, 100);
Console.Write("[");
PrintArray(array);
Console.Write("] ->");

double result = DefferenceMaxMin(array);
double resultRound = Math.Round(result, 1);
System.Console.WriteLine($"  {resultRound}");

double DefferenceMaxMin(double[] arr)
{
double max = arr[0];
double min = arr[0];
for (int i = 1; i < arr.Length; i++)
{
        if (max < arr[i])
        max = arr[i];
        if (min>arr[i])
        min = arr[i];
}
double result = max - min;
return result;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{round}, ");
        else Console.Write($"{round}");
    }
}