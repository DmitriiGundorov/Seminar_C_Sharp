// Методы
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

string Input(string inputText)
{
    Console.Write(inputText);
    return Console.ReadLine();
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

void Example_54()
{
    Console.WriteLine("|    Задача 54     |");
    int rows = Convert.ToInt32(Input("Введите количество строк двумерного массива: "));
    int columns = Convert.ToInt32(Input("Введите количество столбцов двумерного массива: "));
    int[,] numbers = new int[rows, columns];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    Console.WriteLine();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int index = 0; index < columns - j - 1; index++)
            {
                if (numbers[i, index] < numbers[i, index + 1])
                {
                    int temp = numbers[i, index];
                    numbers[i, index] = numbers[i, index + 1];
                    numbers[i, index + 1] = temp;
                }
            }
        }
    }
    PrintArray(numbers, "Вывод двумерного массива с отсортированными строками:");
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

void Example_56()
{
    Console.WriteLine("|    Задача 56     |");
    int rows = Convert.ToInt32(Input("Введите количество строк двумерного массива: "));
    int columns = Convert.ToInt32(Input("Введите количество столбцов двумерного массива: "));
    if (rows == columns) Console.WriteLine("Некорректный ввод, двумерный массив должен быть прямоугольный.");
    else
    {
        int[,] numbers = new int[rows, columns];
        FillArray(numbers);
        PrintArray(numbers);
        Console.WriteLine();
        int sumMin = 1000;
        int indexMin = 0;
        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < columns; j++) sum += numbers[i, j];

            if (sum < sumMin)
            {
                sumMin = sum;
                indexMin = i;
            }
        }
        Console.WriteLine($"Минимальная сумма двумерного массива -> {sumMin} расположена в строке -> {indexMin + 1}");
    }
}

// Задача 58: Заполните спирально массив 4 на 4 числами от 1 до 16.

void Example_58()
{
    Console.WriteLine("|    Задача 58     |");
    int rows = 4;
    int columns = 4;
    int indexRow = 0;
    int indexColumn = 0;
    int shiftRow = 0;
    int shiftColumn = 1;
    int steps = columns;
    int turn = 0;

    int[,] numbers = new int[rows, columns];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[indexRow, indexColumn] = i + 1;
        steps--;
        if (steps == 0)
        {
            steps = columns - 1 - turn / 2;
            int temp = shiftRow;
            shiftRow = shiftColumn;
            shiftColumn = -temp;
            turn++;
        }

        indexRow += shiftRow;
        indexColumn += shiftColumn;
    }
    PrintArray(numbers, "Вывод двумерного массива, заполненного по спирали.");
}

Example_54();
Example_56();
Example_58();