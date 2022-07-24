// Задайте значение N. Вывести все натуральные числа от 1 до N
// Console.Clear();
// Console.Write("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // Numbers(N);
// Console.WriteLine(RecursiveNumbers(1, N));

// void Numbers(int num)
// {
//     for (int i = 0; i <= num; i++)
//     {
//         Console.Write($"'{i}' ");
//     }
// }
// string PrintNumbers(int num)  // метод из int в string
// {
//     string result = " ";
//     for (int i = 1; i <= num; i++)
//     {
//         result = result + " " + i.ToString();
//     }
//     return result;
// }

// string RecursiveNumbers(int start, int end)  // c рекурсией
// {
//     if(start == end)
//     { 
//     return start.ToString();
//     }
//     return start + " " + RecursiveNumbers(start+1, end);
// }
//*** *** *** ***
//Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N

// Console.Clear();
// Console.Write("Введите значение M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// // Numbers(N);
// Console.WriteLine(RecursiveNumbers(M, N));

// string RecursiveNumbers(int start, int end)  // c рекурсией
// {
//     if(start == end)
//     { 
//     return start.ToString();
//     }
//     return start + " " + RecursiveNumbers(start+1, end);
// }
//*** *** *** ***
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int SumNumberRecurs(int n)
// {
//     if (n == 0) return 0; //условие окончания работы рекурсии
//     return n % 10 + SumNumberRecurs(n/10);
// }
// Console.Clear();
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($" {number} -> {SumNumberRecurs(number)}");

// ***     ***         ***         ***         ***

// Формируется и выводится прямоугольный массив (5 строк и 6 столбцов)
// целых случайных чисел от -40 до 40. Вычисляется и выводится: а) сумма
// чисел в каждой строке; б) среднее арифметическое чисел в каждой строке;

// int[,] CreateArray(int str, int col)
// {
//     int[,] array = new int[str, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-40, 40);
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] mass)
// {
//     for (int rows = 0; rows < mass.GetLength(0); rows++)
//     {
//         int Sum = 0;
//         int SrArifm = 0;
//         for (int columns = 0; columns < mass.GetLength(1); columns++)
//         {
//             SrArifm = Sum/mass.GetLength(1);
//             Sum += mass[rows, columns];
//             Console.Write($"{mass[rows, columns]}\t");
//         }
//         Console.WriteLine($"сумма = {Sum} -> ср/ар строки = {SrArifm}");
//     }
// }

// Console.Clear();
// Console.WriteLine("Input string: ");
// int s = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateArray(s, c);
// PrintArray(myArray);

// ***     ***         ***         ***         ***
// Формируется и выводится прямоугольный массив (n строк и m столбцов)
// целых случайных чисел от -50 до 50. Вычисляется и выводится: а) среднее
// арифметическое отрицательных чисел в каждой строке; в) сумма и среднее
// арифметическое положительных четных чисел в каждой строке; д) сумма и
// среднее арифметическое всех чисел.
// int[,] CreateArray(int str, int col)
// {
//     int[,] array = new int[str, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-3, 15);
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] mass)
// {
//     int allSum = 0;
//     for (int rows = 0; rows < mass.GetLength(0); rows++)
//     {
//         int SumMin = 0;
//         // int SumPol = 0;
//         double SrArifm = 0;
//         for (int columns = 0; columns < mass.GetLength(1); columns++)
//         {
//             if (mass[rows, columns] < 0) SumMin += mass[rows, columns];
//             SrArifm = SumMin / mass.GetLength(1);
//             allSum += mass[rows, columns];
//             Console.Write($"{mass[rows, columns]}\t ");

//         }

//         Console.WriteLine($"сумма отриц = {SumMin} -> ср/ар отриц/ч строки = {(Math.Round(SrArifm), 2)}");
//     }
//         Console.WriteLine($" вся сумма--> {allSum}");
// }

// Console.Clear();
// Console.WriteLine("Input string: ");
// int s = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input columns: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateArray(s, c);
// PrintArray(myArray);

//                           ***     ***         ***         ***         ***
// Формируется и выводится прямоугольный массив - таблица умножения двух
// чисел от 1 до 10.

// int[,] CreateArray()
// {
//     int[,] array = new int[5, 10];
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         for (int j = 1; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i*j;
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] mass)
// {
//     for (int rows = 1; rows < mass.GetLength(0); rows++)
//     {
//         for (int columns = 1; columns < mass.GetLength(1); columns++)
//         {
//             Console.Write($"{mass[rows, columns]}\t ");
//         }
//     Console.WriteLine();
//     }
// }
// int[,] myArray = CreateArray();
// PrintArray(myArray);

//                           ***     ***         ***         ***         ***
// Формируется и выводится прямоугольный массив (6 строк и 8 столбцов)
// целых случайных чисел от -70 до 70. Вычисляется и выводится:
// а) максимальный элемент в каждой строке; б) минимальный положительный
// элемент в каждой строке.
// int[,] CreateArray()
// {
//     int[,] array = new int[6, 8];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-70, 70);
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] mass)
// {
//     int MinPositivNumber = mass[0, 0];
//     for (int rows = 0; rows < mass.GetLength(0); rows++)
//     {    
//         int Max = mass[rows, 0];
//         for (int columns = 0; columns < mass.GetLength(1); columns++)
//         {
//             Console.Write($"{mass[rows, columns]}\t ");
//             if(mass[rows, columns] > Max) Max = mass[rows, columns];
//         }
//         Console.Write($"max alement -> {Max}");
//         Console.WriteLine();
//     }
//     for (int rows = 0; rows < mass.GetLength(0); rows++)
//     {    

//             for (int columns = 0; columns < mass.GetLength(1); columns++)
//             {
//                 if(mass[rows, columns] > 0) MinPositivNumber = mass[rows, columns];
//             }
//         for (int columns = 0; columns < mass.GetLength(1); columns++)
//             {
//                 if(mass[rows, columns] > 0 && mass[rows, columns] < MinPositivNumber) MinPositivNumber = mass[rows, columns];
//             }
//     Console.WriteLine($" minPositivNumber первой строки -> {MinPositivNumber}");
//     }
// }
// int[,] myArray = CreateArray();
// PrintArray(myArray);

//                               ***     ***         ***         ***         ***
// Формируется и выводится прямоугольный массив (n строк и m столбцов)
// целых случайных чисел от -80 до 80. а) в каждой строке находится
// минимальный элемент и заменяется нулем; б) в каждом столбце находится
// максимальный элемент и заменяется единицей
// int[,] CreateArray(int n, int m)
// {
//     int[,] array = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             array[i, j] = new Random().Next(-80, 80);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] mass)
// {
//     for (int rows = 0; rows < mass.GetLength(0); rows++)
//     {    
//         int min = mass[rows, 0];
//         for (int columns = 0; columns < mass.GetLength(1); columns++)
//         {
//             Console.Write($"{mass[rows, columns]}\t ");
//             if(mass[rows, columns] < min) 
//             {
//                 min = mass[rows,columns];
//             }
//         }
//         Console.Write($"min -> {min}");
//         Console.WriteLine();
//     }
// }

// void ReplacementArrayTwo(int[,] mass)
// {
//     for (int rows = 0; rows < mass.GetLength(0); rows++)
//     {
//         int min = mass[rows, 0];
//         int rowsMinPosicion = 0;
//         int columnMinPosicion = 0;
//         for (int columns = 0; columns < mass.GetLength(1); columns++)
//         {
//             if (mass[rows, columns] < min)
//             {
//                 min = mass[rows, columns];
//                 rowsMinPosicion = rows;
//                 columnMinPosicion = columns;
//             }

//         }
//         mass[rowsMinPosicion, columnMinPosicion] = 0;
//         for (int columns = 0; columns < mass.GetLength(1); columns++)
//         {
//             Console.Write($"{mass[rows, columns]}\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     for (int columns = 0; columns < mass.GetLength(1); columns++)
//     {
//         int max = mass[0, columns];
//         int rowsMaxPosicion = 0;
//         int columnMaxPosicion = 0;
//         for (int rows = 0; rows < mass.GetLength(0); rows++)
//         {
//             if (mass[rows, columns] > max)
//             {
//                 max = mass[rows, columns];
//                 rowsMaxPosicion = rows;
//                 columnMaxPosicion = columns;
//             }
//         }
//         mass[columnMaxPosicion, rowsMaxPosicion] = 1;
//         for (int rows = 0; rows < mass.GetLength(1); rows++)
//         {
//             Console.Write($"{mass[rows, columns]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// Console.Write("Input n ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input m ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateArray(n, m);
// PrintArray(myArray);
// Console.WriteLine();
// ReplacementArrayTwo(myArray);

// ***         ***         ***         ***
// Формируется массив и выводится треугольная таблица, заполненная:
// а) единицами; б) нулями.

// int[] a = new int []{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
//         int[,] aa = new int[4, 4];
//         int n=0;
//         for (int i = 0; i < 4; i++)
//         {
//             for (int j = 0; j < 4; j++)
//             {
//                 if (j <= i) aa[i, j] = a[n++];
//                 else aa[i, j] = 0;
//                 Console.Write("{0} ", aa[i,j]);
//              }
//             Console.WriteLine();
//         }
