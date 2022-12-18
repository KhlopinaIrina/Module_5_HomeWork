// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine());

if (N > 0)
{
    int a = 2;
    while (a <= N)
    {
        Console.Write($"{a}, ");
        a = a + 2;
    }
}
if (N < 0)
{
    int a = 0;
    while (a >= N)
    {
        Console.Write($"{a}, ");
        a = a - 2;
    }
}