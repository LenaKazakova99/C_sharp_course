﻿// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве. 

double num(double x1, double x2, double y1, double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
}
num(3, 6, 9, 4);
Console.WriteLine(num(3, 6, 9, 4));