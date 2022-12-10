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
    Console.WriteLine("Введите натуральное число B:  " + numberB);

    DateTime now = DateTime.Now;
    Console.WriteLine($"Число {numberA} ^ {numberB} = {Math.Pow(numberA, numberB)}"); // Метод матиматический
    Console.WriteLine(DateTime.Now - now);

    // Решение с помощью цикла. Более быстрый алгоритм решения
    now = DateTime.Now;
    for (int i = 1; i < numberB; i++)
    {
        numberA = numberA * numberA;
    }
    Console.WriteLine("Число А в степени В равно  " + numberA);
    Console.WriteLine(DateTime.Now - now);
}
//Example_25();

// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.

void Example_27()
{
    Console.WriteLine("|    Задача 27     |");
    Random rand = new Random();
    int number = rand.Next(1, 1000);
    Console.WriteLine("Введите число от 1 до 1000:  " + number);
    int size=number.Length;
    string numbers = number;
     for (int i = 0; i < size; i++)
     {
        numbers[i]=number[i]+number[i+1];
     }
    Console.WriteLine(numbers[i]);
}
Example_27();


// Задача 29: Напишите программу, которая задаёт массив из 8 случайных
// целых чисел и выводит отсортированный по модулю массив.
void Example_29()
{
Console.WriteLine("|    Задача 29     |");

}
//Example_29();