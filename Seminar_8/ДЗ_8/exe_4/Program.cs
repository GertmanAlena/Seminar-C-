// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

// Console.Clear();
// Console.Write("Введите размеры трёмерного массива через пробел: ");
// string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = CreateArray(new int[] {int.Parse(numbers[0]),
//                                      int.Parse(numbers[1]),
//                                      int.Parse(numbers[2])}, 10, 99);
// PrintArray(array);

// int[,,] CreateArray(int[] size, int min, int max)
// {
//     int[,,] result = new int[size[0], size[1], size[2]];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < result.GetLength(2))
//             {
//                 int element = new Random().Next(min, max + 1);
//                 if (FindElement(result, element)) continue;
//                 result[i, j, k] = element;
//                 k++;
//             }

//         }
//     }
//     return result;
// }
// bool FindElement(int[,,] mass, int el)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             for (int k = 0; k < mass.GetLength(2); k++)
//             {
//                 if (mass[i, j, k] == el) return true;
//             }
//         }
//     }
//     return false;
// }
// void PrintArray(int[,,] arrayGo)
// {
//     for (int rows = 0; rows < arrayGo.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < arrayGo.GetLength(1); columns++)
//         {
//             for (int depth = 0; depth < arrayGo.GetLength(2); depth++)
//             {
//                 Console.Write($"{arrayGo[rows, columns, depth]}\t ");
//             }
//         }
//         Console.WriteLine();
//     }
// }

