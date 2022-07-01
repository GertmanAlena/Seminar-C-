// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(number + "-> ");

for(int current =1; current <= number; current++)
Console.Write(current*current + " ");