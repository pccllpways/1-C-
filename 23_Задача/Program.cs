// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.

Console.WriteLine("Введите число N: ");
string str = Console.ReadLine();
int num = int.Parse(str);
int counter = 1;
while (counter <= num)
{
    Console.WriteLine($"{counter}^3 = {Math.Pow(counter, 3)}");
    counter++;
}