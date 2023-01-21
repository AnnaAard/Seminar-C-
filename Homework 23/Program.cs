// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите натуральное число");
int digit = Convert.ToInt32(Console.ReadLine());
if (digit < 1)
{
    Console.WriteLine("Некорректный ввод");
}
else
{
    cubeTable(digit);
}
void cubeTable(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5} {Math.Pow(count, 3),5}");
        count++;
    }
}