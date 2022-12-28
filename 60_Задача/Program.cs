// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных 
// чисел. Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.

int[,,] GetArray(int a, int b, int c, int min, int max)
{
    int[,,] array = new int[a, b, c];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int g = 0; g < array.GetLength(2); g++)
            {
                array[i, j, g] = new Random().Next(min, max + 1);
            }
        }

    return array;
}

void PrintArray(int[,,] arrayA)
{
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            for (int g = 0; g < arrayA.GetLength(2); g++)
            {
                Console.WriteLine($" Число {arrayA[i,j,g]} по координатам {i}, {j}, {g}");
            }
        }
    }
}
Console.Write("Введите длину массива: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите высоту массива: ");
int z = int.Parse(Console.ReadLine());
int[,,] array = GetArray(x, y, z, 10, 99);
PrintArray(array);

Console.WriteLine();