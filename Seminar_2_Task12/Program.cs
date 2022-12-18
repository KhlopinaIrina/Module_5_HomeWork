// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());

// Определяем разрядность введенного числа
int count = 0;
int temp = number;
while (temp > 0)
{
    temp = temp / 10;
    count = count + 1;
}   // Выдергиваем третью цифру
if (count >= 3) 
{
    double thirdNum = (number / Math.Pow(10, (count - 3))) % 10;
    Console.WriteLine("Третья цифра вашего числа: " + Math.Truncate(thirdNum));
}
else
{
    Console.WriteLine("Третьей цифры у вашего числа нет");
}