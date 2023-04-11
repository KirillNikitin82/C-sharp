// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); //99+1
Console.WriteLine($"Случайное число из отрезка 10-99 -> {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit) 
// {
// Console.WriteLine($"Наибольшая цифра цисла -> {firstDigit}");
// }
// else
// {
//     Console.WriteLine($"Наибольшая цифра цисла -> {secondDigit}");
// }

// int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра цисла -> {maxDigit}");

int maxDigit = MaxDigit (number);
Console.WriteLine($"Наибольшая цифра цисла -> {maxDigit}");

int MaxDigit (int num) // num = number если использовать глобальную переменную смысл метода теряется, программа создает одно и тоже число.
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}