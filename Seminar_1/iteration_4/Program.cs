// // Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"

Console.Write("Input number ");
int Number = Convert.ToInt32(Console.ReadLine());

int FirstNumber = -Number;

while(FirstNumber <= Number)
{
        if (FirstNumber <= Number)
        Console.Write(FirstNumber + ", ");
        FirstNumber++;
}
