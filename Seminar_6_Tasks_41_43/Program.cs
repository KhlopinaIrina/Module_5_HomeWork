// Домашнее задание к Семинару 6 "Одномерные массивы. Продолжение"
HomeWork();


void HomeWork()
{
    Console.Clear();
    bool isWorking = true;
    Console.WriteLine("В состав Домашнего задания к Семинару 6 входят следующие задачи 41 и 43");
	while (isWorking)
    {
        Console.WriteLine("=================================================================");
        Console.Write("Введите номер требуемой задачи (41, 43 или exit): ");
		switch (Console.ReadLine())
		{
			case "41": Console.WriteLine("Задача 41:");
                    Console.WriteLine("Пользователь вводит с клавиатуры M чисел.");
                    Console.WriteLine("Посчитайте, сколько чисел больше 0 ввёл пользователь.");
                    Task41(); break;
			case "43": Console.WriteLine("Задача 43:");
                    Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями");
                    Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
                    Task43(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}


// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Task41()
{
    Console.WriteLine("Решение:");
    int length = ReadInt("Размер массива");
    int[] array = FillArrayByHand(length);
    PrintArrayByString(array);
    NumberOfPositiveElements(array);
    Console.WriteLine($"Количество положительных (arrai[i] > 0) элементов массива равно: {NumberOfPositiveElements(array)}");
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. 
void Task43()
{
    Console.WriteLine("Решение:");
    int k1 = ReadInt("Угловой коэффициент 1-ой функции, k1 = ");
    int b1 = ReadInt("Свободный коэффициент 1-ой функции, b1 = ");
    int k2 = ReadInt("Угловой коэффициент 2-ой функции, k2 = ");
    int b2 = ReadInt("Свободный коэффициент 2-ой функции, b2 = ");
    if (k1 == k2)
    {
        Console.WriteLine($"заданные прямые параллельны и не имеют точек пересечения!");
    }
    else
    {
        double[] dot = CrossPoint(k1, b1, k2, b2);
        Console.WriteLine($"Координаты точки пересечения заданных прямых: (x = {dot[0]}, y = {dot[1]})"); 
    }
    
}
    


// Методы, необходимые для решения, поставленных задач
// Метод: Введение числа от пользователя
int ReadInt(string argumentName)
{
	Console.Write($"Введите число {argumentName}: ");
	return int.Parse(Console.ReadLine());
}


// Метод заполнения массива, заданного размера, пользователем
int[] FillArrayByHand(int length)
{
	int[] array = new int[length];
    
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"{i}-ый элемент массива");
	}
	return array;
}


// Метод вывода массива на экран в виде строки
void PrintArrayByString(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
        if (i == (array.Length - 1))
        {
           Console.WriteLine($"{array[i]}."); 
        }
        else
        {
           Console.Write($"{array[i]}, ");
        }
    }
}


// Метод подсчета количества положительных (arrai[i] > 0) элементов массива
int NumberOfPositiveElements(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    } 
    return count;
}


// Метод нахождения точки пересечения двух прямых
double[] CrossPoint(int angle1, int free1, int angle2, int free2)
{
    double[] point = new double [2];
    Console.WriteLine();
    Console.WriteLine("**********************************************************************************");
    Console.WriteLine("Для нахождения точки пересечения между заданными прямыми, нам необходимо решить систему уравнений:");
    Console.WriteLine("  y = k1 * x + b1");
    Console.WriteLine("и y = k2 * x + b2");
    point[0] = (double)(free2 - free1) / (angle1 - angle2);
    point[1] = (double)(angle2 * point[0] + free2);
    return point;
}