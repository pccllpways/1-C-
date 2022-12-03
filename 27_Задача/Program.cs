// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int przv = 0;
while (num > 0)
{
    przv = przv + num % 10;
    num = num / 10;
}
Console.WriteLine(przv);