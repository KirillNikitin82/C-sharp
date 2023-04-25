// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[numberA];
CreateArray(arr, numberA);
PrintArray(arr);

int result = PositiveElements(arr);
Console.WriteLine($"-> {result}");

int PositiveElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (arr[i] > 0) count ++;
    }
    return count;
}


void CreateArray(int[]array, int numA)
{
        for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите элемент {i+1} элемент массива:");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

