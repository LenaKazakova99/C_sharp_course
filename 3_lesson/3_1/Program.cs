// Напишите программу, которая принимает на вход координаты точки (X, Y),
// причем X не равно 0 или Y не равно 0 и выдает номер четверти плоскости, в которой
// находится эта точка.

void Quarters(int X, int Y)
{
    if (X == 0 || Y == 0) Console.WriteLine("x = 0, Y = 0");
    else if (X > 0 & Y > 0) Console.WriteLine("I");
    else if (X < 0 & Y > 0) Console.WriteLine("II");
    else if (X < 0 & Y < 0) Console.WriteLine("III");
    else if (X > 0 & Y < 0) Console.WriteLine("IV");
}

Quarters(0, 1);
Quarters(2, 1);
Quarters(2, -1);
Quarters(-2, 1);
Quarters(-2, -1);