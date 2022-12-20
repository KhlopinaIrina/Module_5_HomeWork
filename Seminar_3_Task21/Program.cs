// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2

Console.Write("Введите координату Xa: ");
int Xa = int.Parse(Console.ReadLine());

Console.Write("Введите координату Ya: ");
int Ya = int.Parse(Console.ReadLine());

Console.Write("Введите координату Za: ");
int Za = int.Parse(Console.ReadLine());

Console.WriteLine("===============================");

Console.Write("Введите координату Xb: ");
int Xb = int.Parse(Console.ReadLine());

Console.Write("Введите координату Yb: ");
int Yb = int.Parse(Console.ReadLine());

Console.Write("Введите координату Zb: ");
int Zb = int.Parse(Console.ReadLine());

Console.WriteLine("===============================");

double resultAB = Math.Sqrt(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2));

Console.WriteLine($"Расстояние между заданными точками: {resultAB}");