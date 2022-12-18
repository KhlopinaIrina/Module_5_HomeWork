// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите целое число A: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите целое число B: ");
int numB = int.Parse(Console.ReadLine());

int max = numA;

if (max < numB)
{
    max = numB;
}
Console.WriteLine("max = " + max);