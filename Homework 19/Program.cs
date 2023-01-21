// Задача 19
// Напишите программу,которая принимает на вход пятизначное число и
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void PallFirstLast(int num)
{
    int lastDigit = num % 10;
    int firstDigit = num / 10000;
    if (lastDigit == firstDigit)
    {
        int beforlast = num / 10 % 10;
        int secondDigit = num / 1000 % 10;
        if (beforlast == secondDigit)
        {
            Console.WriteLine("Число является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}

Console.WriteLine("ВВедите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 9999 && number < 100000)
{
    PallFirstLast(number);
}
else
{
    Console.WriteLine("Некорректное число");
}
