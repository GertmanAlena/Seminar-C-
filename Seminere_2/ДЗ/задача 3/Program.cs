// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//  6 -> да 7 -> да 1 -> нет

Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
int Saturday = 6;
int Sunday = 7;
if(number == Saturday | number == Sunday)
{
    Console.Write(number + " Yes");
}
else
{
    Console.Write(number + " No");
}