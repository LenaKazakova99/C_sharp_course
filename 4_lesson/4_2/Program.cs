﻿// Задача 2: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int MultNum(int N)
{
     int all_mult = 1;
    for (int i = 1; i <= N; i++)
    {
        all_mult *=i;
    }
    return all_mult;
}
Console.WriteLine(MultNum(4));
Console.WriteLine(MultNum(5));