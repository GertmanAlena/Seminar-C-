// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// 456 -> 5 
// 782 -> 8
// 918 -> 1

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

