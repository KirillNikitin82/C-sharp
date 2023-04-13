// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
while (count >= 100)
    number = number / 10;
    count ++;
Console.Write($"Третья цифра вашего числа: {number}");