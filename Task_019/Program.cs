// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.Выполнить с помощью числовых 
//  операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int turnDigit = TurnDigit(number);
bool result = Palindrome(turnDigit,number);
Console.WriteLine(result ? "да" : "нет");

int TurnDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum * 10 + num % 10;
        num = num/10;
    }
return sum;
}

bool Palindrome(int turnDigit1, int num)
{
return turnDigit1 == num;
}