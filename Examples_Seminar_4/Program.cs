// Задача 24: Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNumbers(int number) // Функция суммы
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}

void Example_24()
{
    Console.WriteLine("|    Задача 24     |");
    Random rand = new Random();
    int number = rand.Next(1, 16);
    Console.WriteLine("Введите число: " + number);
    int count = 1;
    int sum = 0;
    while (count <= number)
    {
        Console.Write($"{sum} + {count} = ");
        sum = sum + count; //или sum +=count;
        Console.WriteLine(sum);
        count++;
    }
    Console.WriteLine("Ответ: " + sum);

    /* // Альтернативный способ решения задачи. Проблема - изменяет значение числа.
    sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    Console.WriteLine("Ответ: " + sum);*/
    Console.WriteLine("Ответ: " + SumNumbers(number));
}
//Example_24();

// Задача 26. Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.


void Example_26()
{
    Console.WriteLine("|    Задача 26     |");
    /*Random rand = new Random();
    int number = rand.Next(10, 100000);
    Console.WriteLine("Введите число: " + number);
    int count = 1;
    int box = number;
    while (box > 10)
    {
        box = box / 10;
        count++;
    }
    Console.WriteLine($"Количество цифр в числе {number} -> {count}");*/

    // Решение студента
    /*Console.Write("Введите число -> ");
    string number = Console.ReadLine();
    int length = number.Length;
    Console.WriteLine($"Количество цифр в числе {number} -> {length}");*/

    // Решение преподавателя
    Random rand = new Random();
    int number = rand.Next(10, 100000);
    Console.WriteLine("Введите число: " + number);

    Console.WriteLine("Длина числа равна " + Math.Ceiling(Math.Log10(number))); // При значении 100 покажет НЕверное значение количества цифр
    // Math.Ceiling - метод округления числа в ближайшую большую сторону
    Console.WriteLine("Длина числа равна " + Math.Floor(Math.Log10(number) + 1)); // При значении 100 покажет верное значение количества цифр
    // Math.Floor - метод округления числа в меньшую сторону

    DateTime now = DateTime.Now;
    for (int i = 0; i < 1000000; i++)
    {
        // Или
        string numberStr = Convert.ToString(number); // Данный способ увеличивает время обработки данных программой в среднем в 20 раз
    }
    Console.WriteLine(DateTime.Now - now);
    //Console.WriteLine("Длина числа равна " + numberStr.Length);

    now = DateTime.Now;
    for (int i = 0; i < 1000000; i++)
    {
        var a = Math.Floor(Math.Log10(number) + 1);
    }
    Console.WriteLine(DateTime.Now - now);

    now = DateTime.Now;
    for (int i = 0; i < 1000000; i++)
    {
        int length = 0;
        while (number > 0)
        {
            number = number / 10;
            length++;
        }
    }
    Console.WriteLine(DateTime.Now - now);
    // Console.WriteLine($"Длина числа -> {length}");
    //Console.WriteLine("Текущее время: " + DateTime.Now);
}
// Example_26();

// Задача 28. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.


void Example_28()
{
    Console.WriteLine("|    Задача 28     |");
    Random rand = new Random();
    int number = rand.Next(1, 10);
    Console.WriteLine("Введите число: " + number);
    int count = 1;
    int box = number;
    while (box > 0)
    {
        count = count * box;
        box--;
    }
    Console.WriteLine($"Произведение чисел от 1 до {number} -> {count}");
}
//Example_28();

// Задача 30: Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в случайном порядке.

// Метод заполнения массива
void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(0, 2);
    }
}

// Метод печати массива
void PrintArray(int[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
       Console.Write(nums[i] + "  ");
    }
    Console.WriteLine();
}


void Example_30()
{
    Console.WriteLine("|    Задача 30     |");

    /*// Решение студента
    Random rand = new Random();
    int[] binaries = new int[8];
    Console.Write("Binary array = [ ");
    for (int i = 0; i < 8; i++)
    {
        binaries[i] = rand.Next(0, 3);
        Console.Write(binaries[i] + ", ");
    }
    Console.Write("]");*/

    // Решение преподавателя
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
}

Example_30();