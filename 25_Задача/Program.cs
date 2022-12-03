// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

Console.WriteLine("Введите число №1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
int num2 = int.Parse(Console.ReadLine());
int przv = 1;
for (int i = 1; i <= num2; i++)
{
    przv *= num1;
}
Console.WriteLine(przv);