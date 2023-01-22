// Универсальный метод для проверки на палиндром любых чисел

void Pall(int num)
{
    while (num > 9)
    {
        int count = 0;
        int lastDigit = num % 10;
        int firstDigit = num;
        while (firstDigit >= 9)
        {
            firstDigit = firstDigit / 10;
            count++;
        }

        if (firstDigit == lastDigit && num > 10)
        {
            // Сначала я использовала эту формулу,но она криво работала(подскажете почему? и как надо)
            //num = Convert.ToDouble((num - (firstDigit * (Math.Pow(10, count)))) / 10);
            // поэтому разбила её на две части, вот так

            double deleteNull = Math.Pow(10, count);
            double delete = deleteNull * firstDigit;
            num = Convert.ToInt32((num - delete) / 10);
        }
        else
        {
            Console.WriteLine($" не является, несовпадение {firstDigit}  {lastDigit}");
            break;
        }
    }
    if (num < 10)
    {
        Console.WriteLine("Число является палиндромом");
    }
}

Console.WriteLine("ВВедите число");
int number = Convert.ToInt32(Console.ReadLine());
Pall(number);