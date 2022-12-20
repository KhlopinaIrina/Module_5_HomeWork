// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine("===== Кубы чисел от 1 до N =====");

for(int count = 1; count <= N; count++)
{
    if(count !=N)
    {
       Console.Write(Math.Pow(count, 3) + ", "); 
    }
    if(count == N)
    {
        Console.WriteLine(Math.Pow(count, 3) + ".");
    }
}