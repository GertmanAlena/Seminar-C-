// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

    Console.WriteLine("Input number ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number ");
    int B = Convert.ToInt32(Console.ReadLine());
    int proisv = 1;
    for (int i = 1; i <= B; i++)
    {
        proisv = proisv * A;
    }
  

Console.WriteLine($"{A} {B} -> {proisv}");


