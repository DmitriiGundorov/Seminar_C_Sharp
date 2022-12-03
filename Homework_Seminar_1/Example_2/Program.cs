// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число:");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberFirst > numberTwo)
{
    Console.WriteLine("Наибольшее число = " + numberFirst);
    Console.WriteLine("Наименьшее число = " + numberTwo);
}
else
{
    Console.WriteLine("Наибольшее число = " + numberTwo);
    Console.WriteLine("Наименьшее число = " + numberFirst);
}