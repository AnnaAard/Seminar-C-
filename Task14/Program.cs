// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


bool Multiple(int arg)
{
    return ((arg % 7 == 0) && (arg % 23 == 0));
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Multiple(number);

if (result == true)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("Не кратно");
}