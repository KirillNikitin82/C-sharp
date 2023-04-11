// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = Remainder(numberA, numberB);

// if (result == 0)
// {
//     Console.Write("кратно");
// }
// else
// {
//     Console.Write($"не кратно, остаток {result}");
// }

string res = (result == 0) ?  "кратно" : $"не кратно, остаток {result}";
Console.Write(res);
int Remainder(int numA, int numB)
{
    return numA % numB;
}
