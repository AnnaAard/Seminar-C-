// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int num)
{
    int sum = 0;
    if (num < 0) num = num * -1;
    while (num > 0)
    {
        int lastDigit = num % 10;
        num = num / 10;
        sum = sum + lastDigit;
    }
    return sum;
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigit(number);
Console.WriteLine(result);