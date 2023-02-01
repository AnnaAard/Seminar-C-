// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
        // Как правильно разделить эту длинную формулу?
        // все варианты переставления квад скобок перепробовала
        // он всё равно на что то но ругается
        // вот в таком варианте например что не так?
        // array[i] =rnd.NextDouble()*(max-min)+min);
        // double[] arrayRound = Math.Round((array[i]),2);
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
    Console.WriteLine("]");
}

double[] MinMaxDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        if (array[i] > max) max = array[i];
    }
    
    Console.WriteLine($"Максимальное число {max} минимальное число {min}");
   return new double[]{min, max, max - min};
}

double[] arr = CreateArrayDouble(10, 1, 10);
PrintArrayDouble(arr);

double[] difference = MinMaxDifference(arr);
Console.WriteLine($"Минимальное число {difference[0]}");
Console.WriteLine($"Максимальное число {difference[1]}");

