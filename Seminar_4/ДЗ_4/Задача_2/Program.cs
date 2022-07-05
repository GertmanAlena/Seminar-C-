// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summa(int num)
{
    int Sum = 0;
    do
    {
        
        int N1 = num % 10;
        Sum = Sum + N1;
        num = num / 10;
    } while (num != 0);


    return Sum;
}
Console.WriteLine("input number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summa(number));