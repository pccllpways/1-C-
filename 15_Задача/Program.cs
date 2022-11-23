// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели: ");
string str = Console.ReadLine();
int number = int.Parse(str);
if (number > 5 && number < 8)
{
    Console.WriteLine("Это выходной день недели");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine("Это рабочий день недели");
}
else
{
    Console.WriteLine("Это не день недели");
}
