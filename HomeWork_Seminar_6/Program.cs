// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Example_41()
{
    Console.WriteLine("|    Задача 41     |");
    Console.WriteLine("Введите количество чисел M: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    Console.WriteLine($"Введите {size} числа(ел): ");
    for (int i = 1; i <= size; i++)
    {
        int temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 0) count++;
    }
    Console.WriteLine("Количество чисел больше 0 -> " + count);
}

// Метод введения текста
string Input (string inputText)
{
    Console.Write(inputText);
    return Console.RedLine();
}

void Example_41_m()
{
    Console.WriteLine("|    Задача 41     |");
    int size = Convert.ToInt32(Input("Введите количество чисел M:  "));
    int count = 0;
    Console.WriteLine($"Введите {size} числа(ел): ");
    for (int i = 1; i <= size; i++)
    {
        int temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 0) count++;
    }
    Console.WriteLine("Количество чисел больше 0 -> " + count);
}

// Задача 43. Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями  y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

void Example_43()
{
    Console.WriteLine("|    Задача 43     |");
    Console.Write("Введите значение b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    if (k1 == k2) Console.WriteLine("Некорректный ввод. Деление на 0.");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        Console.WriteLine($"Координата точки пересечения 2-х прямых линний -> ({x}, {y})");
    }
}
//Example_41();
Example_41_m();
//Example_43();