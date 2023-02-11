// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixToMatrix(int[,] matrix1, int[,] matrix2)
{
        int[,] matrixResult = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            int sum = 0;

            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
                matrixResult[i, j] = sum;
            }
        }
    }
    return matrixResult;
}


int[,] matrix1 = CreateMatrixRandom(3, 5, 1, 6);
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateMatrixRandom(5, 3, 1, 6);
PrintMatrix(matrix2);
Console.WriteLine();
if (matrix1.GetLength(0) != matrix2.GetLength(1))
Console.WriteLine("Размер строк и столбцов не совпадает");
else
{
    int[,] matrix3 = MatrixToMatrix(matrix1, matrix2);
    PrintMatrix(matrix3);
}


