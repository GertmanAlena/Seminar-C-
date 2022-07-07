// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         sum_pos += myArray[i];
//     else
//         sum_neg += myArray[i];
// }

// Console.WriteLine($"Сумма положительных: {sum_pos}. Сумма отрицательных: {sum_neg}");

                             //* * * * * 
// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//         Console.Write($"{array[i]}, ");
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//      Console.WriteLine("-> [ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i] *-1}, ");
//     }
//     Console.Write(" ]");
// }
// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

                        // *******
//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        {
        Console.Write(array[i] + " ");
        }
    Console.Write("]");
    
Console.WriteLine();
}

int FindArrey (int[] arrey)
{
    Console.WriteLine("Input FIND ");
    int find = Convert.ToInt32(Console.ReadLine());
    string msg = "No";
    for (int i = 0; i < arrey.Length; i++)
    {
        if (arrey[i] == find | arrey[i] == -find)
        {
            msg = "Yes";
            break;
        }
    }
    return msg;
}
int[] myArray = CreateRandomArray(12, -9, 9);

FindArrey(myArray);
ShowArray(myArray);




