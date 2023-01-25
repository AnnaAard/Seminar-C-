// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("ВВедите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int resultNum = ResNumbers(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} равно {resultNum}");
}
else
{
    Console.WriteLine("Некорректное число");
}


int ResNumbers(int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
        res=i*res;
    }
    return res;
}