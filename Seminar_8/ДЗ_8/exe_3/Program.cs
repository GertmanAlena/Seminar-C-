// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
    // Console.WriteLine();
}
int[,] MultiplicationArray (int[,] MultiOne, int[,] MultiTwo)
{
    if(MultiOne.GetLength(0) != MultiTwo.GetLength(1))throw new Exception("матрицы не перемножаются");
    int[,] ProisvedenieMatrix = new int[MultiOne.GetLength(0), MultiTwo.GetLength(1)];
    for (int i = 0; i < MultiOne.GetLength(0); i++)
    {
        for (int j = 0; j < MultiTwo.GetLength(1); j++)
        {
            for (int k = 0; k < MultiOne.GetLength(1); k++)
            {
                ProisvedenieMatrix[i, j] += MultiOne[i, k] * MultiTwo[k, j];
            }
        }
    }
    return ProisvedenieMatrix;
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
int[,]myArray2 = CreateArray(str, col, minValue, maxValue);
PrintArray(myArray);
Console.WriteLine();
PrintArray(myArray2);
int[,]myArray3 = MultiplicationArray(myArray, myArray2);
Console.WriteLine();
PrintArray(myArray3);
