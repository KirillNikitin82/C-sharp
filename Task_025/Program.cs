// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0)
{
    System.Console.WriteLine("Ошибка ввода данных");
}
else
{
    int[] arr = CreateArray(numberA, numberB);
    int result = Exponent(arr, numberB);
    Console.WriteLine($"{numberA} ^{numberB} ->{result}");
    // PrintArray(arr);
}

int Exponent(int[] array, int numB)
{
    int res = 1;
for (int i = 0; i < numB; i++)
    {
        res = res * array[i];
    }
    return res;
}

int[] CreateArray(int numA, int numB)
{
    int[] array = new int[numB];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = numA;
    }
    return array;
}

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }