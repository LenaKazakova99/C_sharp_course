﻿// 2. Напишите программу, которая принимает на вход координаты
//    двух точек и находит расстояние между ними в 3D пространстве.
//    https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/

double num(double x1, double x2, double y1, double y2, double z1, double z2)
{
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
}
num(3, 6, 9, 4, -2, 7);
Console.WriteLine(num(3, 6, 9, 4, -2, 7));