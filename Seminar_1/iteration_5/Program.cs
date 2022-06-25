// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.456 -> 6

Console.WriteLine("Введите трёхзначное число ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.Write(Number + "-> " + Number%10);

