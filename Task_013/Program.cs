// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ThirdDigit(int num)
{
    int count = num;
    while (num > 999)
    {
        num = num / 10;
        count++;
    }
    return num % 10;
}

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
string res = (number >= 100) ? $"Третья цифра: {ThirdDigit(number)}" : "Третьей цифры нет!";
Console.Write(res);