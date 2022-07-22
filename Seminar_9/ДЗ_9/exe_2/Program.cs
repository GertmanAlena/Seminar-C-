// Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumberRecurs(int m, int n)
{
    if(m == n || m == 0) return m;
    else if(m < n)
    {
        return m + SumNumberRecurs(m + 1, n);
    }
    else 
    {
        return m + SumNumberRecurs(m - 1, n);
    }
}
Console.Clear();
Console.WriteLine("Введите стартовое число: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число: ");
int end = Convert.ToInt32(Console.ReadLine());
Console.Write(SumNumberRecurs(start, end));