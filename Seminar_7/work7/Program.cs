// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// ***     ***     ***

// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Clear();

// int[,] GetArray(int m, int n)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i + j;
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns);
// PrintArray(array);

// ***         ***             ***

// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Console.Clear();

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int row = 0; row < inArray.GetLength(0); row++)
//     {
//         for (int column = 0; column < inArray.GetLength(1); column++)
//         {
//             Console.Write($"{inArray[row,column]} \t");
//         }
//         Console.WriteLine();
//     }
// }



// void NewArray(int[,] NewMass){
//     for (int i = 0; i < NewMass.GetLength(0); i++)
//     {
//        for (int j = 0; j < NewMass.GetLength(1); j++)
//        {
//         if (i % 2 == 0 && j % 2 == 0)
//         {
//             NewMass[i, j] = NewMass[i, j] * NewMass[i, j];
//             // Console.Write($"{NewMass[i,j]} \t");
//         }

//        }
//     }

// }
// Console.Write("Введите количество строк массива: ");
// int rows=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int columns=Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);
// Console.WriteLine();


// NewArray(array);
// PrintArray(array);

// ****            ****        ****        ****

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1)

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

void PrintArray(int[,] inArray)
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write($"{inArray[row, column]} \t");
        }
        Console.WriteLine();
    }
}
int SumAlements(int[,] mass)
{

    int Sum = 0;
    for (int row = 0; row < mass.GetLength(0); row++)
    {
        for (int column = 0; column < mass.GetLength(1); column++)
        {
            if (row == column)
            {
                Sum += mass[row, column];
            }

        }
    }
    Console.WriteLine($"сумма равна {Sum}");
    return Sum;

}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
SumAlements(array);
