// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input number ");
int number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number ");
int number_2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number ");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if(number_2 > max) max = number_2;
if(number_3 > max) max = number_3;
Console.Write(number_1 + "," + number_2 + "," + number_3 + "," + "->");
Console.Write(max);
// else 
// max = number_2;
// Console.Write(number_1 + "," + number_2 + "," + number_3 + "," + "->");
// Console.Write(max);


