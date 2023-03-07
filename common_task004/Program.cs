// Задача №5. напишите программу, которая на вход принимает одно число(N), а на выходе
//показывает целые числа в промежутке от -N до N.

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for(int i = -n; i <= n; i++)
{
    Console.Write($"{i} ");
}