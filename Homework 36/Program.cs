// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int SumAddPositionElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        sum=sum+array[i];
    }
    return sum;
}
//Вот ещё вариант решения, он тоже работает,но думаю что первый оптимальнее
//тк меньше вычислений с этим делением и он вообще не обращает внимания на чётные позиции

// int SumAddPositionElements(int[] array)
// {
//     int sum =0;
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (i%2==1) sum=sum+array[i];
//     }
//     return sum;
// }


int[] arr = CreateArray(10, 1, 10);
PrintArray(arr);
int sumAddElem = SumAddPositionElements(arr);
Console.WriteLine($" => {sumAddElem}");