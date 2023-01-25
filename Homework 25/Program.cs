// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Degree(double num1, double num2)
{
    return Math.Pow(num1, num2);
}

Console.WriteLine("Введите число");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("В какую степень возвести?");
double numberB = Convert.ToInt32(Console.ReadLine());
double result = Degree(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");

