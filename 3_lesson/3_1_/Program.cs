// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (X и Y).

void Quarters(int num)
{
    if (num == 1) Console.WriteLine("X > 0, Y > 0");
    else if (num == 2) Console.WriteLine("X < 0, Y > 0");
    else if (num == 3) Console.WriteLine("X < 0, Y < 0");
    else if (num == 4) Console.WriteLine("X > 0, Y < 0");
    else Console.WriteLine("не верно");
}

Quarters(1);
Quarters(2);
Quarters(3);
Quarters(4);
Quarters(7);
Quarters(9);