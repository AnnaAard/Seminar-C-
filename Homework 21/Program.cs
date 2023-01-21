// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Pif(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt((Math.Pow(x1 - x2, 2)) + (Math.Pow(y1 - y2, 2)) + (Math.Pow(z1 - z2, 2)));
}

Console.WriteLine("Введите координаты х первой точки");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y первой точки");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z первой точки");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты х второй точки");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y второй точки");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты z второй точки");
int zb = Convert.ToInt32(Console.ReadLine());


double distanse = Pif(xa, ya, za, xb, yb, zb);
double dRound = Math.Round(distanse, 2);
Console.WriteLine($"Расстояние между точками = {dRound}");