// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Input number ");
// int Number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Number + "-> ");

// if(Number >= 0)
// {
//     for(int current = 1; current < Number; current++)
//     Console.Write(current * current * current + " ");
// }
// else
// {
//     for(int current = -1; current > Number; current--)
//     Console.Write(current * current * current + " ");
// }

double Cube(int N){
    return Math.Pow (N, 3);
}
Console.WriteLine("Input number ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.Write(Number + "-> ");
if(Number > 0)
{
    for(int current = 1; current < Number; current++)
    Console.Write(Cube(current) + " ");
}
else
{
    for(int current = -1; current > Number; current--)
    Console.Write(Cube(current) + " ");
}