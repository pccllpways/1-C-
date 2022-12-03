// Задача 29: Напишите программу, которая генерирует массив из 8 
// элементов - случайных чисел (от 0 до 20) и выводит их на экран.

int[] array = new int[20];
for (int i = 0; i < 8; i++)
{
    int random = new Random().Next(0, 21);
    array[i] = random;
    Console.WriteLine(array[i]);
}