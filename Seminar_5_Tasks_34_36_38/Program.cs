// Домашнее задание к Семинару 5 "Функции и одномерные массивы"
HomeWork();


void HomeWork()
{
    Console.Clear();
    bool isWorking = true;
    Console.WriteLine("В состав Домашнего задания к Семинару 5 входят следующие задачи 34, 36 и 38");
	while (isWorking)
    {
        Console.WriteLine("=================================================================");
        Console.Write("Введите номер требуемой задачи (34, 36, 38 или exit): ");
		switch (Console.ReadLine())
		{
			case "34": Console.WriteLine("Задача 34:");
                    Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами.");
                    Console.WriteLine("Напишите программу, которая покажет количество чётных чисел в массиве.");
                    Task34(); break;
			case "36": Console.WriteLine("Задача 36:");
                    Console.WriteLine("Задайте одномерный массив, заполненный случайными числами.");
                    Console.WriteLine("Найдите сумму элементов, стоящих на нечётных позициях.");
                    Task36(); break;
			case "38": Console.WriteLine("Задача 38:");
                    Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным");
                    Console.WriteLine("и минимальным элементов массива.");
                    Task38(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
void Task34()
{
    Console.WriteLine("Решение:");
    int length = ReadInt("Размер массива");
    int[] array = GetRandomArray(length, 100, 1000);
    PrintArrayByString(array);
    NumberOfNumbers(array);
    Console.WriteLine($"Количество четных чисел в массиве равно: {NumberOfNumbers(array)}");
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
void Task36()
{
    Console.WriteLine("Решение:");
    int length = ReadInt("Размер массива");
    int minArray = ReadInt("Минимальный возможный элемент массива");
    int maxArray = ReadInt("Максимальный возможный элемент массива");
    int[] array = GetRandomArray(length, minArray, maxArray);
    PrintArrayByString(array);
    int sum = SumOfOddNamberPosition(array);
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, в заданном массиве равна: {sum}");
}
    
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
void Task38()
{
    Console.WriteLine("Решение:");
    int length = ReadInt("Размер массива");
    double[] array = GetRandomDoubleArray(length);
    PrintDoubleArrayByString(array);
    Console.WriteLine("*******************************************************************************************");
    Console.WriteLine($"Максимальный элемент массива: {MaxFromArray(array)};");
    Console.WriteLine($"Минимальный элемент массива: {MinFromArray(array)};");
    Console.WriteLine("*******************************************************************************************");
    double difference = MaxFromArray(array) - MinFromArray(array);
    Console.WriteLine($"Разность между максимальным и минимальным элементами заданного массива равна: {difference}.");
}


 
// Методы, необходимые для решения, поставленных задач
// Метод: Введение числа от пользователя
int ReadInt(string argumentName)
{
	Console.Write($"Введите число {argumentName}: ");
	return int.Parse(Console.ReadLine());
}


// Метод заполнения массива, заданного размера, случайными числами в заданном диапазоне
int[] GetRandomArray(int length, int min, int max)
{
	int[] array = new int[length];
    Random random = new Random();

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(min, (max+1));
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


// Метод подсчета количества четных элементов массива
int NumberOfNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    } 
    return count;
}


// Метод нахождения суммы элементов, стоящих на нечетных позициях в массиве
int SumOfOddNamberPosition(int[] array)
{
    int OddSum = 0;
    for (int i = 0; i < array.Length; i++)
	{
        if (i % 2 != 0)
		{
			OddSum += array[i];
		}
	}
    return OddSum;
}


// Метод заполнения массива, заданного размера, случайными вещественными числами в заданном диапазоне
double[] GetRandomDoubleArray(int length)
{
	double[] array = new double[length];
    Random random = new Random();
   
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = random.NextDouble() * 10;
	}
	return array;
}


// Метод вывода массива с вещественными элементами на экран в виде строки
void PrintDoubleArrayByString(double[] array)
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


// Метод нахождения минимального элемента массива
double MinFromArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
	{
       if (array[i] < min)
       min = array[i];
	}
    return min;
}


// Метод нахождения максимального элемента массива
double MaxFromArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
	{
       if (array[i] > max)
       max = array[i];
	}
    return max;
}