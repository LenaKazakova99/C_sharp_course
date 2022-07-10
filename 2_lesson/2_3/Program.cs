// Напишит программу, которая будет принимать на вход два числа и выводить, является ли 
// второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит 
// остаток от деления.

using System;

namespace _2_2
{
    class Program
    {
        static int CheckinValves(in int val1, in int val2)
        {
            return(val1 % val2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ведите первое число");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ведите второе число");
            int value2 = int.Parse(Console.ReadLine());

            int val = CheckinValves(in value1, in value2);

            if (val == 0)
            {
                Console.WriteLine("Числа кратные");
            }
            else
            {
                Console.WriteLine($"Остаток от деления {val}");
            }
        }
    }
}