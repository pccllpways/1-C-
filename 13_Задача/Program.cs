// Задача 13: Напишите программу, которая с помощью деления выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
int number = int.Parse(str);
while (number > 1000)
{
    number = number / 10;
}
Console.WriteLine("Третья цифра числа: " + number % 10);