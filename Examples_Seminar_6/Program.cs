// Область для вспомогательных методов

void FillArray(int[] nums, int minValue = 0, int maxValue = 9) // Метод заполнения массива
{
    maxValue++;
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] nums)  // Метод печати массива
{
    int length = nums.Length;
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + "  ");
    }
    Console.WriteLine("\n"); // \n - символ перехода на новую строку
}

string ToBinary(int number) // Метод перевода 10-го числа в двоичный
{
    string result = String.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}

void CopyArray(int[] firstArray, int[] secondArray) // Метод копирования первого массива во второй
{
    int size = firstArray.Length;
    for (int i = 0; i < size; i++)
    {
        secondArray[i] = firstArray[i];
    }
}


// Область для описания методов задач

// Задача 39: Напишите программу, которая перевернёт 
// одномерный массив (последний элемент будет на первом 
// месте, а первый - на последнем и т.д.)

void Example_39()
{
    Console.WriteLine("|    Задача 39     |");
    Random rand = new Random();
    int size = rand.Next(4, 8);
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    // for (int i = size - 1; i >= 0; i--)     // способ - цикл переворота массива
    // {
    //     Console.Write(numbers[i] + "  ");
    // }
    int[] result = new int[size];
    int maxIndex = size - 1;
    for (int i = 0; i < size; i++)     // способ - цикл переворота массива через создание нового массива (занимает дополн. память)
    {
        result[maxIndex - i] = numbers[i];
    }
    PrintArray(result);

    // 2-ой способ
    for (int i = 0; i < size / 2; i++)
    {
        // int temp = numbers[i];                   // способ - цикл переворота массива через 3-ю переменную
        // numbers[i] = numbers[maxIndex - i];
        // numbers[maxIndex - i] = temp;
        (numbers[i], numbers[maxIndex - i]) = (numbers[maxIndex - i], numbers[i]); // переворот массива с помощью кортежа
    }
    PrintArray(numbers);
}

// Задача 40: Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать треугольник со 
// сторонами такой длины.

void Example_40()
{
    Console.WriteLine("|    Задача 40     |");
    Console.Write("Введите число стороны треугольника АВ: ");
    int numberAB = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число стороны треугольника BC: ");
    int numberBC = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число стороны треугольника АC: ");
    int numberAC = Convert.ToInt32(Console.ReadLine());
    if (numberAB < numberAC + numberBC && numberAC < numberAB + numberBC && numberBC < numberAB + numberAC)
    {
        Console.WriteLine($"Треугольник со сторонами AB = {numberAB}, BC = {numberBC}, AC = {numberAC} существует");
    }
    else Console.WriteLine($"Треугольника со сторонами AB = {numberAB}, BC = {numberBC}, AC = {numberAC} НЕ существует");
}

//Решение преподавателя
void Example_40_p()
{
    var triangle = (3, 4, 5);
    if (triangle.Item1 < triangle.Item2 + triangle.Item3 &&
        triangle.Item2 < triangle.Item1 + triangle.Item3 &&
        triangle.Item3 < triangle.Item2 + triangle.Item1)
        Console.WriteLine("Треугольник существует");
    else Console.WriteLine("Треугольник не существует");
}

// Задача 42. Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.

void Example_42() // Решение через строку
{
    Console.WriteLine("|    Задача 42     |");
    Console.Write("Введите число в десятичной системе счисления: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string result = ToBinary(num);
    Console.WriteLine($"Двоичная форма числа {num}:  {result}");
}

void Example_42_p() // Решение через числа
{
    Console.WriteLine("|    Задача 42     |");
    Console.Write("Введите число в десятичной системе счисления: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int bias = 1; // Переменная для смещения разряда
    int result = 0;
    while (number > 0)
    {
        result = result + (number % 2) * bias;
        bias *= 10;
        number /= 2;
    }
    Console.WriteLine($"Двоичная форма числа {number}:  {result}");
}

// Задача 44. Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void Example_44()
{
    Console.WriteLine("|    Задача 44     |");
    Console.Write("Введите количество чисел Фиббоначи: ");
    int N = Convert.ToInt32(Console.ReadLine());
    //N -= 2;
    double number1 = 0;
    double number2 = 1;
    //int count = 0;
    double result = 0;
    Console.Write(number1 + " " + number2 + " ");
    for (int i = 2; i < N; i++)
    //while (count < N) // через цикл while закомментированные строки
    {
        result = number1 + number2;
        Console.Write(result + " ");
        number1 = number2;
        number2 = result;
        //count++;
    }
}

void Example_44_p() //Решение с помощью кортежа преподавателем
{
    Console.WriteLine("|    Задача 44П    |");
    Console.Write("Введите количество чисел Фиббоначи: ");
    int N = Convert.ToInt32(Console.ReadLine());
    double number1 = 0;
    double number2 = 1;
    for (int i = 0; i < N; i++)
    {
        Console.Write(number1 + " ");
        (number1, number2) = (number2, number1 + number2); // 
    }
}

// Задача 45. Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования. 

void Example_45()
{
    Console.WriteLine("|    Задача 45     |");
    Random rand = new Random();
    int size = rand.Next(4, 8);
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    // int[] result = numbers; // Полное копирование значений массива
    int[] result = new int[size];
    CopyArray(numbers, result);
    PrintArray(result);
}

// Область для написания кода

//Example_39();
//Example_40();
//Example_40_p();
//Example_42();
//Example_42_p();
//Example_44();
//Example_44_p();
Example_45();