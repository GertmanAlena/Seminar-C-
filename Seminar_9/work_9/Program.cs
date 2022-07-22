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