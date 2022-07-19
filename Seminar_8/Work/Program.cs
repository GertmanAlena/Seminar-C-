// // Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
int[,] GetArrayTwo(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
void PrintArrayTwo(int[,] inArrayTwo)
{
    for (int i = 0; i < inArrayTwo.GetLength(0); i++)
    {
        for (int j = 0; j < inArrayTwo.GetLength(1); j++)
        {
            Console.Write($"{inArrayTwo[i,j]} ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = GetArray(rows, columns, min, max);
int[,] arrayTwo = GetArrayTwo(rows, columns, min, max);
PrintArray(array);
Console.WriteLine("----------------------- ");
if (rows == columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrayTwo[j,i] = array[i,j];
        }
    }
    PrintArrayTwo(arrayTwo);
}
else
Console.Write("Строки не равны столбцам ");