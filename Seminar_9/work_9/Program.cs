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

int SumNumberRecurs(int n)
{
    if (n == 0) return 0; //условие окончания работы рекурсии
    return n % 10 + SumNumberRecurs(n/10);
}
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" {number} -> {SumNumberRecurs(number)}");