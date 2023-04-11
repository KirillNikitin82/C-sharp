// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000); 
Console.WriteLine($"Случайное число -> {number}");

int result = DeleteSecondDigit (number);
Console.WriteLine($"Удаляем вторую цифру числа -> {result}");

int DeleteSecondDigit (int num) 
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int res = firstDigit*10 + thirdDigit;
    return res;
}