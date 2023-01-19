// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool Week(int num)
{
    return num >5;
}

Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

if (day>0 && day <8)
{
    bool dayoff = Week(day);
    string result = dayoff ? "выходной" : "рабочий";
Console.WriteLine(result);
}
else 
Console.WriteLine("Некорректный ввод");
