// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
double Distance (int x1, int x2, int y1, int y2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    double distance = Math.Sqrt(deltaX*deltaX + deltaY*deltaY);
    return distance;
}

System.Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X2: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

double dist = Distance(x1Coordinate, x2Coordinate, y1Coordinate, y2Coordinate);
double distRound = Math.Round(dist, 2, MidpointRounding.ToZero);
System.Console.WriteLine(distRound);