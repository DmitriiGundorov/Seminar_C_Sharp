void Example_12()
{
    // Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе 
    // число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

    Console.Write("Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли");
    Console.WriteLine(" второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.");

    Console.Write("Введите первое число: ");
    int numberFirst = Convert.ToInt32(Console.ReadLine());
    //int numberFirst = int.Parse(Console.ReadLine()); // Решение студентки
    Console.Write("Введите второе число: ");
    int numberSecond = Convert.ToInt32(Console.ReadLine());
    int function = numberFirst % numberSecond;//Функция
    if (function == 0)
    {
        Console.WriteLine($"Число {numberSecond} кратно {numberFirst} и делится без остатка");
        Console.WriteLine("Результат деления: " + numberFirst / numberSecond);
    }
    else
    {
        //int remains = (numberFirst % numberSecond);
        //Console.WriteLine($"Число {numberSecond} не кратно {numberFirst} и делится с остатком {remains}");
        Console.WriteLine($"Число {numberSecond} не кратно {numberFirst}" + $"\nОстаток равен: {function}"); // Решение студентки
    }
}
//Example_12();

void Example_14()
{
    // Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

    Console.WriteLine("Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    /*if (number % 7 == 0 & number % 23 == 0) 
    // & - и, | - или
    // && - краткий и, || - краткий или - если первое условие не выполнилось (и) то второе не обрабатывается, если первое условие выполнилось (или) то второе не обрабатывается
    {
        Console.WriteLine($"Число {number} КРАТНО числам 7 и 23");
    }
    else
    {
        Console.WriteLine($"Число {number} НЕ кратно числам 7 и 23");
    }*/
    // Решение студента
    int result = number % 7 + number % 23;
    if (result == 0)
    {
        Console.WriteLine("КРАТНО");
    }
    else
    {
        Console.WriteLine("НЕ кратно");
    }
}
//Example_14();

void Example_16()
{
    // Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
    Console.WriteLine("Задача 16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.");

    Console.Write("Введите число: ");
    int numberFirst = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int numberSecond = Convert.ToInt32(Console.ReadLine());
    //if (numberFirst * numberFirst == numberSecond || numberSecond * numberSecond == numberFirst)
    if (numberFirst == Math.Pow(numberSecond, 2) | numberSecond == Math.Pow(numberFirst, 2)) // Решение студента
    {
        Console.WriteLine("Одно число является квадратом другого");
    }
    else
    {
        Console.WriteLine("Одно число не являются квадратом другого");
    }
}
Example_16();