﻿// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

void cube(int num)
{
    int count = 1;
    while(count <= num)
    {
        Console.WriteLine($"{Math.Pow(count,3)}");
        count++;
    }
}
cube(8);