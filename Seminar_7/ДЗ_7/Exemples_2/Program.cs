// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Clear();
// int[,] CreateArray(int m, int n, int minVolume, int maxVolume)
// {

//     int[,] RandomArrey = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             RandomArrey[i, j] = new Random().Next(minVolume, maxVolume + 1);
//         }
//     }
//     return RandomArrey;
// }

// void PrintArray(int[,] mass)
// {

//     for (int rows = 0; rows < mass.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < mass.GetLength(1); columns++)
//         {
//             Console.Write($"{mass[rows, columns]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// int Find(int[,] FindAlements)
// {
//     int FindNumber = 5;
//     // int posicione = rows, columns;
//     int counts = 0;
//     for (int rows = 0; rows < FindAlements.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < FindAlements.GetLength(1); columns++)
//         {
//             if (FindAlements[rows, columns] == FindNumber)
//             {
//                 counts += 1;
//                 Console.WriteLine($"число '{FindNumber}' встречается на позиции [{rows}, {columns}]");
//                 // Console.Write(posicione);
//             }
//         }
//     }

//     if (counts == 0)
//             {
//             Console.WriteLine($"число '{FindNumber}' отсутствует");
//             }
//     else
//     {
//         Console.Write($"количество повторений -> {counts}");
//     }

//     return counts;
// }
// Console.Write("Input rows ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input columns ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateArray(rows, columns, 1, 20);
// PrintArray(myArray);
// Find(myArray);
//                  ***  ТАЖЕ ЗДАЧА ***
// ***  ТОЛЬКО ПО ПОЗИЦИИ ПОКАЗЫВАЕТ ЧИСЛО   ***
Console.Clear();
int[,] CreateArray(int m, int n, int minVolume, int maxVolume)
{

    int[,] RandomArrey = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            RandomArrey[i, j] = new Random().Next(minVolume, maxVolume + 1);
        }
    }
    return RandomArrey;
}

void PrintArray(int[,] mass)
{

    for (int rows = 0; rows < mass.GetLength(0); rows++)
    {
        for (int columns = 0; columns < mass.GetLength(1); columns++)
        {
            Console.Write($"{mass[rows, columns]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Input rows ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input columns ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateArray(rows, columns, 1, 20);
PrintArray(myArray);

void ShowNumber(int[,] ShowArrey)
{
Console.Write("Введите стоку ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец ");
int column = Convert.ToInt32(Console.ReadLine());
    if (row < ShowArrey.GetLength(0) && column < ShowArrey.GetLength(1))
    {
        Console.WriteLine($"на заданной позиции находится число {ShowArrey[row, column]}");
    }
    else
    {
        Console.WriteLine($"введённые числа превышают заданный массив");
    }

}

ShowNumber(myArray);

