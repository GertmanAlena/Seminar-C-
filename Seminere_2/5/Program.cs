int SumTwoNumbers()
{
    Console.Write("Введите минимальное число диапазона ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите максимальное число диапазона ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int sum = number1 + number2;
    return sum;
   
}
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Сумма чисел: " + SumTwoNumbers());
}

