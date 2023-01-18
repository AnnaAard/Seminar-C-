// // Напишите программу, которая выводит случайное
// // трёхзначное число и удаляет вторую цифру этого
// // числа.
// // 456 -> 46
// // 782 -> 72
// // 918 -> 98


int GetNumber(int arg)
{
    int numberFirst = arg / 100;
    int numberThird = arg % 10;
    int numberResult = numberFirst * 10 + numberThird;
    return numberResult;
}

int number = new Random().Next(100, 1000);
int result = GetNumber(number);
Console.WriteLine($"Случайное число {number} превращается в {result}");
