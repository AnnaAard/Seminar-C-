// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).


Console.WriteLine("введите номер четверти:");
int q = Convert.ToInt32(Console.ReadLine());

string quarter = Quarter(q);
 Console.WriteLine(quarter);


string Quarter(int qua)
{
    if (qua == 1) return "Допустимые координаты => x > 0, y > 0";
    if (qua == 2) return "Допустимые координаты => x < 0, y > 0";
    if (qua == 3) return "Допустимые координаты => x < 0, y < 0";
    if (qua == 4) return "Допустимые координаты => x > 0, y < 0";
    return "Недопустимые координаты";
}