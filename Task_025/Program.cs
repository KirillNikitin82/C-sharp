// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

// int[] array = Exponent( numberA, numberB, array);
int[] arr = new int[numberB];

// int[] arr1 = PrintArray(arr[], numberB, numberA);
// System.Console.WriteLine();


// int[] CreateArray(int numB, int numA)
// {
//     int[] array = new int[numB];
//     for (int i = 0; i <= numB; i++)
//     {
//         array[i] = numA;
//     }
//     return array;
// }

int PrintArray(int[] array, int numB, int numA)
{
    int i = 0;
    while (i < numB)
    {
        array[i] = numA;
        Console.Write($"{array[i]} ");
    }
    return array[i];
}

// int Exponent(int numA, int numB, int[] arr)
// {
//     int sum = 0;
//     int count = 0;
//     while (count <= numB)
//     {
//         sum = numA * arr[count];
//         count++;
//     }
//     return sum;
// }
