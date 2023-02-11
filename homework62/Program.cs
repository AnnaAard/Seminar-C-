// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixSpiral(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int length = matrix.GetLength(1);
    int height = matrix.GetLength(0);
    int num = 1;
    int i = 0;
    int j = 0;
    for (j = 0; j < length; j++)
    {
        matrix[i, j] = num;
        num++;
    }
    for (i = 1; i < height; i++)
    {
        matrix[i, length - 1] = num;
        num++;
    }
    for (j = length - 2; j >= 0; j--)
    {
        matrix[height - 1, j] = num;
        num++;
    }
    for (i = height - 2; i >= 1; i--)
    {
        matrix[i, 0] = num;
        num++;
    }
    i = 1;
    j = 1;
    while (num < length * height)
    {
        while (matrix[i, j + 1] == 0)
        {
            matrix[i, j] = num;
            num++;
            j++;
        }
        while (matrix[i + 1, j] == 0)
        {
            matrix[i, j] = num;
            num++;
            i++;
        }
        while (matrix[i, j - 1] == 0)
        {
            matrix[i, j] = num;
            num++;
            j--;
        }
        while (matrix[i - 1, j] == 0)
        {
            matrix[i, j] = num;
            num++;
            i--;
        }
    }
    for (i = 0; i < height; i++)
    {
        for (j = 0; j < length; j++)
        {
            if (matrix[i, j] == 0) matrix[i, j] = num;
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


int[,] matrixSpiral = CreateMatrixSpiral(10, 6);
PrintMatrix(matrixSpiral);