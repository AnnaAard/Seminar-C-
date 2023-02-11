// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"


Console.WriteLine("Введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(m, n);

void NaturalNumbers(int numA, int numB)
{
    Console.Write($"{numA} ");
    if (numA == numB) return;
    if (numA < numB)
    {
        NaturalNumbers(numA + 1, numB);
    }
    else
    {
        NaturalNumbers(numA - 1, numB);
    }
}