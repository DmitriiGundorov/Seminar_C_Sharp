// Методы

void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9) // Метод заполнения массива целочисленный
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
        }
    }
}

void FillArrayDouble(double[,] numbers, int minValue = 0, int maxValue = 9) // Метод заполнения массива вещественный
{
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round(rand.NextDouble() * (maxValue), 1);
        }
    }
}


void PrintArray(int[,] numbers, string message = "Вывод двумерного массива:") // Вывод целочисленного двумерного массива
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Console.WriteLine(message);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArrayDouble(double[,] numbers, string message = "Вывод двумерного массива:") // Вывод вещественного массива
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    Console.WriteLine(message);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}


// Задача 47: Задайте двумерный массив размером m×n, заполненный
// случайными вещественными числами, округлёнными до одного знака.

void Example_47()
{
    Console.WriteLine("|    Задача 47     |");
    Console.Write("Введите количество строк двумерного массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов двумерного массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] numbers = new double[rows, columns];
    FillArrayDouble(numbers);
    PrintArrayDouble(numbers);
}

// Задача 50. Напишите программу, которая на вход принимает 
// индексы элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.

void Example_50()
{
    Console.WriteLine("|    Задача 50     |");
    int rows = 5;
    int columns = 5;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers, $"Вывод двумерного массива [{rows} x {columns}]");
    Console.Write("Введите номер строки массива:  ");
    int indexRowInput = (Convert.ToInt32(Console.ReadLine())) - 1;
    Console.Write("Введите номер столбца массива:  ");
    int indexColumnsInput = (Convert.ToInt32(Console.ReadLine())) - 1;
    if (indexRowInput < rows && indexColumnsInput < columns &&
        indexRowInput >= 0 && indexColumnsInput >= 0)
    {
        Console.WriteLine($"Искомый элемент массива -> {numbers[indexRowInput, indexColumnsInput]}");
    }
    else Console.WriteLine($"Элемента массива с номером строки {indexRowInput + 1} и номером столбца {indexColumnsInput + 1} не существует");
}

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void Example_52()
{
    Console.WriteLine("|    Задача 52     |");
    int rows = 5;
    int columns = 5;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers, $"\nВывод двумерного массива [{rows} x {columns}]\n");
    Console.WriteLine("\nСреднее арифметическое элементов столбцов\n");
    for (int i = 0; i < columns; i++)
    {
        double sum = 0;
        for (int j = 0; j < rows; j++)
        {
            sum += numbers[j, i];
        }
        double result = sum / rows;
        Console.Write($"{result}\t");
    }
}

Example_47();
Example_50();
Example_52();