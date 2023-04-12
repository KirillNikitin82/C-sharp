// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0)
// number = -number;
int num = number < 0 ? number = -number : 1; //работает любая цифра после двоеточия, без цифры не работает
if (number >= 100 && number <= 999)
    Console.WriteLine($"Вторая цифра ->  {number % 100 / 10}");
else
    Console.WriteLine("Вы ввели нетрёхзначное число");

// int secondDigit = SecondDigit (number);
// int SecondDigit (int num)
// {
// int num2 = number % 100/10;
// return secondDigit ;   
// }

string num1 = number >= 100 && number <= 999 ? $"Вторая цифра ->  {secondDigit}" : "Вы ввели нетрёхзначное число";
// Console.WriteLine($"Вторая цифра -> {secondDigit}");