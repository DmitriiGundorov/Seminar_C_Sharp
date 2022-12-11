
void FillArray(int[] nums, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] nums)
{
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + "  ");
    }
    Console.WriteLine();
}

// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

void Example_34()
{
    Console.WriteLine("|    Задача 34     |");
    int size = 10;
    int count = 0;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 1000);
    Console.Write("Заданный массив:  ");
    PrintArray(numbers);
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] % 2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел в массиве - > {count}");
}

// Задача 36: Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов с нечётными индексами.

void Example_36()
{
    Console.WriteLine("|    Задача 36     |");
    int size = 10;
    int sum = 0;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 10);
    Console.Write("Заданный массив:  ");
    PrintArray(numbers);
    for (int i = 1; i < size; i += 2)
    {
        sum += numbers[i];
    }
    Console.WriteLine($"Сумма элементов с нечетными индексами массива - > {sum}");
}

// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным элементов массива.

void Example_38()
{
    Console.WriteLine("|    Задача 38     |");
    int size = 6;
    double[] numbers = new double[size];
    Random rand = new Random();
    double delitel = 100;
    double numberMax = 0;
    double numberMin = 100;
    for (int i = 0; i < size; i++)
    {
        numbers[i] = rand.Next(1000, 10000) / delitel;
    }
    Console.WriteLine("   Заданный массив:");
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
    //double numberMin = numbers[0];
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] > numberMax) numberMax = numbers[i];
        if (numbers[i] <= numberMin) numberMin = numbers[i];
    }
    Console.WriteLine("Минимальное значение массива:  " + numberMin);
    Console.WriteLine("Максимальное значение массива:  " + numberMax);
    Console.WriteLine($"Разница между минимальным и максимальным значением массива - > {numberMax - numberMin}");
}

Example_34();
Example_36();
Example_38();