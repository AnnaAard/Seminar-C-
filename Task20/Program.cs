// 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double Pif(int x1, int y1, int x2,int y2)
{
    return Math.Sqrt((Math.Pow(x1 - x2, 2)) + (Math.Pow(y1 - y2, 2)));
}

Console.WriteLine("Введите координаты х первой точки");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y первой точки");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты х второй точки");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y второй точки");
int yb = Convert.ToInt32(Console.ReadLine());

double distanse = Pif(xa, ya, xb, yb);
double dRound = Math.Round(distanse, 2);
Console.WriteLine($"Расстояние между точками = {dRound}");