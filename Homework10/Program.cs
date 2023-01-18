// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// // 918 -> 1

int GetNumber (int num)
{
    int numberLast = num / 10;
    int numberSecond = numberLast % 10;
    return numberSecond;
}

Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int second = GetNumber(number);

if (number<1000 && number>99 || number>-1000 && number<-99)
{
    if (second <0)
    {
    second = second*-1;
    }
    Console.WriteLine ($"Второе число {number} => {second}");
}
else
{
    Console.WriteLine ($"Число не соответствует");
}
