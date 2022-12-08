// Написать программу, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.Write("Please, enter the first number = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Please, enter the second number = ");
int b = int.Parse(Console.ReadLine());
Console.Write("Please, enter the third number = ");
int c = int.Parse(Console.ReadLine());
int max = a;

if (b > a) max = b;

if (c > b) max = c;

Console.Write("max = ");
Console.Write(max);