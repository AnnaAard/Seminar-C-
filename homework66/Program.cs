// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// void SwapTwoNumbers (int num1, int num2)
// {
//     int tmp = num1;
//     num1 = num2;
//     num2 = tmp;
// Console.WriteLine($"{num1} {num2}");
// }

int SumElements(int numM, int numN)
{
    //   if (numM>numN)
    //   {
    //     SwapTwoNumbers(numM,numN);
    //   }
    return numM == numN + 1 ? 0 : numM + SumElements(numM + 1, numN);
}

Console.WriteLine("Введите первое число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM > numberN)
{
    int sumElements = SumElements(numberN, numberM);
    Console.WriteLine(sumElements);
}
else
{
    int sumElements = SumElements(numberM, numberN);
    Console.WriteLine(sumElements);
}