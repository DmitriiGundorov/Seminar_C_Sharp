// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void Example_17()
{
    Console.WriteLine("Задача 17");
    Random rand = new Random();
    // Тип_данных имя_переменной = new тип_данных();
    int x = rand.Next(-10, 11);
    int y = rand.Next(-10, 11);
    Console.WriteLine($"A ({x},{y})");
    if (x > 0 && y > 0)
    {
        Console.WriteLine($"Точка A с координатами ({x},{y}) находится в 1-ой четверти");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine($"Точка A с координатами ({x},{y}) находится во 2-ой четверти");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine($"Точка A с координатами ({x},{y}) находится в 3-ой четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine($"Точка A с координатами ({x},{y}) находится в 4-ой четверти");
    }
    else if (x == 0 || y == 0)
    {
        Console.WriteLine($"Точка A с координатами ({x},{y}) нлежит на координатной прямой");
    }
}
//Example_17();

// Задача 18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

void Example_18()
{
    Console.WriteLine("Задача 18");
    Console.Write("Введите номер четверти от 1 до 4: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number == 1)
    {
        Console.WriteLine("Значение координат x > 0 и у > 0");
    }
    else if (number == 2)
    {
        Console.WriteLine("Значение координат x < 0 и у > 0");
    }
    else if (number == 3)
    {
        Console.WriteLine("Значение координат x < 0 и у < 0");
    }
    else if (number == 4)
    {
        Console.WriteLine("Значение координат x > 0 и у < 0");
    }
    else if (number > 4 || number < 1)
    {
        Console.WriteLine("Введено некорректное значение");
    }
}
Example_18();