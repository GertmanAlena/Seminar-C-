﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if(m == 0) return n + 1;
    else if(m > 0 && n == 0)
    {
        return Akkerman(m-1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Akkerman(m - 1, Akkerman(m, n -1));
    }
    return Akkerman(m, n);
}
Console.Clear();
Console.WriteLine("Введите первое число: ");
int one = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int two = Convert.ToInt32(Console.ReadLine());
Console.Write(Akkerman(one, two));

