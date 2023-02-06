// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRandomDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"|{matrix[i, j],6}");
        }
        Console.WriteLine("|");
    }
}

// Не поняла из задания пользователь задаёт размер массива или я сама.
// если пользователь, то решение ниже, если мне самой надо было, то вот.
//double[,] arr = CreateMatrixRandomDouble(3,4, 1, 10);
//PrintMatrix(arr);

Console.WriteLine("Введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
double[,] matrix2D = CreateMatrixRandomDouble(m, n, 1, 10);
PrintMatrix(matrix2D);