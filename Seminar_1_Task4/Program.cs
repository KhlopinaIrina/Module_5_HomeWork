// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите целое число A: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите целое число B: ");
int numB = int.Parse(Console.ReadLine());

Console.Write("Введите целое число C: ");
int numC = int.Parse(Console.ReadLine());

int max = numA;

if (max < numB)
{
    max = numB;
    if (max < numC)
    {
        max = numC;
    }
}
Console.WriteLine("max = " + max);