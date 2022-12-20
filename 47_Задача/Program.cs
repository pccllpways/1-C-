// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами от -10,0 до 10,0.

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * (max - min) + min;
        }
    }
    return result;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите длину строк: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите длину столбцов: ");
int column = int.Parse(Console.ReadLine());

double[,] array = GetArray(line, column, 3, 4);
PrintArray(array);