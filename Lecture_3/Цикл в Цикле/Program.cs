﻿// Таблица умножения

for(int i = 2; i <= 10; i++) /*меняем 1 множитель*/
{
    for(int j = 2; j <= 10; j++)   /*меняем 2 множитель*/
    {
        Console.WriteLine($"{i} * {j} = {i*j}"); /*интерполяция строк*/
    }
    Console.WriteLine();
}
