﻿// Задача 2: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Num(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}
Console.WriteLine(Num(452));
Console.WriteLine(Num(82));
Console.WriteLine(Num(9012));