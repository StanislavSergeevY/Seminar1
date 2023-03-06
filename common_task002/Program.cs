//задача №1. Напишите программу, которая на вход принимает два числа и
//проверяет, является ли первое число квадратом второго.

//int a = 25, b = 5;

Console.Write("Please add first volue: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please add second volue: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a / b == b)
{
    Console.Write("Yes! This is square!");
}
else
{
    Console.Write("No! This is no square!");
}