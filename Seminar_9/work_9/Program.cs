// Задайте значение N. Вывести все натуральные числа от 1 до N
Console.Clear();
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
// Numbers(N);
Console.WriteLine(RecursiveNumbers(1, N));

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

string RecursiveNumbers(int start, int end)  // c рекурсией
{
    if(start == end)
    { 
    return start.ToString();
    }
    return start + " " + RecursiveNumbers(start+1, end);
}