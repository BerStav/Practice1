// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка)
Console.Write("We'll tell you if your number is even, please, enter it = ");
int a = int.Parse(Console.ReadLine());

int x = a % 2;

if (x == 0)
{
    Console.Write("Yes");
}

else
{
    Console.Write("No");
}