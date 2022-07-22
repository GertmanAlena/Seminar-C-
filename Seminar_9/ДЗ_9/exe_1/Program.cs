// Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

string RecursiveNumber (int m, int n)
{
    if(m == n) return m.ToString();
    return m + " " + RecursiveNumber(m+1, n);
}

Console.WriteLine("Введите стартовое число: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int end = Convert.ToInt32(Console.ReadLine());
Console.Write(RecursiveNumber(start, end));