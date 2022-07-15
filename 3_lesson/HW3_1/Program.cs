// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

void Palindrome(int n)
{
    int i = 0;
    string num = n.ToString();
    int size = num.Length - 1;
    string flag = "да";
    
    while (i < size / 2)
    {
        if (num[i] != num[size - i]) 
        {
            flag = "нет";
            break;
        }        
        i += 1;
    }    
    Console.WriteLine($"{n} -> {flag}");
}

Palindrome(14212);
Palindrome(23432);

