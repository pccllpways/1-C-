// a = 5; b = 7;
// a = 2; b = 10;
// a = -9; b = -3;

Console.WriteLine("Напишите первое число:");
string str = Console.ReadLine();
int a = int.Parse(str);
Console.WriteLine("Напишите второе число:");
str = Console.ReadLine();
int b = int.Parse(str);
if(a > b)
{
    Console.Write("Меньшее число: b. Большее число: " + a);
}
else
{
    Console.Write("Меньшее число: a. Большее число: " +  b);
}