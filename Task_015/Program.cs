// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
bool NumberDay(int num)
{
    return num > 5;
}

Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    bool result = NumberDay(number);
    if (result == true) Console.WriteLine("Да");
    if (result == false) Console.WriteLine("Нет");
}
else 
{
    Console.WriteLine("нет такого дня недели");
}