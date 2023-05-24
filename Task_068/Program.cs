// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите целое натуральное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое натуральное число");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM >= 0 && numberN >= 0)
{
    int accermanFunction = AccermanFunction(numberM, numberN);
    System.Console.WriteLine($"Значение функции Аккермана = {accermanFunction}");
}
else
{
    Console.WriteLine("Введите корректные значиния");
    return;
}

int AccermanFunction(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    else if ((numM != 0) && (numN == 0))
        return AccermanFunction(numM - 1, 1);
    else
        return AccermanFunction(numM - 1, AccermanFunction(numM, numN - 1));
}