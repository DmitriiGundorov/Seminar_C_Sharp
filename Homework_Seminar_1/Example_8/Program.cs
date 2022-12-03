// Задача 8. Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 1)
{
    Console.WriteLine("Положительных целых чисел в указанном диапазоне нет");
}
else
{
    Console.WriteLine("Положительные целые числа от 1 до " + number);
/* int count = 2;
while (count <= number)
{
    Console.Write($"{count}  ");
    count += 2;
} */
int count = 1;
while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.Write($"{count}  ");
    }
    count++;
}
}
