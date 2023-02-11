// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] MatrixToArray(int[,] matrix) 
{ 
    int[] result = new int[matrix.Length]; 
    int count = 0; 
    for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            result[count++] = matrix[i, j]; 
        } 
    } 
    return result; 
} 
 
string PrintArray(int[] arr) 
{ 
    string str = String.Empty; 
    for (int i = 0; i < arr.Length; i++) 
    { 
        str += $"{arr[i]} "; 
    } 
    return str; 
 
} 
 
//  void GetSameCountNubers(int[] arr) 
// { 
//     int tmp = arr[0]; 
//     int count = 1; 
//     for (int i = 1; i < arr.Length; i++) 
//     { 
//         if (tmp == arr[i]) count++; 
//         else 
//         { 
//             Console.WriteLine($"{tmp,3} => {count}"); 
//             tmp = arr[i]; 
//             count = 1; 
//         } 
//     } 
//     Console.WriteLine($"{tmp,3} => {count}"); 
// } 
 

 int[,] FrequencyVocabulary(int[] array)
{
    int rowCounter = 1;
    for (int k = 1; k < array.Length; k++)
    {
        if (array[k] != array[k - 1]) rowCounter++;
    }
    int[,] vocabulary = new int[rowCounter, 2];
    int m = 0;
    int vocabularyCounter = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] != array[i + 1] )
        {
            vocabulary[m, 0] = array[i];
            vocabulary[m, 1] = vocabularyCounter;
            m++;
            vocabularyCounter = 1;
        }
        else
        { vocabularyCounter++; }
        vocabulary[m, 0] = array[array.Length - 1];
        vocabulary[m, 1] = vocabularyCounter;
    }
    return vocabulary;
}


int[,] matrixNumbers = CreateMatrixRandom(3, 4, 0, 10); 
PrintMatrix(matrixNumbers); 
 
int[] array = MatrixToArray(matrixNumbers); 
Array.Sort(array); 
Console.WriteLine(PrintArray(array)); 

//GetSameCountNubers(array);
int[,] voc = FrequencyVocabulary(array);
PrintMatrix(voc); 
