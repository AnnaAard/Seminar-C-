// // 1. Напишите программу, которая на вход принимает два
// // числа и проверяет, является ли первое число квадратом
// // второго.
// // a = 25, b = 5 -> да
// // a = 2, b = 10 -> нет
// // a = 9, b = -3 -> да
// // a = -3 b = 9 -> нет

// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// if (numberB * numberB == numberA)
// {
//     Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
// }
// else
// {
//     Console.WriteLine($"Число {numberA} не является квадратом числа {numberB}");
// }


void Pall(int num)
{
        int count = 0;
        int lastDigit = num % 10;
        int firstDigit = num;
        while (firstDigit >= 9)
        {
            firstDigit = firstDigit / 10;
            count++;
        }
        Console.WriteLine($"{firstDigit}  {lastDigit} {count} {num}");
}

Console.WriteLine("ВВедите число");
int number = Convert.ToInt32(Console.ReadLine());
Pall(number);