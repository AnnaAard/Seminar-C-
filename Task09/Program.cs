int number = new Random(). Next(10, 100);
Console.WriteLine($"Случайное число {number}");
int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра {number} => {firstDigit}");
}
else
    Console.WriteLine($"Наибольшая цифра {number} => {secondDigit}");