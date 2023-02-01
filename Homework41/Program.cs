// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество цифр в массиве");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int[] arrayUser = new int[sizeArray];
UserFillArray(arrayUser);
PrintArray(arrayUser);
int countPositive = CountPositive(arrayUser);
Console.WriteLine($"В данном массиве положительных чисел: {countPositive}");


int[] UserFillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите число под индексом {i} ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($" {array[i]},");
        else Console.Write($" {array[i]}");
    }
    Console.WriteLine("]");
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}