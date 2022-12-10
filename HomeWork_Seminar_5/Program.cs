
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
//Example_34();

// Задача 36: Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов с нечётными индексами.

void Example_36()
{
    Console.WriteLine("|    Задача 36     |");
    int size = 912;

    Console.WriteLine(size % 2);
}
//Example_36();

// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным элементов массива.
