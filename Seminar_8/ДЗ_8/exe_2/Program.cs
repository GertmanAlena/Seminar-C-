// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int[,] CreateArray (int m, int n, int min, int max)
{
    int[,] Array = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Array[i,j] = new Random().Next(min, max);
        }
    }
    return Array;
}
void PrintArray (int[,] mass)
{
    for (int rows = 0; rows < mass.GetLength(0); rows++)
    {
        for (int columns = 0; columns < mass.GetLength(1); columns++)
        {
            Console.Write($"{mass[rows, columns]}\t ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void SumArray(int[,] sumMass)
{
    int MinSum = Sum;
    for (int rows = 0; rows < sumMass.GetLength(0); rows++)
    {
        int Sum = 0;
        
        for (int columns = 0; columns < sumMass.GetLength(1); columns++)
        {
            Sum += sumMass[rows, columns];
        }
        Console.WriteLine($"сумма строки с индексом [{rows}] = {Sum}\t");
        if(Sum < MinSum) MinSum = Sum;
        
        Console.WriteLine($"{MinSum}\t");
    }
}

Console.Write("Введите количество строк ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,]myArray = CreateArray(str, col, minValue, maxValue);
PrintArray(myArray);

SumArray(myArray);