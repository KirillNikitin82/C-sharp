// Задача 66: Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое натуральное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое натуральное число");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 0 && numberN > 0)
{
    int sumElements = SumElements(numberM, numberN);
    Console.WriteLine($"Сумма чисел от {numberM} до {numberN} = {sumElements}");
}
else
{
    Console.WriteLine("Ввод неверного значения");
    return;
}

int SumElements(int numA, int numB)
{
    int sum = 0;
    int temp = 0;
    if (numA < numB)
    {
        sum = numA + SumElements(numA + 1, numB);
    }
    else if (numA > numB)
    {
        temp = numA;
        numA = numB;
        numB = temp;
        sum = numA + SumElements(numA + 1, numB);
    }
    else sum = sum + numB;
    return sum;
}
