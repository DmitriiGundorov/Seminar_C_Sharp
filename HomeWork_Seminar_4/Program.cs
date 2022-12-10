// Задача 25: Используя определение степени числа, напишите цикл, который 
// принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

void Example_25()
{
    Console.WriteLine("|    Задача 25     |");
    Random randA = new Random();
    int numberA = randA.Next(1, 10); // 0 не является натуральным числом
    Console.WriteLine("Введите натуральное число А:  " + numberA);

    Random randB = new Random();
    int numberB = randB.Next(1, 6);
    Console.WriteLine("Введите степень числа А:  " + numberB);

    DateTime now = DateTime.Now;
    Console.WriteLine($"{numberA} ^ {numberB} = {Math.Pow(numberA, numberB)}"); // Метод матиматический
    Console.WriteLine(DateTime.Now - now);

    // Решение с помощью цикла. Более быстрый алгоритм решения
    now = DateTime.Now;
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {result}");
    Console.WriteLine(DateTime.Now - now);
}

// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.

void Example_27()
{
    Console.WriteLine("|    Задача 27     |");
    Random rand = new Random();
    int number = rand.Next(1, 1000);
    Console.WriteLine("Введите число от 1 до 1000:  " + number);
    int sum = 0;
    int digit = 0;
    while (number > 0)
    {
        digit = number % 10;
        sum += digit;
        number /= 10;
    }
    Console.WriteLine("Сумма цифр введенного числа: " + sum);
}

// Задача 29: Напишите программу, которая задаёт массив из 8 случайных
// целых чисел и выводит отсортированный по модулю массив.

void Example_29()
{
    Console.WriteLine("|    Задача 29     |");
    int size = 8;
    Random rand = new Random();
    int[] numbers = new int[size];
    int value = size - 1;
    Console.Write("Исходный массив:  ");
    for (int i = 0; i < size; i++)
    {
        numbers[i] = rand.Next(-100, 100);
        Console.Write(numbers[i] + "  ");
    }
    Console.WriteLine();
    for (int i = 0; i < value; i++)
    {
        for (int j = 0; j < value - i; j++)
        {
            if (Math.Abs(numbers[j]) > Math.Abs(numbers[j + 1]))
            {
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }
    Console.Write("Отсортированный по модулю массив:  ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + "  ");
    }
}

Example_25();
Example_27();
Example_29();