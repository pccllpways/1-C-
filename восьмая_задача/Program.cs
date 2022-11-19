Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
Console.WriteLine();
int n = int.Parse(str);
    
for (int i = 1; i <= n; i++)
    if (i % 2 == 0)
    {
        Console.WriteLine("чётные числа: " + i);
    }