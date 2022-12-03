void Example_10()
{
    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    Console.WriteLine("|     Задача 10       |");
    Console.Write("Введите трехзначное целое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 100 | number >= 1000)
    {
        Console.WriteLine("Введено некорректное значение.");
    }
    else
    {
        int num = number % 100 / 10;
        Console.WriteLine($"Вторая цифра введенного числа: {num}");
    }
}
//Example_10();

void Example_13()
{
    // Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    Console.WriteLine("|     Задача 13       |");
    Console.Write("Введите целое число более или равно 100: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = number;
    if (number < 100)
    {
        Console.WriteLine("Введено некорректное число. Третьей цифры нет.");
    }
    else
    {
        while (count >= 1000)
        {
            count = count / 10;
        }
        Console.WriteLine(count % 10);
    }
}
//Example_13();

void Example_15()
{
    // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    Console.WriteLine("|     Задача 15       |");
    Console.Write("Введите цифру дня недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 1 || number > 7)
    {
        Console.WriteLine("Введено некорректное значение. Необходимо ввести значение от 1 до 7");
    }
    else if (number == 1)
    {
        Console.WriteLine("Понедельник");
    }
    else if (number == 2)
    {
        Console.WriteLine("Вторник");
    }
    else if (number == 3)
    {
        Console.WriteLine("Среда");
    }
    else if (number == 4)
    {
        Console.WriteLine("Четверг");
    }
    else if (number == 5)
    {
        Console.WriteLine("Пятница");
    }
    else if (number == 6)
    {
        Console.WriteLine("Суббота \nУра! Выходной!");
    }
    else if (number == 7)
    {
        Console.WriteLine("Воскресенье \nУра! Выходной!");
    }
}
Example_15();