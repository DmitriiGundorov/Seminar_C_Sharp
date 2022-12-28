// Методы

void Recursion_64(int number, int counter)
{
    if (counter > number) return;
    if (counter % 3 == 0) Console.Write($"{counter}  ");
    counter++;
    Recursion_64(number, counter);
}

void Recurs(int number, int counter) // Метод перебора положительных чисел при помощи рекурсии
{
    int sum = 0;
    if (counter > number) return;
    if (counter > 0)
        Console.Write($"{counter}\t");
    counter++;
    sum += counter;
    Recursion_66(number, counter);
    //Console.WriteLine(sum);
}

int Recursion_66(int M, int N, int count = 0, int sum = 0)
{
    if (!(count >= M)) return sum;
    sum = sum + count;
    count--;
    return Recursion_66(M, N, count, sum);
}

int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if ((m != 0) && (n == 0)) return AkkermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    return AkkermanFunction(m, n);
}

// Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который
// выведет все натуральные числа кратные 3-ём в промежутке от M до N.

void Example_64()
{
    Console.WriteLine("|    Задача 64     |");
    Console.Write("Введите начальное значение числа М: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное значение числа N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Recursion_64(N, M);
    Console.WriteLine("\n");
}

// Задача 66: Задайте значения M и N. Напишите рекурсивный метод, 
// который найдёт сумму натуральных элементов в промежутке от M до N.

void Example_66()
{
    Console.WriteLine("|    Задача 66     |");
    Console.Write("Введите положительное значение числа М: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите положительное значение числа N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    if (M <= 0 || N <= 0) Console.WriteLine("Некорретный ввод");
    else
    {
        if (M > N)
        {
            int temp = M;
            M = N;
            N = temp;
        }
        int count = N;
        int sum = 0;
        // while (count >= M)
        // {
        //     sum = sum + count;
        //     count--;
        // }
        // Console.WriteLine(sum);
        Console.WriteLine($"Сумма натуральных чисел в интервале от {M} до {N} -> {Recursion_66(M, N, count, sum)}");
    }
    Console.WriteLine("\n");
}

// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

void Example_68()
{
    Console.WriteLine("|    Задача 68     |");
    Console.Write("Введите положительное значение числа m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите положительное значение числа n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m <= 0 || n <= 0) Console.WriteLine("Некорретный ввод");
    else
    {
        Console.WriteLine($"Значение функции Аккермана для чисел A({m},{n}) = {AkkermanFunction(m, n)}");
    }
    Console.WriteLine("\n");
}

Example_64();
Example_66();
Example_68();