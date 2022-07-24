// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Num(int A, int B)
{
    int step = A;
    
    for (int i = 1; i < B; i++)
    {
        step *= A; 
    }  
    return step;
}
Console.WriteLine(Num(3, 5));
Console.WriteLine(Num(2, 4));
