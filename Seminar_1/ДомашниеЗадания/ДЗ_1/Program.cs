// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input number ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number ");
int number_2 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if (number_2 > max)
Console.Write("a=" + number_1 + "; " + "b=" + number_2 + "; " + "-> " + " max=" + number_2);

    else 
    Console.Write("a=" + number_1 + "; " + "b=" + number_2 + "; " + "-> " + " max=" + max);

        Console.Write("a=" + number_1 + "; " + "b=" + number_2 + "; " + "-> " + " числа равны");