﻿// Задача №3. Напишите программу, которая будет выдавать
// названия дня недели по заданному номеру
Console.Clear();
Console.WriteLine("Введите значение от 1 до 7: ");
int n = Convert.ToInt32(Console.ReadLine());

if( n == 1)
    Console.WriteLine("Понедельник");
else if( n == 2)
    Console.WriteLine("Вторник");
else if( n == 3)
    Console.WriteLine("Среда");
else if( n == 4)
    Console.WriteLine("Четверг");
else if( n == 5)
    Console.WriteLine("Пятница");
else if( n == 6)
    Console.WriteLine("Суббота");
else if( n == 7)
    Console.WriteLine("Воскресенье");
else
{
    Console.Write("ЭЙ! Это значение -> ");
    Console.Write(n);
    Console.Write(" <- не из диапозона от 1 до 7!");
}