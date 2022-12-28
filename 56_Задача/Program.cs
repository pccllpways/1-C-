// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

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
int[] SumRowArray(int[,] arrayB) //строка[,] = индекс[]
{
    int[] result = new int[arrayB.GetLength(0)];
    int k = 0;
    for (int i = 0; i < arrayB.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            sum += arrayB[i, j];
        }
        result[k++] = sum;
    }
    return result;
}
void FindRowMinSum(int[] arr)
{
    int minSum = arr[0];
    int rowMinSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minSum)
        {
            minSum = arr[i];
            rowMinSum = i;
        }
    }
Console.Write($"Минимальная сумма элементов массива: {minSum}, в строке с индексом: {rowMinSum}. ");
}
Console.Write("Введите количество строк в массиве: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
int[] num = SumRowArray(array);
Console.WriteLine();
FindRowMinSum(num);