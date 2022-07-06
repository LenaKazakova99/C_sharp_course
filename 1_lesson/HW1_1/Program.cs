// 1. Напишите программу, которая на вход принимает два числа и выдаёт,
//    какое число большее, а какое меньшее.

string s_num1 = Console.ReadLine();
string s_num2 = Console.ReadLine();

int num1 = int.Parse(s_num1);
int num2 = int.Parse(s_num2);

if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше чем {num2}");
}
else if (num1 == num2)
{
    Console.WriteLine($"Число {num1} равно числу {num2}");
}
else
{
    Console.WriteLine($"Число {num1} меньше чем {num2}");
}