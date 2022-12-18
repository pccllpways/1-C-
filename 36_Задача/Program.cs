// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов с нечётными индексами.

int[] numbers = new int[5];
Numbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
int count = 0;

for (int i = 1; i < numbers.Length; i += 2)
count = count + numbers[i];

Console.WriteLine($"сумма нечётных: {count}");

void Numbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}