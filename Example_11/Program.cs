// Задача 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Console.WriteLine("Задача 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.");

void Example_11()
{
    Random rand = new Random();
    int number = rand.Next(1000);
    Console.WriteLine("Случайное число:  " + number);
    int hundreds = number / 100;
    //int tens = hundreds / 10;
    int ones = number % 10;
    //Console.WriteLine(hundreds);
    //Console.WriteLine(tens);
    //Console.WriteLine(ones);
    Console.WriteLine($"Новое число: {hundreds}{ones}");
}
//Example_11();

// Решение преподавателя
void Example_11_2()
{
    //int number = GenerateNumber(100, 999);
    Random rand = new Random();
    int number = rand.Next(100, 1000);
    Console.WriteLine("Случайное число:  " + number);
    Console.Write("Новое число: " + (number / 100*10 + number % 10));
}
/*
int GenerateNumber(int minValue, int maxValue)
{
    return new Random().Next(minValue, ++maxValue);
}*/

Example_11_2();