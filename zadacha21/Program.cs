// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// Числа координат целые, автоматически генерируются из диапазона от -9 до 9. 

int x1 = new Random().Next(-9, 10);
int y1 = new Random().Next(-9, 10);
int z1 = new Random().Next(-9, 10);

int x2 = new Random().Next(-9, 10);
int y2 = new Random().Next(-9, 10);
int z2 = new Random().Next(-9, 10);

double d = Math.Pow((Math.Pow(x2 - x1, 2) +
Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);

Console.WriteLine("x1 = " + x1);
Console.WriteLine("y1 = " + y1);
Console.WriteLine("z1 = " + z1);
Console.WriteLine("x2 = " + x2);
Console.WriteLine("y2 = " + y2);
Console.WriteLine("z2 = " + z2);
Console.WriteLine("Расстояние между точками: " + d);