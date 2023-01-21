// 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите натуральное число");
int digit = Convert.ToInt32(Console.ReadLine());
if (digit < 1)
{
    Console.WriteLine("Некорректный ввод");
}
else
{
    Table(digit);
}
void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,5}  {count * count,5}");
        count++;
    }
}