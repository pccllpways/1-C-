// Задача 50. Напишите программу, которая на вход принимает число, и 
// возвращает индексы числа в двумерном массиве или же указание, что такого 
// элемента нет.

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
void PrintArray(int[,] array)
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
void RetutnOrAbsence(int[,] array, int Number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == Number)
            {
                Console.WriteLine($"Число в {i} строке, {j} столбце\t ");
                return;
            }
        }
    }
    Console.WriteLine("Числа нет.");
}

Console.Clear();
Console.Write("Введите длину строк: ");
int line = int.Parse(Console.ReadLine());
Console.Write("Введите длину столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите число для проверки: ");
int num = int.Parse(Console.ReadLine());
int[,] array = GetArray(line, column, 0, 8);
PrintArray(array);
RetutnOrAbsence(array, num);