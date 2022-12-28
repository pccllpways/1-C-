// Задача 64: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int Number(string str)
{
    Console.Write(str);
    int number1 = Convert.ToInt32(Console.ReadLine());;
    return number1;
}

string Recursion(int number)
{
   if (number == 1) return number.ToString();
   
   return number + " " + Recursion(number - 1);
}

int number1 = Number("Введите число: ");
Console.WriteLine();
Console.Write(Recursion(number: number1));