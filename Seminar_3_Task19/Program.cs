// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите целое ПЯТИзначное число: ");
int value = int.Parse(Console.ReadLine());

// Выделяем разряды введенного числа
int digit5 = value / 10000;
int digit4 = (value / 1000) % 10;
int digit3 = (value / 100) % 10;
int digit2 = (value / 10) % 10;
int digit1 = value % 10;

if ((digit5 == digit1) && (digit4 == digit2))
{
    Console.WriteLine($"Число {value} является полиндромом");
}
else
{
    Console.WriteLine($"Число {value} НЕ является полиндромом");
}