// Задание 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
Console.WriteLine("Задача 9. Напишите программу, которая выводит случайное число из отрезка (полуинтервала) [10, 99) и показывает наибольшую цифру числа.");
/*
void Example_9()
{

    Random rand = new Random();
    int number = rand.Next(10, 100);
    Console.WriteLine("Случайное число:  " + number);
    int tens = number / 10;
    int ones = number % 10;
    Console.Write("Наибольшая цифра числа:  ");
    if (tens > ones)
    {
        Console.WriteLine(tens);
    }
    else
    {
        Console.WriteLine(ones);
    }
}
Example_9();*/

// Решение преподавателя
void Example_9_1()
{
    int number = GenerateNumber();
    Console.WriteLine("Случайное число:  " + number);
    Console.Write("Наибольшая цифра числа:  " + MaxDigit(number));

    int GenerateNumber()
    {
        return new Random().Next(10, 100);
    }

    int MaxDigit(int number)
    {
        int tens = number / 10;
        int ones = number % 10;

        if (tens > ones)
        {
            return tens;
        }
        else
        {
            return ones;
        }
    }
}
Example_9_1();