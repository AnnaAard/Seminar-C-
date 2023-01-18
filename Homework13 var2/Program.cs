int GetNumber(int num)
{
    while (num > 999 || num <-999)
    {
        num = num / 10;
    }
    return num % 10;
}

int number = new Random().Next(-99999, 99999);
int result = GetNumber(number);
if (number > 99 || number < -99)
{
    if (result < 0)
    {
        result = result * -1;
    }
    Console.WriteLine($"Случайное число {number}, третья цифра {result}");
}
else
{
    Console.WriteLine($"В числе {number} третьей цифры нет");
}
