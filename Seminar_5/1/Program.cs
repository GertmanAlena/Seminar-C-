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
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//         {
//         Console.Write(array[i] + " ");
//         }
//     Console.Write("]" + "->");
    
// Console.WriteLine();
// }

//     int[] myArray = CreateRandomArray(12, -9, 9);

//     Console.Write("Input FIND ");
//     int find = Convert.ToInt32(Console.ReadLine());
//     string msg = "No";
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         if (myArray[i] == find){
//             msg = "Yes";
//             break;
//         }
//     }
//     ShowArray(myArray);
//     Console.Write(msg);

                            //* * * * * 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// int[] CreateRandomArrey(int size, int min, int max)
// {
//     int[] newArrey = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArrey[i] = new Random().Next(min, max);
//     }
//     return newArrey;
// }

// void ShowArray(int[] arrey)
// {
//     Console.Write("[");
//     for (int i = 0; i < arrey.Length; i++)
//     {
//         Console.Write($"{arrey[i]},");
//     }
//     Console.Write("] ");
// }
// int[] myArrey = CreateRandomArrey(12, -9, 9);
// ShowArray(myArrey);

// int SumPos = 0;
// int SumNeg = 0;
// for (int i = 0; i < myArrey.Length; i++)
// {
//     if (myArrey[i] < 0)
//     {
//         SumNeg += myArrey[i];
//     }
//     else
//     {
//         SumPos += myArrey[i];
//     }
// }
// Console.Write($"сумма полож = {SumPos} and сумма отрицательных = {SumNeg}");

                    //***  ***  ***
// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Console.Clear();
// int[] CrRanomMass(int size, int min, int max)
// {
//     int[] arrey = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         arrey[i] = new Random().Next(min, max);
//     }
//     return arrey;
// }
// int[] myArrey = CrRanomMass(123, 1, 10000);

// void PrintMass(int[]Mass)
// {
//     int count = 0;
//     Console.Write("[");
//     for (int i = 0; i < Mass.Length; i++)
//     {
//         Console.Write($"{Mass[i]}, ");
//         if (Mass[i] > 10 && Mass[i] < 100)
//         {
//             count += 1;
//         }
//     }
//     Console.Write("]" + "-> ");
//     Console.WriteLine(count);
// }
// PrintMass(myArrey);

                //****  ****    *****       ********       ****
//Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве