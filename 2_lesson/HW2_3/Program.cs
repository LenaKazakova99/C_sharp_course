﻿// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

void TakeNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 99)
    {
        Console.WriteLine("третьей цифры нет");
        return;
    }

    while (num > 999) num = num / 10;
    Console.WriteLine(num % 10);
}

TakeNum(int.Parse(Console.ReadLine()));