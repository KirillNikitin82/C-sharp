// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int numberQuarter = Convert.ToInt32(Console.ReadLine());

string coordinate = Coordinate(numberQuarter);

Console.WriteLine(coordinate == null ? "Неправильный номер четверти" : coordinate);

string Coordinate(int num)
{
    if (num == 1) return "x > 0 && y > 0";
    if (num == 2) return "x < 0 && y > 0";
    if (num == 3) return "x < 0 && y < 0";
    if (num == 4) return "x > 0 && y < 0";
    return null;
}
