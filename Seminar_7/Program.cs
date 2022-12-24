// Методы

void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
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

void CustomFillArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = i + j;
        }
    }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine();
    }
}


// Задача 46. Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

void Example_46()
{
    Console.WriteLine("|    Задача 46     |");
    int rows = 3;
    int columns = 4;

    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
}

// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: A = m+n. 
// Выведите полученный массив на экран.

void Example_48()
{
    Console.WriteLine("|    Задача 48     |");

    Console.Write("Введите количество строк двумерного массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов двумерного массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[rows, columns];
    CustomFillArray(numbers);
    Console.WriteLine("Вывод двумерного массива:");
    PrintArray(numbers);
}

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых
// оба индекса чётные, и замените эти элементы на их квадраты.

void Example_49()
{
    Console.WriteLine("|    Задача 49     |");

    Console.Write("Введите количество строк двумерного массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов двумерного массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, 4, 9);
    Console.WriteLine("Вывод двумерного массива:");
    PrintArray(numbers);
    Console.WriteLine();
    /* for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 == 0 && j % 2 == 0) numbers[i, j] = numbers[i, j] * numbers[i, j];
        }
    }*/
    for (int i = 0; i < rows; i += 2)
    {
        for (int j = 0; j < columns; j += 2)
        {
            numbers[i, j] = numbers[i, j] * numbers[i, j];
        }
    }
    Console.WriteLine("Вывод преобразованного двумерного массива:");
    PrintArray(numbers);
}

// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

void Example_51()
{
    Console.WriteLine("|    Задача 51     |");

    Console.Write("Введите количество строк двумерного массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов двумерного массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    Console.WriteLine("Вывод двумерного массива:");
    PrintArray(numbers);
    Console.WriteLine();
    int sum = 0;
    /* Два цикла
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j) sum += numbers[i, j];
        }
    }
    */
    // или int min = rows;
    //if (rows > columns) min = columns;
    // или 
    int min = Math.Min (rows, columns);
    for (int i = 0; i < min; i++) sum += numbers[i, i];

    Console.WriteLine($"Сумма чисел главной диагонали массива: {sum}");
}

// Example_46();
// Example_48();
// Example_49();
Example_51();