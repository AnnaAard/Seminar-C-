// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты  первой точки прямой K");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты  второй точки прямой K");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты  первой точки прямой B");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты  второй точки прямой B");
double b2 = Convert.ToDouble(Console.ReadLine());
//Проверка на параллельность
if (k1 * b2 - k2 * b1==0)
{
Console.WriteLine("Заданные прямые не пересекаются");
}
else
{
Console.WriteLine($"Координаты точки пересечения -> ");
double[] arrayResult=PointsCoordinates(k1, k2, b1, b2);
PrintPoint(arrayResult);
}

double[] PointsCoordinates(double x1, double x2, double y1, double y2)
{
    double[] arrayRes = new double[2];
    arrayRes[0] = Math.Round((y2 - y1) / (x1 - x2), 2);
    arrayRes[1] = Math.Round((x1 * arrayRes[0] + y1), 2);
    return arrayRes;
}

void PrintPoint(double[] arrayResult)
{
    Console.Write("[");
    for (int i = 0; i < arrayResult.Length; i++)
    {
        if (i < arrayResult.Length - 1) Console.Write($" {arrayResult[i]},");
        else Console.Write($" {arrayResult[i]}");
    }
    Console.WriteLine("]");
}
