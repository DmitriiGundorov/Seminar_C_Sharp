/* Напишите программу, которая на вход принимает два 
числа и проверяет, является ли первое число квадратом 
второго.*/

/*Мое решение
Console.Write("Введите значение первой переменной: ");
string variable_1 = Console.ReadLine();
Console.Write("Введите значение второй переменной: ");
string variable_2 = Console.ReadLine();
int a = variable_1;
int b = variable_2;
int Result = a * a;

int a = 5;
int b = 25;
if (a*a == b)
{
    Console.WriteLine($"{a} * {a} = {b}");
    Console.WriteLine("Да");
}
//else
if (a*a != b)
{
    Console.WriteLine($"{a} * {a} = {b}");
    Console.WriteLine("Нет");    
}
*/
// Решение преподавателя
Console.WriteLine("Введите значение первой переменной:");
int numberFirst=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение второй переменной:");
int numberSecond= Convert.ToInt32(Console.ReadLine());
if (numberFirst==numberSecond * numberSecond)
{
    Console.WriteLine($"{numberSecond} * {numberSecond} = {numberFirst}");
    Console.WriteLine ("Верно");
}
else
{
    Console.WriteLine($"{numberSecond} * {numberSecond} = {numberFirst}");
    Console.WriteLine ("Не верно");
}