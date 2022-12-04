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
    else if (number == 4) Console.WriteLine("Значение координат x > 0 и у < 0"); // Запись в строку, возможно делать если условие одно. 

    // else if (number > 4 || number < 1)
    else
    {
        Console.WriteLine("Введено некорректное значение");
    }
}
//Example_18();

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.

void Example_21()
{
    //int x=5;
    //Math.Pow(x, 2); - возведение в квадрат
    //Math.Sqrt(x, 2); - корень в квадрате
    //Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

    Console.WriteLine("Задача 21");
    Random rand = new Random();
    double x1 = rand.Next(-10, 11);
    double y1 = rand.Next(-10, 11);
    Console.WriteLine($"Координаты точки A ( {x1}, {y1} )");
    double x2 = rand.Next(-10, 11);
    double y2 = rand.Next(-10, 11);
    Console.WriteLine($"Координаты точки В ( {x2}, {y2} )");
    double Distanse = 0;
    Distanse = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Distanse = Math.Round(Distanse, 2);// Округление числа до 2-го знака после запятой
    Console.WriteLine($"Расстояние между точкой А и В (Длина отрезка АВ): {Distanse}");
}
Example_21();