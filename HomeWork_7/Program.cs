﻿// Методы

void FillArrayDouble(double[,] numbers, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        double valuei = rand.NextDouble() * 20 - 10;
        numbers[i] = Math.Round(valuei, 2);
        for (int j = 0; j < columns; j++)
        {
            double valuej = rand.NextDouble() * 20 - 10;
            numbers[j] = Math.Round(valuej, 2);
        }
    }
}

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


void PrintArray(double[,] numbers)
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
    PrintArray(numbers);
}

// Задача 50. Напишите программу, которая на вход принимает 
// индексы элемента в двумерном массиве, и возвращает значение
// этого элемента или же указание, что такого элемента нет.

void Example_50()
{
    Console.WriteLine("|    Задача 50     |");
    Console.Write("Введите количество строк двумерного массива: ");

}

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void Example_52()
{
    Console.WriteLine("|    Задача 52     |");
    Console.Write("Введите количество строк двумерного массива: ");

}


Example_47();
//Example_50();
//Example_52();