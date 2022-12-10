// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

void Example_31()
{
    Console.WriteLine("|    Задача 31     |");
    int size = 12;
    //string[] - строковый массив, bool[] - логический массив, int[] - целочисленный массив
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    PrintArray(numbers);
    FindSumPositive(numbers);
    FindSumNegative(numbers);
}
void FindSumPositive(int[] nums)
{
    int sumPos = 0;
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        if (nums[i] > 0) sumPos += nums[i];
    }
    Console.WriteLine("Сумма положительных элементов:  " + sumPos);
}

void FindSumNegative(int[] nums)
{
    int sumNeg = 0;
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        if (nums[i] < 0) sumNeg += nums[i];
    }
    Console.WriteLine("Сумма отрицательных элементов:  " + sumNeg);
}

void FillArray(int[] nums, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        nums[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] nums)
{
    int length = nums.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(nums[i] + "  ");
    }
    Console.WriteLine();
}

//Example_31();

// Задача 32: Напишите программу замены элементов 
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.

void Example_32()
{
    Console.WriteLine("|    Задача 32     |");
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers, -9, 9);
    Console.Write("Заданный массив:  ");
    PrintArray(numbers);
    int length = numbers.Length;
    for (int i = 0; i < length; i++)
    {
        //if (numbers[i] > 0 || numbers[i] < 0) numbers[i] = numbers[i] * (-1);
        numbers[i] *= -1; // Решение преподавателя
    }
    Console.Write("Инверсивный массив:  ");
    PrintArray(numbers);
}
//Example_32();

// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.

void Example_33()
{
    Console.WriteLine("|    Задача 33     |");
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 10);
    Console.Write("Заданный массив:  ");
    PrintArray(numbers);
    Console.Write("Введите число для проверки его нахождения в массиве: ");
    int N = Convert.ToInt32(Console.ReadLine());
    bool flag = false; // создается переменна, которой присваивается логическое значение "ЛОЖЬ"
    for (int i = 0; i < size && !flag; i++) // !flag - остановка цикла при изменении переменной flag == false
    {
        //if (numbers[i] == N) flag = true; // присвоение переменной значения "ПРАВДА"
        //или 
        flag = numbers[i] == N;

    }
    if (flag) Console.WriteLine($"Значение {N} имеется в заданном массиве");
    else Console.WriteLine($"Значение {N} отсутствует в заданном массиве");
}
//Example_33();

// Задача 35: Задайте одномерный массив из 10 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99].

void Example_35()
{
    Console.WriteLine("|    Задача 35     |");
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 100);
    Console.Write("Заданный массив:  ");
    PrintArray(numbers);
    //int length = numbers.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] >= 10 & numbers[i] < 100) count++;
    }
    if (count != 0) Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] - > {count}");
    else Console.WriteLine($"Элементов массива, значения которых лежат в отрезке [10,99] нет");

}
//Example_35();

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.

void Example_37()
{
    Console.WriteLine("|    Задача 37     |");
    int size = 7;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 10);
    Console.Write("Заданный массив:  ");
    PrintArray(numbers);
    int halfsize = size / 2;
    int maxindex = size - 1;
    int[] result = new int[halfsize + size % 2]; // или new int[size - halfsize]
    for (int i = 0; i < halfsize; i++)
    {
        result[i] = numbers[i] * numbers[maxindex - i];
    }
    if (size % 2 == 1) result[halfsize] = numbers[halfsize];
    Console.Write("Новый массив:  ");
    PrintArray(result);
}
Example_37();



/* Задача 3 доп 
bool find = false;
            PathFind(matrix);
            PrintArray(matrix);
            Console.WriteLine();
            if(find) Console.WriteLine("Путь найден");
            else Console.WriteLine("Пути нет");

            void PathFind(int[,] matrix, int i = 0, int j = 0)
            {
                if (i < 0 || i > maxIndexRow || j < 0 || j > maxIndexColumn) return;
                if (matrix[i, j] == 0 || matrix[i, j] == 2) return;

                matrix[i, j] = 2;
                if (i == maxIndexRow & j == maxIndexColumn)
                {
                    find = true;
                    return;
                }

                PathFind(matrix, i - 1, j);
                PathFind(matrix, i + 1, j);
                PathFind(matrix, i, j - 1);
                PathFind(matrix, i, j + 1);
            }
*/