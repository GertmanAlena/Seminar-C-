// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
int Cub (int A, int B)
{    
    int proisv = 1;
    for (int i = 1; i <= B; i++)
    {
        proisv = proisv * A;
    }
    return proisv;
}

Console.WriteLine("Input number ");
int mnog1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number ");
int mnog2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{mnog1} {mnog2} -> {Cub(mnog1, mnog2)}");


