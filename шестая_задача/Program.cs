// a = 4
// a = -3
// a = 7

Console.WriteLine("Напишите число: ");
string str = Console.ReadLine();
int a = int.Parse(str);
if((a % 2) == 0)
{
    Console.WriteLine("чётное");
}
else
{
    Console.WriteLine("нечётное");
}