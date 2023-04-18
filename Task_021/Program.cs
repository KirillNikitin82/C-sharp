// Задача 21
// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(int x1, int x2, int y1, int y2, int z1, int z2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;
    double distance3D = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distance3D;
}

Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X2: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());

double dist3D = Distance3D(x1Coordinate, x2Coordinate, y1Coordinate, y2Coordinate, z1Coordinate, z2Coordinate);
double dist3DRound = Math.Round(dist3D, 2, MidpointRounding.ToZero);
System.Console.WriteLine(dist3DRound);