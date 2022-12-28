// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    return result;
}
void PrintArray(int[,] arrayA)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            Console.Write($"{arrayA[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
void SortElementRowArray(int[,] arrayA)
{
    for (int k = 0; k < arrayA.GetLength(0); k++)
    {
        for (int i = 0; i < arrayA.GetLength(1); i++)
        {
        for (int j = i + 1; j < arrayA.GetLength(1); j++)
        {
            if (arrayA[k,i] < arrayA[k,j])
            {
                int temp = arrayA[k,i];
                arrayA[k,i] = arrayA[k,j];
                arrayA[k,j] = temp;
            }
        }
    }
}
}
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int column = int.Parse(Console.ReadLine()!);
int[,] arrayA = GetArray(row, column, 0, 9);
PrintArray(arrayA);
Console.WriteLine();
SortElementRowArray(arrayA);
PrintArray(arrayA);