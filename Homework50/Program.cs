// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

bool ParameterExaminated(int[,] matrix, int findRow, int findColumn)
{
    return (findRow < matrix.GetLength(0) && findRow > 0) && (findColumn < matrix.GetLength(1) && findColumn > 0);
}

int MatrixFindNumber(int[,] matrix, int findRow, int findColumn)
{
    return matrix[findRow, findColumn];
}


int[,] matrix2D = CreateMatrixRandom(3, 4, 1, 15);
PrintMatrix(matrix2D);
Console.WriteLine();

Console.WriteLine("Введите строку для поиска");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец для поиска");
int columns = Convert.ToInt32(Console.ReadLine());
if (ParameterExaminated(matrix2D, row, columns) == true)
{
    int findValue = MatrixFindNumber(matrix2D, row, columns);
    Console.WriteLine($"По заданным координатам находится значение {findValue}");
}
else
    Console.WriteLine($"По заданным координатам значение не найдено");
