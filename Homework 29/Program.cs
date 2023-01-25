// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


void FullArray (int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index<length)
    {
        array[index] = new Random().Next(0, 99);
        index++;
    }
}

void PrintArray (int[] mass)
{
    int length = mass.Length;
    int i = 0;
    while (i<length)
    {
         Console.Write($" {mass[i]},");
         i++;
    }
}
void PrintArray2 (int[] mass)
{
    int length = mass.Length;
    int i = 0;
    Console.Write($"  =>  [");
    while (i<length)
    {
         Console.Write($" {mass[i]}");
         i++;
    }
    Console.Write("]");
}



int[] array = new int [8];
FullArray(array);
PrintArray(array);
PrintArray2(array);


