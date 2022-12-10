// Задача 19. Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом (число, которое читается слева направо и справо налево одинаково).

void Example_19()
{
    Console.WriteLine("|    Задача 19     |");
    Console.WriteLine("Введите пятизначное целое число или текст: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int copy_number = number;
    int result = 0;
    int variable = 0;
    //Мое паршивое решение
    /*string number = Console.ReadLine();
    if (number[5] >= 0) Console.WriteLine("Некорректный ввод"); // Комментарий: не удается придумать как сделать чтобы программа не ломалась
    else if (number[4] == number[0])
    {
        if (number[3] == number[1]) Console.WriteLine($"Значение {number} является полиндромом");
    }
    else
    {
        Console.WriteLine($"Значение {number} НЕ является полиндромом");
    }*/
    if (number >= 10000 & number < 100000)
    {
        while (copy_number > 0)
        {
            variable = copy_number % 10;
            result = result * 10 + variable;
            copy_number /= 10;
        }
        if (result == number)
        {
            Console.WriteLine($"{number} = {result}");
            Console.WriteLine($"Число {number} палиндром");
        }
        else
        {
            Console.WriteLine($"{number} <> {result}");
            Console.WriteLine($"Число {number} НЕ палиндром");
        }
    }
    else Console.WriteLine("Некорректный ввод");
}

// Задача 21: Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

void Example_21()
{
    Console.WriteLine("|    Задача 21     |");
    Random rand = new Random();
    double x1 = rand.Next(-10, 11);
    double y1 = rand.Next(-10, 11);
    double z1 = rand.Next(-10, 11);
    Console.WriteLine($"Координаты точки A: ( {x1}, {y1} ,{z1} )");
    double x2 = rand.Next(-10, 11);
    double y2 = rand.Next(-10, 11);
    double z2 = rand.Next(-10, 11);
    Console.WriteLine($"Координаты точки В: ( {x2}, {y2} ,{z2} )");
    double Distanse = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); // Диагональ прямоугольного параллелепипеда
    Console.WriteLine($"Расстояние между А и В (Длина отрезка АВ): {Math.Round(Distanse, 2)}");
}

// Задача 23: Напишите программу, которая принимает на 
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Example_23()
{
    Console.WriteLine("|    Задача 21     |");
    Console.Write("Введите положительное целое число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    if (N > 0)
    {
        for (int i = 1; i <= N; i++) Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
    }
    else Console.WriteLine("Некорректный ввод");
}

Example_19();
Example_21();
Example_23();