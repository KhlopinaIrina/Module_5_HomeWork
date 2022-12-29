// Домашнее задание к Семинару 8 "Двумерные массивы. Продолжение."
HomeWork();


void HomeWork()
{
    Console.Clear();
    bool isWorking = true;
    Console.WriteLine("В состав Домашнего задания к Семинару 8 входят следующие задачи 54, 56, 58, 60 и 62");
	while (isWorking)
    {
        Console.WriteLine("=================================================================");
        Console.Write("Введите номер требуемой задачи (54, 56, 58, 60, 62 или exit): ");
		switch (Console.ReadLine())
		{
			case "54": Console.WriteLine("Задача 54:");
                    Console.WriteLine("Задайте двумерный массив. Напишите программу,");
                    Console.WriteLine("которая упорядочит по убыванию элементы каждой строки двумерного массива.");
                    Task54(); break;
			case "56": Console.WriteLine("Задача 56:");
                    Console.WriteLine("Задайте прямоугольный двумерный массив. Напишите программу,");
                    Console.WriteLine("которая будет находить строку с наименьшей суммой элементов.");
                    Task56(); break;
            case "58": Console.WriteLine("Задача 58:");
                    Console.WriteLine("Задайте две матрицы. Напишите программу,");
                    Console.WriteLine("которая будет находить произведение двух матриц.");
                    Task58(); break;
            case "60": Console.WriteLine("Задача 60:");
                    Console.WriteLine("Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Массив размером 2 x 2 x 2.");
                    Console.WriteLine("Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
                    Task60(); break;
            case "62": Console.WriteLine("Задача 62:");
                    Console.WriteLine("Напишите программу, которая заполнит спирально массив 4 на 4.");
                    Task62(); break;        
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}


// Задача 54. Задайте прямоугольный двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
void Task54()
{
    Console.WriteLine("Решение:");
    int rowsNumber = ReadInt("Количество строк: ");
    int columnsNumber = ReadInt("Количество столбцов: ");
    int [,] newMatrix = GetMatrix(rowsNumber, columnsNumber);
    Console.WriteLine("*************************************************************");
    PrintMatrix(newMatrix);
    Console.WriteLine("*************************************************************");
    SortingRowsFromMaxToMin(newMatrix);
    PrintMatrix(newMatrix);
}


// Задача 56. Задайте двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
void Task56()
{
    Console.WriteLine("Решение:");
    int rowsNumber = ReadInt("Количество строк: ");
    int columnsNumber = ReadInt("Количество столбцов: ");
    int [,] newMatrix = GetMatrix(rowsNumber, columnsNumber);
    Console.WriteLine("*************************************************************");
    PrintMatrix(newMatrix);
    Console.WriteLine("*************************************************************");
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {PositionMinElementFromArray(FindRowSumOfElements(newMatrix))}");
}


// Задача 58. Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
void Task58()
{
    Console.WriteLine("Решение:");
    int rowsA = ReadInt("Количество строк матрицы A: ");
    int columnsA = ReadInt("Количество столбцов матрицы A: ");
    int [,] matrixA = GetMatrix(rowsA, columnsA);
    PrintMatrix(matrixA);
    Console.WriteLine("*************************************************************");
    int rowsB = ReadInt("Количество строк матрицы B: ");
    int columnsB = ReadInt("Количество столбцов матрицы B: ");
    int [,] matrixB = GetMatrix(rowsB, columnsB);
    PrintMatrix(matrixB);
    Console.WriteLine("*************************************************************");
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Операция умножения заданных матриц НЕВЫПОЛНИМА");
    }
    else
    {
        Console.WriteLine("matrixC = matrixA * matrixB:");
        PrintMatrix(ProductOfMatrix(matrixA, matrixB));
    }
}


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Массив размером 2 x 2 x 2.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
void Task60()
{
    Console.WriteLine("Решение:");
    Console.WriteLine("*************************************************************");
    PrintTreeDArrayOnStrings(GetTreeDArray());
}


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
void Task62()
{
    Console.WriteLine("Решение:");
    int[,] spiralMatrix = new int[4, 4];
    int i = 0;
    int j = 0;
    spiralMatrix[0, 0] = 1;
    for (j = 1; j < 4; j++)
    {
        spiralMatrix[0, j] = spiralMatrix[0, j-1] + 1;
    }
    for (i = 1; i < 4; i++)
    {
        spiralMatrix[i, 3] = spiralMatrix[i-1, 3] + 1;
    }
    for (j = 2; j >=0; j--)
    {
        spiralMatrix[3, j] = spiralMatrix[3, j+1] + 1;
    }
    for (i = 2; i > 0; i--)
    {
        spiralMatrix[i, 0] = spiralMatrix[i + 1, 0] + 1;
    }
    for (j = 1; j < 3; j++)
    {
        spiralMatrix[1, j] = spiralMatrix[1, j-1] + 1;
    }
    spiralMatrix[2, 2] = spiralMatrix[1, 2] + 1;
    spiralMatrix[2, 1] = spiralMatrix[2, 2] + 1;
    PrintMatrix(spiralMatrix);
}
    

// Методы, необходимые для решения, поставленных задач
// Метод введения числа от пользователя
int ReadInt(string argumentName)
{
	Console.Write($"Введите число {argumentName}: ");
	return int.Parse(Console.ReadLine());
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


// Метод сортировки строк двумерного массива от большего элемента к меньшему
void SortingRowsFromMaxToMin(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            int maxRowPosition = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] > matrix[i, maxRowPosition])
                {
                    maxRowPosition = k;
                }
            }
            int temporary = matrix[i, j];
            matrix[i, j] = matrix[i, maxRowPosition];
            matrix[i, maxRowPosition] = temporary;
        }
    }
}


// Метод нахождения суммы элементов в каждой строке массива
int[] FindRowSumOfElements(int[,] matrix)
{
    int[] rowSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        rowSum[i] = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum[i]= rowSum[i] + matrix[i, j];
        }
    }
    return rowSum;
}


// Метод нахождения позиции минимального элемента массива
int PositionMinElementFromArray(int[] array)
{
    int min = array[0];
    int position = 1;
    for (int i = 0; i < array.Length; i++)
	{ 
       if (array[i] < min)
       {
            min = array[i];
            position = i + 1;
       }
    }
    return position;
}


// Метод нахождения произведения двух матриц
int[,] ProductOfMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] matrixProduct = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)];
        for (int i = 0; i < matrixProduct.GetLength(0); i++)
        {
            for (int j = 0; j < matrixProduct.GetLength(1); j++)
            {
                matrixProduct[i,j] = 0;
                for (int k = 0; k < matrixFirst.GetLength(1); k++)
                {
                    matrixProduct[i,j] = matrixProduct[i,j] + matrixFirst[i, k] * matrixSecond[k,j];
                }
            }
        }
        return matrixProduct;
}


// Метод создания трехмерного массива 2*2*2, заполненного неповторяющимися случайными целыми числами
int[, ,] GetTreeDArray()
{
    Random random = new Random();
    int minValue = 1;
    int maxValue = 11;
    int [, ,] threeDArray = new int[2, 2, 2]; 
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                threeDArray[i, j, k] = random.Next(minValue, maxValue);
                minValue = minValue + 10;
                maxValue = maxValue + 10;
            }
        }
    }
    return threeDArray;
}


// Метод вывода трехмерного массива 2*2*2 построчно (элементы + индексы).
void PrintTreeDArrayOnStrings (int[, ,] threeDArray)
{
    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            Console.Write($" {threeDArray[i, j, k]}[{i}, {j}, {k}]  ");
            Console.WriteLine();
        }
    }
}