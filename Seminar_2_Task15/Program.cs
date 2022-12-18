// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите целое число от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

switch (number)
{
	case 1: Console.WriteLine("Ура! Сегодня понедельник! Наконец, на работу!"); break;
	case 2: Console.WriteLine("Сегодня вторник и я опять увижу начальника!"); break;
	case 3: Console.WriteLine("Среда! хоть поработаю спокойно: кипешные успокоились, пофигисты не проснулись"); break;
	case 4: Console.WriteLine("Четверг. Сегодня, наверное, схожу пообедать, все-таки"); break;
	case 5: Console.WriteLine("ПЯТНИЦА!!! Как много в этом слове..."); break;
	case 6: Console.WriteLine("Суббота. Отсыпной"); break;
	case 7: Console.WriteLine("Воскресенье. Осталось его пережить и снова на работу!"); break;
	default: Console.WriteLine("В неделе, увы, только 7 дней"); break;
}