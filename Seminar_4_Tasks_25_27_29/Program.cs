// Домашнее задание к Семинару 4 "Функции"
HomeWork4();


void HomeWork4()
{
    Console.Clear();
    bool isWorking = true;
    Console.WriteLine("В состав Домашнего задания к Семинару 4 входят следующие задачи 25, 27 и 29");
	while (isWorking)
    {
        Console.WriteLine("=================================================================");
        Console.Write("Введите номер требуемой задачи (25, 27, 29 или exit): ");
		switch (Console.ReadLine())
		{
			case "25": Console.WriteLine("Задача 25:");
                    Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и");
                    Console.WriteLine("возводит число A в натуральную степень B.");
                    Task25(); break;
			case "27": Console.WriteLine("Задача 27:");
                    Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт");
                    Console.WriteLine("сумму цифр в числе.");
                    Task27(); break;
			case "29": Console.WriteLine("Задача 29:");
                    Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и");
                    Console.WriteLine("выводит их на экран.");
                    Task29(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}



// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void Task25()
{
    Console.WriteLine("Решение:");
    int numberA = ReadInt("Number A");
    int numberB = ReadInt("Number B");
    Console.WriteLine($"Степень {numberB} числа {numberA} равна {ExpOfNamber(numberA, numberB)}");
}

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Task27()
{
    Console.WriteLine("Решение:");
    int number = ReadInt("Number");
    SumOfNamberDigits(number);
    Console.WriteLine($"Сумма цифр числа {number} равна: {SumOfNamberDigits(number)}");
}
    
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void Task29()
{
Console.WriteLine("Решение:");
int size = ReadInt("Размер массива");
int minArray = ReadInt("Минимальный возможный элемент массива");
int maxArray = ReadInt("Максимальный возможный элемент массива");
int [] ArrayTask = GetArray(size, minArray, maxArray);
Console.WriteLine(ArrayToString(ArrayTask));
}

 
// Методы, необходимые для решения, поставленных задач
// Метод: Введение числа от пользователя
int ReadInt(string argumentName)
{
	Console.Write($"Введите число {argumentName}: ");
	return int.Parse(Console.ReadLine());
}


// Метод: Возведение числа в натуральную степень
int ExpOfNamber(int Base, int exponent)
{
    int result = 1;
    int i = 0;

    while (i < exponent)
    {
        result = result * Base;
        i = i + 1;
    }
    return (result);
}


// Mетод, преобразующий число в массив и отдающий сумму элементов массива
int SumOfNamberDigits(int num)
{
    string numberString = num.ToString();
    int n = numberString.Length;
    double result = 0;
    int i = 0;
    int Sum = 0;

    for (i = 0; i < numberString.Length; i++)
    {
        if (i == 0)
        {
            result = num / Math.Pow(10, (n - 1));
            Sum = Sum + (int) result;
        }
        if ((i > 0) && (i < (numberString.Length - 1)))
        {
            result = num / Math.Pow(10, (n - (i + 1))) % 10;
            Sum = Sum + (int) result;
        }
        if (i == (numberString.Length - 1))
        {
            result = num % 10;
            Sum = Sum + (int) result;
        }
    }
    return Sum;
}
    

// Метод заполнения массива, заданного размера, случайными числами в заданном диапазоне
int[] GetArray(int length, int min, int max)
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(min, (max+1));
	}
	return array;
}


// Метод вывода массива на экран в виде строки
string ArrayToString(int[] array)
{
	string result = string.Empty;

	for (int i = 0; i < array.Length; i++)
	{
        if (i == (array.Length - 1))
        {
           result += $"{array[i]}."; 
        }
        else
        {
           result += $"{array[i]}, ";
        }
    }
	return result;
}