// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// 456 -> 5 
// 782 -> 8
// 918 -> 1

// void rundomNumber(int start, int finish)
// {
//     int number = new Random().Next(start, finish+1);
//     int FerstNumber = number / 10;
//     int SecondNumber = FerstNumber % 10;
//     Console.Write(number + " -> " +  SecondNumber);
// }
// 0
// Console.Write("Введите минимальное число диапазона от 100 до 1000 ");
// int startNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число диапазона от 100 до 1000 ");
// int endNumber = Convert.ToInt32(Console.ReadLine());

// rundomNumber(startNumber, endNumber);

// int rundomNumber()

int SNmetod ()
{
   Console.Write("Введите трёхзначное число  ");
    int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write(startNumber + "->");
    int FerstNumber = startNumber / 10;
    int SecondNumber = FerstNumber % 10;
    return SecondNumber;
    
}

Console.WriteLine(SNmetod());

