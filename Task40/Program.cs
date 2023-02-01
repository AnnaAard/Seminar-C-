// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите длину первой стороны");
int sideA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны");
int sideB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны");
int sideC = Convert.ToInt32(Console.ReadLine());

bool CompareSide(int arg1, int arg2, int arg3)
{
    if (arg1 < arg2 + arg3 && arg2 < arg1 + arg3 && arg3 < arg2 + arg1)
        return true;
        return false;
}

bool result = CompareSide(sideA, sideB, sideC);
Console.WriteLine((result) ? "Да" : "Нет");