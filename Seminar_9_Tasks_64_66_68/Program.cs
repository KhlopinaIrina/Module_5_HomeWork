// Домашнее задание к Семинару 9 "Рекурсия"
HomeWork();


void HomeWork()
{
    Console.Clear();
    bool isWorking = true;
    Console.WriteLine("В состав Домашнего задания к Семинару 9 входят следующие задачи 64, 66 и 68");
	while (isWorking)
    {
        Console.WriteLine("=================================================================");
        Console.Write("Введите номер требуемой задачи (64, 66, 68 или exit): ");
		switch (Console.ReadLine())
		{
			case "64": Console.WriteLine("Задача 64:");
                    Console.WriteLine("Задайте значение N. Напишите программу, которая выведет все натуральные");
                    Console.WriteLine("числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
                    Task64(); break;
			case "66": Console.WriteLine("Задача 66:");
                    Console.WriteLine("Задайте значения M и N. Напишите программу,");
                    Console.WriteLine("которая найдёт сумму натуральных элементов в промежутке от M до N.");
                    Task66(); break;
            case "68": Console.WriteLine("Задача 68:");
                    Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии.");
                    Console.WriteLine("Даны два неотрицательных числа m и n.");
                    Task68(); break;        
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}


// Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
void Task64()
{
    Console.WriteLine("Решение:");
    int n = ReadInt("N: ");
    PrintNumbersFromNTo (n);
}


// Задача 66. Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
void Task66()
{
    Console.WriteLine("Решение:");
    int m = ReadInt("M: ");
    int n = ReadInt("N: ");
    Console.WriteLine(SumBetweenMandN (m, n));
}


// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии.,
// Даны два неотрицательных числа m и n.
void Task68()
{
    Console.WriteLine("Решение:");
    int m = ReadInt("m (НЕ больше 3): ");
    int n = ReadInt("n: ");
    Console.WriteLine(FunctionAkkerman(m, n));
}



// Методы, необходимые для решения, поставленных задач
// Метод введения числа от пользователя
int ReadInt(string argumentName)
{
	Console.Write($"Введите число {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

// Метод вывода натуральных чисел в промежутке от числа N до 1 (по убыванию)
void PrintNumbersFromNTo (int n)
{
    if (n <= 1)
    {
        Console.WriteLine(n);
        return;
    }
    Console.Write($"{n}, ");
    PrintNumbersFromNTo (n - 1);
}


// Метод нахождения суммы натуральных чисел в заданном промежутке
int SumBetweenMandN (int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m + SumBetweenMandN (m + 1, n);
}


// Метод вычисления функции Аккермана
int FunctionAkkerman (int m, int n)
{
    if (m == 0) return n + 1;
    else if ((m != 0) && (n == 0)) return FunctionAkkerman (m - 1, 1);
    else return FunctionAkkerman (m - 1, FunctionAkkerman (m, n - 1));
}