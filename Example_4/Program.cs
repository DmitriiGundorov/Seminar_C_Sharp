// Напишите программу вычисления значения функции возведения числа в квадрат

/* Console.WriteLine("Введите значение функции:");
int number = Convert.ToInt32(Console.ReadLine());

PrintPower(number);

void PrintPower(int numberSecond)
{
    Console.WriteLine($"{number}*{number} = {number * number}");
    number = number + 10;
    Console.WriteLine(numberSecond);
}
*/
//f(x)=x^2;

/* Напишите программу, которая на вход принимает одно число 
(N), а на выходе показывает все целые числа в промежутке от -N 
до N */

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
/*int i = -number;
while (i != number + 1)
{
    Console.Write($"{i}  ");
    i++;
}*/
int count = -number;
while (count <= number)
{
    Console.Write(count + " ");
    count++;
}
