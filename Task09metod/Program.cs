int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число {number}");

int maxdigit = MaxDigit(number);

int MaxDigit(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    if (firstDigit > secondDigit) return firstDigit;
    else return secondDigit;
}
Console.WriteLine($"Максимальная цифра {maxdigit}");