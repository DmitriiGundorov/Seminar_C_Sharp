// Методы

void Recursion(int number, int counter)
{
    if (counter > number) return;
    Console.Write($"{counter}  ");
    counter++;
    Recursion(number, counter);
}

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.


void Example_63()
{
    Console.WriteLine("|    Задача 63     |");
    Console.Write("Введите натуральное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int counter = 1;
    // Классическое решение задачи
    // while (counter <= number)
    // {
    //     Console.Write($"{counter}\t");
    //     counter++;
    // }
    Recursion(number, counter);
}
Example_63();



// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void Example_65()
{
    Console.WriteLine("|    Задача 65     |");
    Console.Write("Введите натуральное число М: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    Recursion(N, M);

    /* //Анатолий
     void Zadacha65()
     {
         Console.WriteLine("Введите начальное число:");
         int number1 = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Введите конечное число:");
         int number2 = Convert.ToInt32(Console.ReadLine());

         int counter = number1;
         Recursion(number2, counter);
         return;
         //Без рекурсии
         while (counter <= number2)
         {
             Console.WriteLine($"{counter} ");
             counter++;
         }
     }*/

}
// Example_65();

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12 
// 45 -> 9

void Example_67()
{
    Console.WriteLine("|    Задача 67     |");
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    int number2 = number;
    while (number2 > 0)
    {
        sum += number2 % 10;
        number2 /= 10;
    }
    Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
    Console.WriteLine();
    Console.WriteLine($"Сумма цифр числа {number} равна {SumDigits(number)}");
}
//Example_67();

/*int SumDigits(int number, int sum = 0)
{
    if (number == 0) return sum;
    sum += number % 10;
    number /= 10;
    return SumDigits(number, sum);
}*/
// Способ рекурсии
int SumDigits(int number, int sum = 0)
{
    if (number == 0) return sum;
    return number % 10 + SumDigits(number /= 10);
}


/*//Алия
void Zadacha67()
            { //Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
                Console.WriteLine("Введите число");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(SumRec(n));
            }
            int SumRec(int n)
            {
                if (n == 0) return 0;
                else return n%10 + SumRec(n/=10);
            }
       

// Анатолий
void Zadacha67()
            {
                Console.WriteLine("Введите число:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"сумма цифр = {DigitsSum(number)}");
                return;
                int temp = number;                
                int result = 0;
                //Без рекурсии
                while(temp > 0)
                {
                    result += temp%10;
                    temp /= 10;
                }
                
            }    

            int DigitsSum(int number)
            {
                if (number == 0) return 0;
                return number%10 + DigitsSum(number/10);
            }
*/

// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

void Example_69()
{
    Console.WriteLine("|    Задача 69     |");
    Console.Write("Введите число A: ");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите степень числа А: ");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int sum = Convert.ToInt32(Math.Pow((numberA), numberB));
    //Console.WriteLine($"Значение числа {numberA} в степени {numberB} равно {sum}");
    Recurs_69(numberA, numberB, sum);
}
//Example_69();

void Recurs_69(int numberA, int numberB, int sum)
{
    Console.WriteLine($"{numberA} в степени {numberB} = {sum}");
    return;
    numberB = Convert.ToInt32(Console.ReadLine());
    sum = Convert.ToInt32(Math.Pow(numberA, numberB));
}

/* // Решение Кристины
void Zadacha69()

{
    //Напишите программу, которая на вход принимает два числа а и б, и возводит число а в целую степень б с помощью рекурсии. 

    Console.WriteLine("Введите число, которое необходимо возвести в степень ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Введите степень ");
    int stepen = Convert.ToInt32(Console.ReadLine());
    int sum = Convert.ToInt32(Math.Pow(x, stepen));
    Recursion(x, stepen, sum);

    void Recursion(int x, int stepen, int sum)
    {
        Console.WriteLine($"{x} в степени {stepen} = {sum}");
        return;
        stepen = Convert.ToInt32(Console.ReadLine());
        sum = Convert.ToInt32(Math.Pow(x, stepen));
    }
}
Zadacha69();*/

