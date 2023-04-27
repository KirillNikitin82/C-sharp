// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задаем первую прямую y = k1 * x + b1, введите b1:");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задаем первую прямую y = k1 * x + b1, введите k1:");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задаем вторую прямую y = k2 * x + b2, введите b2:");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Задаем вторую прямую y = k2 * x + b2, введите k2:");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны или равнозначны");
}
else
// {
//     double x = (b1 - b2) / (k2 - k1);
//     double y = k2 * (b1 - b2) / (k2 - k1) + b2;
//     double xRound = Math.Round(x, 2);
//     double yRound = Math.Round(y, 2);
//     Console.WriteLine($"Точка пересечения имеет координаты [{xRound};{yRound}]");
// }
// {
//     double[] crossPoint = CrossPoint(b1, k1, b2, k2);
//     Console.WriteLine($"[ {crossPoint} ]");
// }
// double CrossPoint(double b11, double k11, double b22, double k22)
// {
//     double[] arr = new double[2];
//     {
//     arr[0] = (b11 - b22) / (k22 - k11);
//     arr[1] = k22 * (b11 - b22) / (k22 - k11) + b22;
//     }
//     return arr;
// }
{
    double crossPointX = CrossPointX(b1, k1, b2, k2);
    double crossPointY = CrossPointY(b1, k1, b2, k2);
    double crossPointXRound = Math.Round(crossPointX, 2);
    double crossPointYRound = Math.Round(crossPointY, 2);

    Console.WriteLine($"[ {crossPointXRound}; {crossPointYRound} ]");
}

double CrossPointX(double b11, double k11, double b22, double k22)
{
    return (b11 - b22) / (k22 - k11);
}

double CrossPointY(double b11, double k11, double b22, double k22)
{
    return k22 * (b11 - b22) / (k22 - k11) + b22;
}