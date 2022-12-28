// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, 
// которая будет находить произведение двух массивов (поэлементное).

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

int[,] ProductArray(int[,] array1, int[,] array2)
{
    int RowsA = array1.GetLength(0); int Num1 = array1.GetLength(1);
    int RowsB = array2.GetLength(0); int Num2 = array2.GetLength(1);
    int[,] sumProduct = new int[RowsA, Num2];
    for (int i = 0; i < RowsA; i++)
    {
        for (int j = 0; j < Num2; j++)
        {
            for (int k = 0; k < Num1; k++)
            {
                sumProduct[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return sumProduct;
}

Console.Write("Введите количество строк в матрице 1: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в матрице 1, равное числу строк матрицы 2: ");
int columns1 = int.Parse(Console.ReadLine()!);
int row2 = columns1;
Console.Write("Введите количество столбцов в матрице 2: ");
int columns2 = int.Parse(Console.ReadLine()!);
int[,] massA = GetArray(row1, columns1, 0, 9);
PrintArray(massA);
Console.WriteLine();
int[,] massB = GetArray(row2, columns2, 0, 9);
PrintArray(massB);
Console.WriteLine();
int[,] productMass = ProductArray(massA, massB);
PrintArray(productMass);