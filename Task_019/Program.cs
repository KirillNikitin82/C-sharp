// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.Выполнить с помощью числовых 
//  операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int turnDigit = TurnDigit(number);
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {turnDigit}");

int TurnDigit(int num)
{
    int sum = 0;
    for (int i = 10; i > 0; i = i * 10)
    {
        int res = sum / i % 10;
    }
    return sum;
}
