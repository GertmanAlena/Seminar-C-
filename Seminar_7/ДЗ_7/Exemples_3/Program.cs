// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int[,] RandomArray(int m, int n, int minVolue, int maxValue)
{
    int[,] Array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Array[i, j] = new Random().Next(minVolue, maxValue);
        }
    }
    return Array;
}
void PrintArray(int[,] mass)
{
    for (int rows = 0; rows < mass.GetLength(0); rows++)
    {
        for (int columns = 0; columns < mass.GetLength(1); columns++)
        {
            Console.Write($"{mass[rows, columns]}\t");
        }
        Console.WriteLine();
    }
}
double ArifmeticSumAlements(int[,] ArraySum)
{
    int Sum1 = 0;
    int Sum2 = 0;
    int Sum3 = 0;
    // int ArifmeticSumAlements1 = 0;
    // int ArifmeticSumAlements2 = 0;
    // int ArifmeticSumAlements3 = 0;
    for (int rows = 0; rows < ArraySum.GetLength(0); rows++)
    {
        for (int columns = 0; columns < ArraySum.GetLength(1); columns++)
        {
            if (columns == 0)
            {
                Sum1 += ArraySum[rows, columns];
                
            }
            if (columns == 1)
            {
                Sum2 += ArraySum[rows, columns];
            }
            if (columns == 2)
            {
                Sum3 += ArraySum[rows, columns];
            }
        }
    
    }
    Console.WriteLine($"сумма1 равна -> {Sum1/ArraySum.GetLength(0)}");
    Console.WriteLine($"сумма2 равна -> {Sum2}");
    Console.WriteLine($"сумма3 равна -> {Sum3}");
    // Console.WriteLine($"ср/ар элементов 1го столбца равна -> {ArifmeticSumAlements1}");
    // Console.WriteLine($"среднее арифметическое элементов 2го столбца равна -> {ArifmeticSumAlements2}");
    // Console.WriteLine($"среднее арифметическое элементов 3го столбца равна -> {ArifmeticSumAlements3}");
    return Sum1;
    return Sum2;
    return Sum3;
    
}
Console.Write("Input rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] myArray = RandomArray(rows, columns, 0, 20);
PrintArray(myArray);
ArifmeticSumAlements(myArray);
