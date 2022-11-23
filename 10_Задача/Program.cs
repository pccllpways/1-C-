// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трёхзначное число: ");
string str = Console.ReadLine();
int number = int.Parse(str);
if (number > 99 && number < 1000)
{
    Console.WriteLine("Вторая цифра числа: " + number / 10 % 10);
}
else
{
    Console.WriteLine("Число не трёхзначное");
}