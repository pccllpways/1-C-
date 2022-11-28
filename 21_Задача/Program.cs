// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату x первой точки");
double firstX = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
double firstY = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату c первой точки");
double firstC = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату x первой точки");
double secondX = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
double secondY = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату c первой точки");
double secondC = double.Parse(Console.ReadLine());

double distAB = Math.Sqrt(Math.Pow(secondX - firstX , 2) + Math.Pow(secondY - firstY, 2) + Math.Pow(secondC - firstC, 2));
Console.WriteLine("Расстояние между двух точек: " + distAB);