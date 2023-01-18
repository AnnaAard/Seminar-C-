// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool square(int arg1, int arg2)
{
    return ((arg1 * arg1 == arg2) || (arg2 * arg2 == arg1));
}

Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
bool result = square(numberA, numberB);

if (result == true && numberA>numberB)
{
    
Console.WriteLine($"{numberA} квадрат числа{numberB}");
}
else if (result == true && numberA<numberB)
{
   Console.WriteLine($"{numberB} квадрат числа {numberA}"); 
}
else
{
    Console.WriteLine("Ни одно число не является квадратом второго");
}