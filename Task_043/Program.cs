// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задаем первую прямую y = k1 * x + b1, введите b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задаем первую прямую y = k1 * x + b1, введите k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задаем вторую прямую y = k2 * x + b2, введите b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задаем вторую прямую y = k2 * x + b2, введите k2:");
int k2 = Convert.ToInt32(Console.ReadLine());

// double CrossPoint(int b11, int k11, int b22, int k22)
{
    // double x = 0;
    // double y = 0;
    // int x2 = 0;
    // int y2 = 0;
    // for (y1=y2 || x1=x2)
    // {

    // }

    // y = k1 * x + b1 + k2 * x + b2;
    // x = 


}

double X = (b1-b2)/(k2-k1);
double Y = k2*(b1-b2)/(k2-k1)+b2;

Console.WriteLine($"Точка пересечения имеет координаты [{X};{Y}]");