// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int numberThree = Convert.ToInt32(Console.ReadLine());
int numberMax = numberFirst;

if (numberTwo > numberMax)
{
    numberMax = numberTwo;
}
if (numberThree > numberMax)
{
    numberMax = numberThree;
}
Console.WriteLine("Наибольшее число: " + numberMax);