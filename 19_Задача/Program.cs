// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string str = Console.ReadLine();
int num = int.Parse(str);
void palindrom()
{
if (num >= 10000 && num <= 99999)
{
    int copy_num = num;
    int result = 0;
    while (copy_num > 0)
    {
        int digit = copy_num % 10;
        result = result * 10 + digit;
        copy_num /= 10;
    }
    if (num == result)
    {
        Console.WriteLine("Число палиндром");
    }
    else
    {
        Console.WriteLine("Число не палиндром");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
}
}