// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.Write("Input numberA: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Input numberB: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
    Console.Write("a =" + numberA + "b =" + numberB + "->"  + "->" + "Yes");
else
{
    Console.Write("a =" + numberA + "b =" + numberB + "->"  + "->" + "No");
}
