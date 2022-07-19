// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Console.Clear();
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
            Console.Write($"{mass[rows, columns]}\t");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

void Replacement(int[,] ReplaceMass)
{
    for (int rows = 0; rows < ReplaceMass.GetLength(0); rows++)
    {
        for (int columns = 0; columns < ReplaceMass.GetLength(1); columns++)
        {
            int MinPosicion = columns; //минимальная позиция равная изначально столбцу 0
            for (int z = columns + 1; z < ReplaceMass.GetLength(1); z++)
            {
                if (ReplaceMass[rows, z] < ReplaceMass[rows,MinPosicion]) MinPosicion = z;
            }
            int temp = ReplaceMass[rows, columns]; //переменная храгящаянайденное меньшее
            ReplaceMass[rows, columns] = ReplaceMass[rows, MinPosicion];
            ReplaceMass[rows, MinPosicion] = temp;
            Console.Write($"{ReplaceMass[rows, columns]}\t");
        }
    Console.WriteLine();
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
Replacement(myArray);