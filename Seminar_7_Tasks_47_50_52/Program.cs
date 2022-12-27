// Домашнее задание к Семинару 7 "Двумерные массивы"
HomeWork();


void HomeWork()
{
    Console.Clear();
    bool isWorking = true;
    Console.WriteLine("В состав Домашнего задания к Семинару 7 входят следующие задачи 47, 50 и 52");
	while (isWorking)
    {
        Console.WriteLine("=================================================================");
        Console.Write("Введите номер требуемой задачи (47, 50, 52 или exit): ");
		switch (Console.ReadLine())
		{
			case "47": Console.WriteLine("Задача 47:");
                    Console.WriteLine("Задайте двумерный массив размером m*n,");
                    Console.WriteLine("заполненный случайными вещественными числами.");
                    Task47(); break;
			case "50": Console.WriteLine("Задача 50:");
                    Console.WriteLine("Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,");
                    Console.WriteLine("и возвращает значение этого элемента или же указание, что такого элемента нет.");
                    Task50(); break;
            case "52": Console.WriteLine("Задача 52:");
                    Console.WriteLine("Задайте двумерный массив из целых чисел.");
                    Console.WriteLine("Найдите среднее арифметическое элементов в каждом столбце.");
                    Task52(); break;        
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}

// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
void Task47()
{
    Console.WriteLine("Решение:");
    int rowsNumber = ReadInt("Количество строк m: ");
    int columnsNumber = ReadInt("Количество столбцов n: ");
    double[,] newDoubleMatrix = GetDoubleMatrix (rowsNumber, columnsNumber);
    Console.WriteLine("*************************************************************");
    PrintDoubleMatrix (newDoubleMatrix);
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void Task50()
{
    Console.WriteLine("Решение:");
    int rowsNumber = ReadInt("Количество строк m: ");
    int columnsNumber = ReadInt("Количество столбцов n: ");
    double[,] doubleMatrix = GetDoubleMatrix (rowsNumber, columnsNumber);
    Console.WriteLine("*************************************************************");
    PrintDoubleMatrix (doubleMatrix);
    Console.WriteLine("*************************************************************");
    FindElementByInexFromMatrix (doubleMatrix);
}


// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
void Task52()
{
    Console.WriteLine("Решение:");
    int rowsNumber = ReadInt("Количество строк: ");
    int columnsNumber = ReadInt("Количество столбцов: ");
    int [,] newMatrix = GetMatrix(rowsNumber, columnsNumber);
    Console.WriteLine("*************************************************************");
    PrintMatrix(newMatrix);
    Console.WriteLine("*************************************************************");
    PrintArrayByString(ArrayColumnsAverage (newMatrix));
}






// Методы, необходимые для решения, поставленных задач
// Метод введения числа от пользователя
int ReadInt(string argumentName)
{
	Console.Write($"Введите число {argumentName}: ");
	return int.Parse(Console.ReadLine());
}


// Метод создания двумерного массива, заполненного случайными вещественными числами
double[,] GetDoubleMatrix (int rows, int columns)
{
    Random random = new Random();
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = Math.Round(random.NextDouble() * 10, 3);
        }
    }
    return matrix;
}


// Метод вывода двумерного массива на экран
void PrintDoubleMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"  {matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}


// Метод создания двумерного массива, заполненного случайными целыми числами
int[,] GetMatrix (int rows, int columns)
{
    Random random = new Random();
    int[,] matrix = new int[rows, columns]; 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(10);  
        }
    }
    return matrix;
}


// Метод вывода двумерного массива на экран
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


// Метод вычлинения элемента двумерного массива по заданным позициям
void FindElementByInexFromMatrix (double[,] matrix)
{
    int rowPosition = ReadInt("Номер строки: ");
    int columnPosition = ReadInt("Номер столбца: ");
    if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
    {
        Console.WriteLine($"Элемента c индексами [{rowPosition}, {columnPosition}] не существует в заданном массиве.");
    }
    else
    {
        Console.WriteLine($"Искомый элемент: {matrix[rowPosition - 1, columnPosition - 1]}");
    }
}


// Meтод нахождения среднего арифметического в каждом столбце матрицы
double[] ArrayColumnsAverage (int[,] matrix)
{
    double[] columnAverage = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int columnSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            columnSum =  columnSum + matrix[i, j];
        }
        columnAverage[j] = (double) columnSum / matrix.GetLength(0);
    }
    return columnAverage;
}


// Метод вывода массива на экран в виде строки
void PrintArrayByString(double[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
        if (i == (array.Length - 1))
        {
           Console.WriteLine($"{Math.Round(array[i], 2)}."); 
        }
        else
        {
           Console.Write($"{Math.Round(array[i], 2)}; ");
        }
    }
}