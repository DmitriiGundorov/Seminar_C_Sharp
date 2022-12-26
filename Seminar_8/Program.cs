// Методы
#region FillArray
static void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9) // Метод заполнения массива целочисленный
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

static void FillArrayDouble(double[,] numbers, int minValue = -9, int maxValue = 9) // Метод заполнения массива вещественный
{
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = Math.Round(rand.NextDouble() * (maxValue + Math.Abs(minValue)) + minValue, 2); // Заполнение от -9 до 9
        }
    }
}

#endregion FillArray

#region PrintArray
static void PrintArray(int[,] numbers, string message = "Вывод двумерного массива:") // Вывод целочисленного двумерного массива
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

static void PrintArray1(int[] numbers, string message = "Вывод двумерного массива:") // Вывод целочисленного одномерного массива
{
    int rows = numbers.Length;
    Console.WriteLine(message);
    for (int i = 0; i < rows; i++)
    {
        Console.Write($"{numbers[i]}\t");
    }
}

static void PrintArrayDouble(double[,] numbers, string message = "Вывод двумерного массива:") // Вывод вещественного массива
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

#endregion PrintArray

string Input(string inputText)
{
    Console.Write(inputText);
    return Console.ReadLine();
}


// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

void Example_53()
{
    Console.WriteLine("|    Задача 53     |");
    int rows = Convert.ToInt32(Input("Введите количество строк двумерного массива: "));
    int columns = Convert.ToInt32(Input("Введите количество столбцов двумерного массива: "));
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine();
    int indexMin = 0;
    int indexMax = rows - 1;
    for (int j = 0; j < columns; j++)
    {
        (numbers[indexMin, j], numbers[indexMax, j]) = (numbers[indexMax, j], numbers[indexMin, j]);
    }
    PrintArray(numbers);
}

// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это 
// невозможно, программа должна вывести сообщение для пользователя.

void Example_55()
{
    Console.WriteLine("|    Задача 55     |");
    int rows = Convert.ToInt32(Input("Введите количество строк двумерного массива: "));
    int columns = Convert.ToInt32(Input("Введите количество столбцов двумерного массива: "));
    if (rows != columns) Console.WriteLine("Некорректный ввод");
    else
    {
        int[,] numbers = new int[rows, columns];
        FillArray(numbers);
        PrintArray(numbers);
        Console.WriteLine();
        for (int i = 0; i < rows; i++)
        {
            for (int j = i; j < columns; j++)
            {
                int temp = numbers[i, j];
                numbers[i, j] = numbers[j, i];
                numbers[j, i] = temp;
            }
        }
        PrintArray(numbers);
    }
}

// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается 
// элемент входных данных.

void Example_57()
{
    Console.WriteLine("|    Задача 57     |");
    int rows = Convert.ToInt32(Input("Введите количество строк двумерного массива: "));
    int columns = Convert.ToInt32(Input("Введите количество столбцов двумерного массива: "));
    int[,] numbers = new int[rows, columns];
    int maxValue = 20;
    int minValue = 0;
    FillArray(numbers, minValue, maxValue);
    PrintArray(numbers);
    Console.WriteLine();
    int[] dictionary = new int[Math.Abs(maxValue - minValue + 1)];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            dictionary[numbers[i, j]]++;
        }
    }
    PrintDictionary(dictionary, "Вывод словаря");
}

void PrintDictionary(int[] numbers, string message = "Вывод двумерного массива:")
{
    int rows = numbers.Length;
    Console.WriteLine(message);
    for (int i = 0; i < rows; i++)
    {
        if (numbers[i] > 0)
            Console.WriteLine($"Число {i} встречается: {numbers[i]} раз(а)");
    }
}

Example_53();
Example_55();
Example_57();