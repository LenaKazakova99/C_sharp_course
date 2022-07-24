﻿// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами 
// и выводит их на экран. Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах)
// 1,2,5,7,19,1,2,8 -> 1,2,5,7,19,1,2,8
// 6,1,33,5,6,7,7,1 -> 6,1,33,5,6,7,7,1

void Arr(int []arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{arr [i]}");
    }
    Console.WriteLine();
}

int[] EightMass()
{   
    int size = 8;

    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 100);        
    }    
    return arr;
}

int[] arr_1 = EightMass();
Arr(arr_1);
int[] arr_2 = EightMass();
Arr(arr_2);