// Задача 1: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

int countNum(int num)
{
    string result = num.ToString();
    return result.Length;
}
Console.WriteLine(countNum(456));
Console.WriteLine(countNum(78));
Console.WriteLine(countNum(89126));