// Написать программу, которая принимает на вход два числа и выдает, какое число большее, а какое меньшее

Console.Write("Please, enter the first number = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Please, enter the second number = ");
int b = int.Parse(Console.ReadLine());

if (a > b) 
{
    Console.Write("max = ");
    Console.Write(a);
}

else
{
    Console.Write("max = ");
    Console.Write(b); 
}