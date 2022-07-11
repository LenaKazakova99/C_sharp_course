// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

void Weekend(int num)
{
    string text = "не выходной";

    if (num == 7 || num == 6) text = "выходной";
    Console.WriteLine($"{num} -> {text}");
}

Weekend(4);
Weekend(6);