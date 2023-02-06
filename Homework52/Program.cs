// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRandom(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

double[] AverageValue(int[,] matrix)
{
    double[] resultArray = new double[matrix.GetLength(1)];
    int r = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            count++;

            // Console.Write($"{resultArray[r]}|");
        }
        resultArray[r] = Math.Round(sum / count, 1);
        r++;

    }
    return resultArray;
}

void PrintArray(double[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],3} | ");
        else Console.Write($"{array[i],3} ");
    }
    Console.WriteLine("|");
}

void EachColumns(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Среднее арифметическое столбца {i} = {array[i]}");
    }
}


int[,] matrix2D = CreateMatrixRandom(3, 4, 1, 15);
PrintMatrix(matrix2D);
Console.WriteLine();
double[] mean = AverageValue(matrix2D);
// Тут можно просто вывести их в ряд
PrintArray(mean);
//А тут вариант с выводом каждого значения
EachColumns(mean);