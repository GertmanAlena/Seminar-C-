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
        int S = 0;
        for (int columns = 0; columns < mass.GetLength(1); columns++)
        {
            S += mass[rows, columns];
            Console.Write($"{mass[rows, columns]}\t ");
        }
    Console.Write($" сумма строки = {S}\t ");
    Console.WriteLine();
    }
    Console.WriteLine();
}

int MinSumRows(int[,] sumMass)
{
    int minSum = 0; 
    int row = 0;
    {
    for (int i = 0; i < sumMass.GetLength(1); i++)  //прошли только по первой строке и нашли сумму, 
                                                    //положили её в минимальное значение
        minSum = minSum + sumMass[0,i];
    }
    for (int i = 1; i < sumMass.GetLength(0); i++) 
    {
        int Sum = 0;
        for (int j = 0; j < sumMass.GetLength(1); j++) //обычный счётчик по строкам и столбцам
        {
            Sum += sumMass[i, j];
        }
        if (Sum < minSum)
        {
            minSum = Sum;
            row = i;
        }
    }
    return row;
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

int minS = MinSumRows(myArray);
Console.WriteLine($"минимальная сумма чисел в {minS+1} строке");